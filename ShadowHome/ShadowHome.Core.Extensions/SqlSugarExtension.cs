using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShadowHome.Core.Common.Config;
using ShadowHome.Core.Repository;
using SqlSugar;
namespace ShadowHome.Core.Extensions
{
    public static class SqlSugarExtension
    {
        private const string defaultKey = "ConnectionStrings";

        public static void AddSqlSugar(this IServiceCollection services, IConfiguration configuration)
        {
            var options = configuration.GetSection(defaultKey).Get<DBOptions>();
            //多租户 new SqlSugarScope(List<ConnectionConfig>,db=>{});
            SqlSugarScope sqlSugar = new(new ConnectionConfig()
            {
                DbType = options.DbType.ToEnum(DbType.Oracle),
                ConnectionString = options.ConnectionString,
                IsAutoCloseConnection = options.IsAutoCloseConnection
            },
             db => {/***写AOP等方法***/});
            ISugarUnitOfWork<DbContext> context = new SugarUnitOfWork<DbContext>(sqlSugar);
            services.AddSingleton(context);
        }

        public static void AddSqlSugarIoc(this IServiceCollection services, IConfiguration configuration)
        {
            var options = configuration.GetSection(defaultKey).Get<DBOptions>();
            services.AddHttpContextAccessor();
            //注册SqlSugar
            services.AddScoped(s =>
            {
                ISqlSugarClient sqlSugar = new SqlSugarClient(new ConnectionConfig()
                {
                    DbType = options.DbType.ToEnum(DbType.Oracle),
                    ConnectionString = options.ConnectionString,
                    IsAutoCloseConnection = options.IsAutoCloseConnection,
                },
               db =>
               {
                   //单例参数配置，所有上下文生效
                   db.Aop.OnLogExecuting = (sql, pars) =>
                   {
                       var appServive = s.GetService<IHttpContextAccessor>();
                       //var obj = appServive?.HttpContext?.RequestServices.GetService<Log>();

                       foreach (var par in pars)
                       {
                           System.Console.WriteLine(par.Value);
                       }
                       System.Console.WriteLine(sql);
                   };
               });
                return sqlSugar;
            });
            IIocExtension iocExtension = new IocExtension();
            iocExtension.Register(services);
        }
    }
}
