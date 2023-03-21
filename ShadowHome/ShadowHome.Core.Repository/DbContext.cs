using ShadowHome.Core.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowHome.Core.Repository
{
    /// <summary>
    /// 自定义DbContext
    /// </summary>
    public class DbContext : SugarUnitOfWork
    {
        public UserRepository OrderModel { get; set; }

    }

}
