using ShadowHome.Core.Common.AutoDI;
using ShadowHome.Core.IRepository.IRepositories;
using ShadowHome.Core.IServices;
using ShadowHome.Core.Model;
using ShadowHome.Core.Repository;
using SqlSugar;
using SqlSugar.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShadowHome.Core.Services
{
    [Service]
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;

        }

        public async Task<IEnumerable<UserModel>> GetList()
        {
            return null;

        }

        public async Task<IEnumerable<UserModel>> GetUser()
        {
            return await _userRepository.GetListAsync(p=>p.UserId==1);
        }
    }
}
