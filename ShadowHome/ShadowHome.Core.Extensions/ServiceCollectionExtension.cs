using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShadowHome.Core.Common.Config;
using ShadowHome.Core.Repository;
using SqlSugar;
using SqlSugar.IOC;
using System;

namespace ShadowHome.Core.Extensions
{
    public static class ServiceCollectionExtension
    {
        private const string defaultKey = "ConnectionStrings";

        public static void AddSqlsugarSetup(this IServiceCollection services, IConfiguration configuration)
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

        public static void AddSqlSugarIocSetup(this IServiceCollection services, IConfiguration configuration,object target)
        {
            var options = configuration.GetSection(defaultKey).Get<DBOptions>();
            services.AddSqlSugar(new IocConfig()
            {
                ConnectionString = options.ConnectionString,
                DbType = options.DbType.ToEnum(IocDbType.Oracle),
                IsAutoCloseConnection = options.IsAutoCloseConnection   
            });

            //注入Controller层
            services.AddIoc(target, "ShadowHome.Core.Api", it => it.Name.Contains("Controller"));

            //注入Service层
            services.AddIoc(target, "ShadowHome.Core.Services", it => it.Name.Contains("Services"));

            //注入Repository层
            services.AddIoc(target, "ShadowHome.Core.Repository", it => it.Name.Contains("Repository"));
        }
    }
}
