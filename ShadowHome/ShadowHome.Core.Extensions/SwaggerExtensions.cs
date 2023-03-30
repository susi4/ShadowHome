using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;

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
                var xmlFileName = $"{ApiName}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFileName), true);
            });
        }
        public static void UseSwaggerUI(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(opt =>
            {
                opt.SwaggerEndpoint($"/swagger/v1/swagger.json", $"{ApiName} V1");
                //opt.RoutePrefix = $"{ApiName}/swagger";//请求swagger路径
            });
        }
    }
}
