using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShadowHome.Core.Api.Dto;
using ShadowHome.Core.IServices;
using ShadowHome.Core.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShadowHome.Core.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
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
        [HttpPost("GetOrder")]
        public async Task<IActionResult> Get(CreateUserDto createUserDto)
        {
            var a = await _userService.GetList();
            return Ok(a);
        
            //return orderService.GetList();
        }


        [HttpGet("GetUser")]
        public async Task<IActionResult> GetUser()
        {
            return Ok(await _userService.GetUser());
        }
    }
}
