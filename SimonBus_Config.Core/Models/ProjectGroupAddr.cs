using Abp.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simon.Models.Configure
{
    public class ProjectGroupAddr : Entity<int>
    {

        public int ProjectID { get; set; }
        public virtual Project Project { get; set; }

        public int ParentID { get; set; }

        public string GroupAddress { get; set; }

        /// <summary>
        /// 组地址名
        /// </summary>
        public string Name { get; set; }

        public int Level { get; set; }

        public string Version { get; set; }

        public int IsPublish { get; set; }

        /// <summary>
        /// 组地址号 1~1023
        /// </summary>
        public int GroupNum { get; set; }

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
