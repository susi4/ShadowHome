using ShadowHome.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowHome.Core.IServices
{
    public interface IOrderService : IBaseService<Order>
    {
        IEnumerable<Order> GetList();


        IEnumerable<User> GetUser();

        //IEnumerable<OrderTest> GeOrderTestList();
    }
}
