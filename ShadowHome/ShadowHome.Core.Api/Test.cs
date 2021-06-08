using Microsoft.AspNetCore.Mvc;
using System;

namespace ShadowHome.Core.Api
{

    [Controller]
    [Route("api/[controller]")]
    public class Test
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        [HttpGet]
        public string Get()
        {
            return "TestController";
        }

    }
}
