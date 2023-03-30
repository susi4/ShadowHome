using ShadowHome.Core.Common.AutoDI;
using ShadowHome.Core.IRepository.IRepositories;
using ShadowHome.Core.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowHome.Core.Repository
{
    [Repository]
    public class UserRepository : SimpleClient<YJ_QX_CHUSHENGQXZDModel>, IUserRepository
    {
        public UserRepository(ISqlSugarClient db) : base(db)
        {

        }
        public async Task<IEnumerable<YJ_QX_CHUSHENGQXZDModel>> GetCaoZuoRZList()
        {
            return await GetListAsync();
        }
    }
}
