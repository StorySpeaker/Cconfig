using Abp.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simon.Models.Configure
{
    public class ProjectDeviceAddr : Entity<int>
    {

        public int ProjectID { get; set; }
        public virtual Project Project { get; set; }

        public int ParentID { get; set; }

        public string DeviceAddress { get; set; }

        public string ModuleID { get; set; }

        public string ModuleCode { get; set; }

        public string LoopJ { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string EName { get; set; }

        public int Level { get; set; }

        public string Name1 { get; set; }

        public string EName1 { get; set; }

        /// <summary>
        /// 使用次数
        /// </summary>
        public int UsedCount { get; set; }

        /// <summary>
        /// 物理地址号 1~255
        /// </summary>
        public int DeviceNum { get; set; }

        /// <summary>
        /// 是否已发布
        /// </summary>
        public int IsPublish { get; set; }

        /// <summary>
        /// 功能号
        /// </summary>
        public int FuncNo { get; set; }

        /// <summary>
        /// 回路类型
        /// </summary>
        public byte ObjectType1 { get; set; }

        /// <summary>
        /// 回路类型
        /// </summary>
        public short ObjectType2 { get; set; }

        /// <summary>
        /// 对象属性
        /// </summary>
        public byte ObjectProperty { get; set; }

        public short ConfigVersion { get; set; }

        //public byte FirmwareVersion { get; set; }

        public byte M_Param0 { get; set; }

        public byte M_Param1 { get; set; }

        public byte M_Param2 { get; set; }

        public byte M_Param3 { get; set; }

        public byte M_Param4 { get; set; }

        public byte M_Param5 { get; set; }

        public byte M_Param6 { get; set; }

        public byte M_Param7 { get; set; }

        public byte M_Param8 { get; set; }

        public byte M_Param9 { get; set; }

    }
}
