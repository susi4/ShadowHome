using Autofac.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using ShadowHome.Core.Common.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShadowHome.Core.Extensions
{
    public static class SwaggerExtensions
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            // 注释
            //var xmlFilename = $"{Assembly.GetCallingAssembly().GetName().Name}.xml";
            // 生成多个文档显示
            //var ApiName = Assembly.GetCallingAssembly().GetName().Name;
            //services.AddMvc();
            //services.AddSwaggerGen(options =>
            //{
            //options.SwaggerDoc("v1", new OpenApiInfo
            //{
            //    // {ApiName} 定义成全局变量，方便修改
            //    Version = "v1",
            //    Title = $"{ApiName} 接口文档——Netcore 3.0",
            //    Description = $"{ApiName} HTTP API V1",

            //});

            services.AddSwaggerGen();
            // 第二个参数为是否显示控制器注释,我们选择true
            //options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename), true);
            //options.OrderActionsBy(o => o.RelativePath);
            //});
        }
        public static void UseSwaggerUI(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint($"/swagger/v1/swagger.json", $"{Assembly.GetCallingAssembly().GetName().Name} V1");
                options.RoutePrefix = string.Empty;//请求swagger路径
            });
        }
    }
}
