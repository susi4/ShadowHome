using ShadowHome.Core.IServices;
using SqlSugar;

namespace ShadowHome.Core.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class, new()
    {
        public ISimpleClient<TEntity> SimpleClient { get; set; }


    }
}
