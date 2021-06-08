using Microsoft.Extensions.Configuration;
using ShadowHome.Core.Common;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowHome.Core.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        public ConnectionConfig ConnectionConfig { get; set; } = new ConnectionConfig()
        {
            ConfigId = ConfigurationManager.Configuration["DbInformation:ConfigId"],
            ConnectionString = ConfigurationManager.Configuration["DbInformation:ConnectionString"],
            DbType = (DbType)Convert.ToInt32(ConfigurationManager.Configuration["DbInformation:DbType"]),
            IsAutoCloseConnection = true//自动释放
        };
        public BaseRepository()
        {

        }
        public BaseRepository(ConnectionConfig ConnectionConfig)
        {
            this.ConnectionConfig = ConnectionConfig;
        }
        public ISqlSugarClient Context
        {
            get
            {
                if (context == null)
                {
                    context = new SqlSugarClient(ConnectionConfig);
                }
                return context;
            }
            set
            {
                context = value;
            }
        }

        public RepositoryType ChangeRepository<RepositoryType>() where RepositoryType : ISugarRepository
        {
            Type typeFromHandle = typeof(RepositoryType);

            object obj = Activator.CreateInstance(typeFromHandle, ConnectionConfig);

            RepositoryType result = (RepositoryType)obj;
            if (result.Context == null)
            {
                Context = result.Context;
            }
            return result;
        }


        public ISimpleClient<T> SimpleClient
        {
            get
            {
                if (simpleClient == null)
                {
                    simpleClient = new SimpleClient<T>(Context);
                }
                return simpleClient;
            }
            set
            {
                simpleClient = value;
            }
        }

        private ISimpleClient<T> simpleClient;

        private ISqlSugarClient context;
    }
}
