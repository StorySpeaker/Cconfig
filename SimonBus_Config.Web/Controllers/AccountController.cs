using Microsoft.AspNetCore.Mvc;
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
        public async Task Login()
        {

        }

        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetUsers")]
        public async Task<List<UserResponse>> GetUsers()
        {
            _logger.Info(new { message = "测试一下，不要紧张!" });
            _logger.Error(new { message = "测试测试" });
            _logger.Warn(new { message = "wadadasda" });
            var response = await UserService.GetUsers();
            return response.Select(x => new UserResponse() { UserName = x.Account, password = x.Password }).ToList();
        }
    }
}
