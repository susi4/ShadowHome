using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.DependencyModel;
using ShadowHome.Core.Common;
using ShadowHome.Core.Common.Config;
using ShadowHome.Core.Repository;
using SqlSugar;
using SqlSugar.IOC;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;

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

        public static void AddSqlSugarIocSetup(this IServiceCollection services, IConfiguration configuration)
        {
            var options = configuration.GetSection(defaultKey).Get<DBOptions>();
            services.AddSqlSugar(new IocConfig()
            {
                ConnectionString = options.ConnectionString,
                DbType = options.DbType.ToEnum(IocDbType.Oracle),
                IsAutoCloseConnection = options.IsAutoCloseConnection
            });
            IIocExtension iocExtension = new IocExtension();
            iocExtension.Register(services);
        }
    }
}
