using ShadowHome.Core.Common.AutoDI;
using ShadowHome.Core.IRepository.IRepositories;
using ShadowHome.Core.IServices;
using ShadowHome.Core.Model;
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

        public async Task<IEnumerable<YJ_QX_CHUSHENGQXZDModel>> GetList()
        {
            return await _userRepository.GetCaoZuoRZList();

        }

        public async Task<IEnumerable<YJ_QX_CHUSHENGQXZDModel>> GetUser()
        {
            return await _userRepository.AsQueryable().Where(p=>p.Zuofeibz==1).ToListAsync();
        }
    }
}
