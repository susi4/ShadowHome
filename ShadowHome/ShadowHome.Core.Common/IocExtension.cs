using Microsoft.Extensions.DependencyInjection;
using ShadowHome.Core.Common;
using ShadowHome.Core.Common.AutoDI;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
namespace ShadowHome.Core.Extensions
{
    public class IocExtension : IIocExtension
    {
        public void Register(IServiceCollection services, string assemblyName = "ShadowHome.Core")
        {
            IEnumerable<Assembly> assemblies = AssemblyHelper.EnumerateAssemblies(p => p.Name.StartsWith(assemblyName));
            foreach (var assembly in assemblies)
            {
                var types = assembly.GetExportedTypes().Where(p => p.IsDefined(typeof(ServiceLifeTimeAttribute), true)).ToList();
                if (!types.Any())
                {
                    continue;
                }
                foreach (var type in types)
                {
                    if (type.GetCustomAttribute(typeof(ServiceLifeTimeAttribute)) is not ServiceLifeTimeAttribute serviceLifeTimeAttribute)
                    {
                        continue;
                    }
                    var interfaces = type.GetInterfaces();
                    if (!interfaces.Any())
                    {
                        continue;
                    }
                    foreach (var face in interfaces)
                    {
                        switch (serviceLifeTimeAttribute.ServiceLifetime)
                        {
                            case ServiceLifetime.Singleton:
                                services.AddSingleton(face, type);
                                break;
                            case ServiceLifetime.Scoped:
                                services.AddScoped(face, type);
                                break;
                            case ServiceLifetime.Transient:
                                services.AddTransient(face, type);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }          
        }  
    }
}
