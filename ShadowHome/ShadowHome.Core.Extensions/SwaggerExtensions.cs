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
        private static readonly string ApiName = Assembly.GetEntryAssembly().GetName().Name;
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = $"{ApiName}",
                    Description = $"{ApiName} HTTP API V1",
                });
                // 显示注释
                var xmlFilename = $"{ApiName}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename), true);
            });
        }
        public static void UseSwaggerUI(this IApplicationBuilder app)
        {
            //app.UseSwagger(opt => { 
            
            //opt.RouteTemplate=$"{}"
            //});
            app.UseSwaggerUI(opt =>
            {
                opt.SwaggerEndpoint($"{ApiName}/swagger/v1/swagger.json", $"{ApiName} V1");
                opt.RoutePrefix = $"{ApiName}/swagger";//请求swagger路径
            });
        }
    }
}
