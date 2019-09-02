using Microsoft.AspNetCore.Mvc;
using SimonBus_Config.Services;
using SimonBus_Config.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimonBus_Config.Web.Controllers
{
    [Route("api/[controller]")]
    public class AccountController
    {
        public IUserService UserService;
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
            var response = await UserService.GetUsers();
            return response.Select(x => new UserResponse() { UserName = x.Account, password = x.Password }).ToList();
        }
    }
}
