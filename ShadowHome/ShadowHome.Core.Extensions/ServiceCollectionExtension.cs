using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShadowHome.Core.Common.Config;
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
            var options = configuration.GetSection(defaultKey);
            //多租户 new SqlSugarScope(List<ConnectionConfig>,db=>{});
            SqlSugarScope sqlSugar = new(new ConnectionConfig()
            {
                DbType = DbType.Oracle,
                //ConnectionString = configuration.GetConnectionString(dbName),
                IsAutoCloseConnection = true,
            },
             db => {/***写AOP等方法***/});
            //ISugarUnitOfWork<MyDbContext> context = new SugarUnitOfWork<MyDbContext>(sqlSugar);
            //services.AddSingleton<ISugarUnitOfWork<MyDbContext>>(context);
        }
    }
}
