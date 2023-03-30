using ShadowHome.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowHome.Core.IServices
{
    public interface IUserService
    {
        Task<IEnumerable<YJ_QX_CHUSHENGQXZDModel>> GetList();


        Task<IEnumerable<YJ_QX_CHUSHENGQXZDModel>> GetUser();
    }
}
