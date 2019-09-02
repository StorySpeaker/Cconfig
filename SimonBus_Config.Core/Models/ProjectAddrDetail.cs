using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simon.Models.Configure
{
    public class ProjectAddrDetail : Entity<int>
    {

        #region 外键

        public int ProjectID { get; set; }
        public virtual Project Project { get; set; }


        public int ProjectDeviceAddrID { get; set; }
        public virtual ProjectDeviceAddr ProjectDeviceAddr { get; set; }


        public int ProjectGroupAddrID { get; set; }
        public virtual ProjectGroupAddr ProjectGroupAddr { get; set; }
        #endregion

        //[Column(TypeName = "varchar")]
        //[StringLength(20)]
        //public string GroupAddress { get; set; }

        //[Column(TypeName = "varchar")]
        //[StringLength(20)]
        //public string DeviceAddress { get; set; }


        public string ModuleCode { get; set; }

        public string AttributeCode { get; set; }

        public string LoopJ { get; set; }

        //[Column(TypeName = "varchar")]
        //[StringLength(20)]
        //public string Code { get; set; }

        public string Name { get; set; }

        public string EName { get; set; }

        public string GroupAddrSort { get; set; }

        public string DeviceAddrSort { get; set; }

        public string Superior { get; set; }

        public int Param1 { get; set; }

        public int Param2 { get; set; }

        public int Param3 { get; set; }

        public int Param4 { get; set; }

        public int Param5 { get; set; }

        public int Param6 { get; set; }

        public int Param7 { get; set; }

        public int Param8 { get; set; }

        public int Param9 { get; set; }

        public int Param10 { get; set; }

        public int Param11 { get; set; }

        public int Param12 { get; set; }

        public int Param13 { get; set; }

        public int Param14 { get; set; }

        public int Param15 { get; set; }

        public int Param16 { get; set; }

        public int Param17 { get; set; }

        public int Param18 { get; set; }

        public int Param19 { get; set; }

        public int Param20 { get; set; }

        public int Param21 { get; set; }

        public int Param22 { get; set; }

        public int Param23 { get; set; }

        public int Param24 { get; set; }

        public int Param25 { get; set; }

        public int Param26 { get; set; }

        public int Param27 { get; set; }

        public int Param28 { get; set; }

        public int Param29 { get; set; }

        public int Param30 { get; set; }

        public int Param31 { get; set; }

        public int Param32 { get; set; }

        public int Param33 { get; set; }

        public int Param34 { get; set; }

        public int Param35 { get; set; }

        public int Param36 { get; set; }

        public int Param37 { get; set; }

        public int Param38 { get; set; }

        public int Param39 { get; set; }

        public int Param40 { get; set; }

        public int Param41 { get; set; }

        public int Param42 { get; set; }

        //CXY   2016.12.19
        public int FuncNo { get; set; }

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
