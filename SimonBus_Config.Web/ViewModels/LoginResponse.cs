using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimonBus_Config.Web.ViewModels
{
    public class LoginResponse
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string loginname { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string password { get; set; }
    }
}
