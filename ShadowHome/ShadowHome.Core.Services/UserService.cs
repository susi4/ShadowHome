using ShadowHome.Core.IRepository.IRepositories;
using ShadowHome.Core.IServices;
using ShadowHome.Core.Model;
using ShadowHome.Core.Repository.Repository;
using SqlSugar;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShadowHome.Core.Services
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            ////SimpleClient = baseRepository.SimpleClient;
            //////simpleClient = baseRepository.SimpleClient.Change<OrderTest>();
            ////userRepository = baseRepository.ChangeRepository<BaseRepository<User>>();
        }

        public async Task<IEnumerable<UserModel>> GetList()
        {
            await _userRepository.AsTenant().BeginTranAsync();
            return await _userRepository.AsQueryable().Where(p => p.ManagerId == 1).ToListAsync();
        }

        public Task<IEnumerable<UserModel>> GetUser()
        {
            throw new System.NotImplementedException();
        }
    }
}
