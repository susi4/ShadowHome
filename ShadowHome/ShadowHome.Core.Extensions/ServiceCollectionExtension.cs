using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShadowHome.Core.Common.Config;
using ShadowHome.Core.Repository;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                DbType =options.DbType ,
                ConnectionString = options.ConnectionString,
                IsAutoCloseConnection = options.IsAutoCloseConnection
            },
             db => {/***写AOP等方法***/});
            ISugarUnitOfWork<DbContext> context = new SugarUnitOfWork<DbContext>(sqlSugar);
            services.AddSingleton(context);
        }
    }
}
