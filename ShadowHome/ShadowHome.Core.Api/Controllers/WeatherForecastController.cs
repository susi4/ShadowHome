using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShadowHome.Core.IServices;
using ShadowHome.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShadowHome.Core.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {      
        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IOrderService orderService;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IOrderService orderService )
        {
            _logger = logger;
            this.orderService = orderService;
        }

        [HttpGet("GetOrder")]
        public IEnumerable<Order> Get()
        {
            return orderService.GetList();
        }


        [HttpGet("GetUser")]

        public IEnumerable<User> GetUser()
        {
            return orderService.GetUser();
        }
    }
}
