using Microsoft.Extensions.DependencyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
namespace ShadowHome.Core.Common
{
    public class AssemblyHelper
    {
        public static IEnumerable<Assembly> EnumerateAssemblies(Func<RuntimeLibrary, bool> predicate = null)
        {
            IEnumerable<RuntimeLibrary> runtimeLibraries = DependencyContext.Default.RuntimeLibraries.AsEnumerable();
            if (predicate != null)
            {
                runtimeLibraries = runtimeLibraries.Where(predicate);
            }

            foreach (RuntimeLibrary runtimeLibrary in runtimeLibraries)
            {
                Assembly assembly = null;
                try
                {
                    assembly = AssemblyLoadContext.Default.LoadFromAssemblyName(new AssemblyName(runtimeLibrary.Name));
                }
                catch (Exception)
                {
                }

                if (assembly != null)
                {
                    yield return assembly;
                }
            }
        }
        public static Assembly LoadByNameEndString(string endString)
        {
            string endString2 = endString;
            return EnumerateAssemblies((RuntimeLibrary m) => m.Name.EndsWith(endString2)).FirstOrDefault();
        }

        public static string GetCurrentAssemblyName()
        {
            return Assembly.GetCallingAssembly().GetName().Name;
        }
    }
}
