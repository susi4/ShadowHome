using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowHome.Core.Common.Config
{
    public class DBOptions
    {
        public string DbType { get; set; }
        public bool IsAutoCloseConnection { get; set; }
        public string ConnectionString { get; set; }
    }
}
