using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimonBus_Config.Web
{
    /// <summary>
    /// 日志规范
    /// </summary>
    public class Logging
    {
        /// <summary>
        /// 方法名
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Describe { get; set; }
    }
}
