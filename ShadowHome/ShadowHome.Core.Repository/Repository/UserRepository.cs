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
    public class UserRepository : SimpleClient<UserModel>, IUserRepository
    {


    }
}
