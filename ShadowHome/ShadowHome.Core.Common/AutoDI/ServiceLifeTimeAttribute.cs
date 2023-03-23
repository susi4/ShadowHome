using Microsoft.Extensions.DependencyInjection;
using System;
namespace ShadowHome.Core.Common.AutoDI
{
    public abstract class ServiceLifeTimeAttribute : Attribute
    {
        public ServiceLifetime ServiceLifetime { get; }

        public Type[] InterfaceTypes { get; }

        public ServiceLifeTimeAttribute(ServiceLifetime serviceLifetime, params Type[] types)
        {
            ServiceLifetime = serviceLifetime;
            InterfaceTypes = types;
        }
    }
}
