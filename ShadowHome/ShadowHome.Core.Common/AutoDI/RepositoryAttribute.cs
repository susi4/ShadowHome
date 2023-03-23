using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowHome.Core.Common.AutoDI
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class RepositoryAttribute : ServiceLifeTimeAttribute
    {
        public RepositoryAttribute(ServiceLifetime serviceLifetime = ServiceLifetime.Scoped, params Type[] types)
            : base(serviceLifetime, types)
        {
        }
    }
}

