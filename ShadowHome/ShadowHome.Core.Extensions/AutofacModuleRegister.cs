using Autofac;
using ShadowHome.Core.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;

namespace ShadowHome.Core.Extensions
{
    public class AutofacModuleRegister : Autofac.Module
    {

        //private static readonly ILog log = LogManager.GetLogger(typeof(AutofacModuleRegister));
        /// <summary>
        /// 重写Autofac管道Load方法，在这里注册注入
        /// </summary>
        protected override void Load(ContainerBuilder builder)
        {
            var basePath = AppContext.BaseDirectory;
            var servicesDllFile = Path.Combine(basePath, "ShadowHome.Core.Services.dll");
            var repositoryDllFile = Path.Combine(basePath, "ShadowHome.Core.Repository.dll");

            if (!(File.Exists(servicesDllFile) && File.Exists(repositoryDllFile)))
            {
                var msg = "Repository.dll和service.dll 丢失，因为项目解耦了，所以需要先F6编译，再F5运行，请检查 bin 文件夹，并拷贝。";
                //log.Error(msg);
                throw new Exception(msg);
            }
            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IBaseRepository<>)).InstancePerDependency();//注册仓储
            //var cacheType = new List<Type>();
            // 获取 Service.dll 程序集服务，并注册
            var assemblysServices = Assembly.LoadFrom(servicesDllFile);
            builder.RegisterAssemblyTypes(assemblysServices)
                      .AsImplementedInterfaces()
                      .InstancePerDependency()
                      .PropertiesAutowired()
              /*        .EnableInterfaceInterceptors()*///引用Autofac.Extras.DynamicProxy;
                     /* .InterceptedBy(cacheType.ToArray())*/;//允许将拦截器服务的列表分配给注册。

            // 获取 Repository.dll 程序集服务，并注册
            var assemblysRepository = Assembly.LoadFrom(repositoryDllFile);
            builder.RegisterAssemblyTypes(assemblysRepository)
                   .AsImplementedInterfaces()
                   .PropertiesAutowired()
                   .InstancePerDependency();

            //builder.RegisterAssemblyTypes(GetAssemblyByName("ShadowHome.Core.Repository"))
            //    .Where(a => a.Name.EndsWith("Repository"))
            //    .AsImplementedInterfaces();

            //builder.RegisterAssemblyTypes(GetAssemblyByName("ShadowHome.Core.Service"))
            //    .Where(a => a.Name.EndsWith("Service"))
            //    .AsImplementedInterfaces();

            //注册MVC控制器（注册所有到控制器，控制器注入，就是需要在控制器的构造函数中接收对象）
            //builder.RegisterAssemblyTypes(GetAssemblyByName("ShadowHomeWebApi"))
            //    .Where(a => a.Name.EndsWith("Controller"))
            //    .AsImplementedInterfaces();
        }

        /// <summary>
        /// 根据程序集名称获取程序集
        /// </summary>
        /// <param name="assemblyName">程序集名称</param>
        //public static Assembly GetAssemblyByName(string assemblyName)
        //{
        //    return Assembly.Load(assemblyName);
        //}
    }
}
