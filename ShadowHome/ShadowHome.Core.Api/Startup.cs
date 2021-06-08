using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ShadowHome.Core.Common;
using ShadowHome.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShadowHome.Core.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

          //var a =  ConfigurationManager.Configuration["DbInformation:ConnectionString"];
        }

        public IConfiguration Configuration { get; }

        //This method gets called by the runtime.Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
        }


        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new AutofacModuleRegister());
            builder.RegisterModule<AutofacPropertityModuleReg>();
        }
        //public IServiceProvider ConfigureServices(IServiceCollection services)
        //{

        //    services.AddControllers();
        //    //services.Configure<CookiePolicyOptions>(options =>
        //    //{
        //    //    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
        //    //    options.CheckConsentNeeded = context => true;
        //    //    options.MinimumSameSitePolicy = SameSiteMode.None;
        //    //});

        //    //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

        //    return RegisterAutofac(services); //注册Autofac
        //}


        /// <summary>
        /// 注册Autofac
        /// </summary>
        //private static IServiceProvider RegisterAutofac(IServiceCollection services)
        //{
        //    //实例化Autofac容器
        //    var builder = new ContainerBuilder();
        //    //将services中的服务填充到Autofac中
        //    builder.Populate(services);
        //    //新模块组件注册
        //    builder.RegisterModule<AutofacModuleRegister>();
        //    //创建容器
        //    var container = builder.Build();
        //    //第三方IoC容器接管Core内置DI容器
        //    return new AutofacServiceProvider(container);
        //}


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
