using ShadowHome.Core.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowHome.Core.IRepository.IRepositories
{

    public interface IUserRepository : ISimpleClient<YJ_QX_CHUSHENGQXZDModel>, ISugarRepository
    {
        Task<IEnumerable<YJ_QX_CHUSHENGQXZDModel>> GetCaoZuoRZList();

    }
}
