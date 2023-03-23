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

        private readonly IUserService _userService;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        /// <summary>
        /// 这是一个接口
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetOrder")]
        public IEnumerable<Order> Get()
        {

            return new List<Order> { new Order {

                OrderId=1

            } };
            //return orderService.GetList();
        }


        [HttpGet("GetUser")]
        public async Task<IActionResult> GetUser()
        {
            return Ok(await _userService.GetUser());
        }
    }
}
