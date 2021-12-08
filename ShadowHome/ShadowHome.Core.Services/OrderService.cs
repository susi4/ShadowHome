using ShadowHome.Core.IServices;
using ShadowHome.Core.Model;
using ShadowHome.Core.Repository;
using System.Collections.Generic;
namespace ShadowHome.Core.Services
{
#pragma warning disable CS0436 
    public class OrderService : BaseService<Order>, IOrderService
#pragma warning restore CS0436 // 类型与导入类型冲突
    {
        public IBaseRepository<User> userRepository;
        //public ISimpleClient<OrderTest> simpleClient;


        public OrderService(IBaseRepository<Order> baseRepository)
        {
            SimpleClient = baseRepository.SimpleClient;
            //simpleClient = baseRepository.SimpleClient.Change<OrderTest>();
            userRepository = baseRepository.ChangeRepository<BaseRepository<User>>();
        }

        //public IEnumerable<OrderTest> GeOrderTestList()
        //{

        //    return orderTestRepository.SimpleClient.GetList();
        //    //return SimpleClient.Change<OrderTest>().GetList();

        //}

        public dynamic Get()
        {
            return SimpleClient.AsSugarClient().SqlQueryable<dynamic>("");
        }

        public IEnumerable<Order> GetList()
        {
            return SimpleClient.GetList();

        }

        public IEnumerable<User> GetUser()
        {
            return userRepository.SimpleClient.GetListAsync().Result ;

        }
    }
}
