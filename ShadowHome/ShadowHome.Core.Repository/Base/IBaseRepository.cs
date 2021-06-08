using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowHome.Core.Repository
{
    public interface IBaseRepository<TEntity> : ISugarRepository where TEntity : class, new()
    {
        ISimpleClient<TEntity> SimpleClient { get; set; }

        RepositoryType ChangeRepository<RepositoryType>() where RepositoryType : ISugarRepository;   
    }
}
