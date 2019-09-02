using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simon.Models.Configure
{
    public class Part : Entity<int>
    {
        /// <summary>
        /// 元件固号
        /// </summary>
        public string ModuleID { get; set; }

        /// <summary>
        /// 模块名
        /// </summary>
        public string ModuleName { get; set; }

        public string ModuleEName { get; set; }


        public string ModuleCode { get; set; }


        public string AttributeCode { get; set; }

        public string RCUID { get; set; }

        public string RCUName { get; set; }

        public string RCUEName { get; set; }

        public string ImpartDate { get; set; }

        public string ValidDate { get; set; }

    }
}
