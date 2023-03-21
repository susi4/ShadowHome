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
    public class UserService : IUserService
    {
        public UserRepository _userRepository;

        ISugarUnitOfWork<DbContext> _sugarUnitOfWork;

        public UserService(ISugarUnitOfWork<DbContext> sugarUnitOfWork)
        {
            _sugarUnitOfWork = sugarUnitOfWork;

        }

        public async Task<IEnumerable<UserModel>> GetList()
        {
            var a = _sugarUnitOfWork.CreateContext(true);

            //await a.OrderModel..BeginTranAsync();
            return await _userRepository.AsQueryable().Where(p => p.ManagerId == 1).ToListAsync();
        }

        public Task<IEnumerable<UserModel>> GetUser()
        {
            throw new System.NotImplementedException();
        }
    }
}
