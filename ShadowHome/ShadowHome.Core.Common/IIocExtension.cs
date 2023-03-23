using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Reflection;

namespace ShadowHome.Core.Extensions
{
    public interface IIocExtension
    {
        void Register(IServiceCollection services, string assemblyName  = "ShadowHome.Core");
    }
}