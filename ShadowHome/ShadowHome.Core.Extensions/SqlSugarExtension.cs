using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShadowHome.Core.Common.Config;
using ShadowHome.Core.Common.Helper;
using ShadowHome.Core.Repository;
using SqlSugar;
using System.Linq;

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
            services.AddScoped(service =>
            {
                ISqlSugarClient sqlSugar = new SqlSugarClient(new ConnectionConfig()
                {
                    DbType = options.DbType.ToEnum(DbType.Oracle),
                    ConnectionString = options.ConnectionString,
                    IsAutoCloseConnection = options.IsAutoCloseConnection,
                    InitKeyType = InitKeyType.SystemTable,
                },
               db =>
               {
                   //单例参数配置，所有上下文生效
                   db.Aop.OnLogExecuting = (sql, paras) =>
                   {
                       var appServive = service.GetService<IHttpContextAccessor>();
                       //System.Console.WriteLine(appServive.HttpContext.Request.ToString());
                       System.Console.WriteLine(SqlProfiler.ParameterFormat(sql, paras));
                   };
                   db.Aop.OnError = sqlSugarException =>
                   {
                       System.Console.WriteLine(SqlProfiler.ParameterFormat(sqlSugarException.Sql, sqlSugarException.Parametres));
                   };
               });
                return sqlSugar;
            });
            IIocExtension iocExtension = new IocExtension();
            iocExtension.Register(services);
        }
    }
}
