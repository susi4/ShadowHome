using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
namespace ShadowHome.Core.Common
{
    public class ConfigurationManager
    {
        public static IConfiguration Configuration { get; set; }
        static ConfigurationManager()
        {          
            Configuration = new ConfigurationBuilder()
            .Add(new JsonConfigurationSource { Path = "appsettings.json", ReloadOnChange = true })
            .Build();
        }
    }
}
