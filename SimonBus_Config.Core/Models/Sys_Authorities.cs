using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simon.Models.Configure
{
    public class Sys_Authorities : Entity<int>
    {
        public int ParentID { get; set; }

        public string Name { get; set; }

        public string EName { get; set; }

        public string Url { get; set; }

        public string Icon { get; set; }

        public bool IsMenu { get; set; }

        public int Sort { get; set; }

        public bool ActiveIndicator { get; set; }
    }
}
