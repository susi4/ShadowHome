using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowHome.Core.Common.AutoDI
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ScopedAttribute : ServiceLifeTimeAttribute
    {
        public ScopedAttribute(params Type[] types)
            : base(ServiceLifetime.Scoped, types)
        {
        }
    }
}
