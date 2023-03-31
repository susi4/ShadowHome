using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Reflection;

namespace ShadowHome.Core.Extensions
{
    public interface IDependencyInjectionExtension
    {
        void Register(IServiceCollection services, string assemblyName  = "ShadowHome.Core");
    }
}