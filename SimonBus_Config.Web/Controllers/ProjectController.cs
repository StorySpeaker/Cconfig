using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimonBus_Config.Web.Controllers
{
    [Route("api/[controller]")]
    public class ProjectController
    {
        public ProjectController()
        {
        }

        /// <summary>
        /// 获取所有项目
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public async Task GetAll()
        {

        }
    }
}