using Abp.Domain.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simon.Models.Configure
{
    public class Project : Entity<int>
    {
        public string Name { get; set; }

        public string ProjectDate { get; set; }

        public string Remark { get; set; }

        //public int? AddrMain { get; set; }

        //public int? AddrBranch { get; set; }

        public string Day { get; set; }


        public string Night { get; set; }

        public int? DoorbellTime { get; set; }

        public int? SavingMode { get; set; }

        /// <summary>
        /// 节能模式时间
        /// </summary>
        public string SavingModeTime { get; set; }

        /// <summary>
        /// 拔卡拖延时间（秒）
        /// </summary>
        public int? OutCardTime { get; set; }

        /// <summary>
        /// 排风扇使能
        /// </summary>
        public int? AirVentAuto { get; set; }

        public int? AirOpenTime { get; set; }

        public int? AirCloseTime { get; set; }

        public int ParentID { get; set; }

        public string ProjectAddress { get; set; }

        public int ProjectNum { get; set; }

        /// <summary>
        /// 是否已发布
        /// </summary>
        public int IsPublish { get; set; }

        public byte FirmwareVersion { get; set; }

        public short ConfigVersion { get; set; }

        public byte DeviceNum_485 { get; set; }

    }
}
