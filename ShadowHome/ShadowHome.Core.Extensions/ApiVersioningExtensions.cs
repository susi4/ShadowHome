using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.DependencyInjection;

namespace ShadowHome.Core.Extensions
{
    public static class ApiVersioningExtensions
    {
        public static void AddApiVersioningConfig(this IServiceCollection services)
        {
            services.AddApiVersioning(opt =>
            {
                opt.ReportApiVersions = true;
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.DefaultApiVersion = new ApiVersion(1, 0);
                //如果未加版本标记默认以当前最高版本进行处理
                opt.ApiVersionSelector = new CurrentImplementationApiVersionSelector(opt);
                opt.ApiVersionReader = new HeaderApiVersionReader("api-version");
            });           
        }
    }
}
