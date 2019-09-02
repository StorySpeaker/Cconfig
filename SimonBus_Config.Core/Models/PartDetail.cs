using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simon.Models.Configure
{
    public class PartDetail : Entity<int>
    {
        public int PartID { get; set; }
       
        public string LoopJ { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string EName { get; set; }

        public int Num { get; set; }

        public virtual Part Part { get; set; }
    }
}
