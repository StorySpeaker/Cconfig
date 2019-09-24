using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NLog;
using SimonBus_Config.Services;
using SimonBus_Config.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimonBus_Config.Web.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();
        public IUserService UserService { get; set; }
        public AccountController(IUserService userService)
        {
            UserService = userService;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        [HttpPost("Login")]
        public async Task Login([FromBody]LoginResponse response)
        {
            _logger.Info(new { Method = "Login", Describe = "登录", Data = response });
        }

        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetUsers")]
        public async Task<List<UserResponse>> GetUsers()
        {
            _logger.Info(JsonConvert.SerializeObject(new Logging() { Method = "GetUsers", Describe = "获取所有用户信息" }));
            var response = await UserService.GetUsers();
            return response.Select(x => new UserResponse() { Id = x.Id.ToString(), UserName = x.Account, password = x.Password, CreatedDate = x.CreatedDate }).ToList();
        }
    }
}
