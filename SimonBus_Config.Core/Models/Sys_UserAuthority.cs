using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simon.Models.Configure
{
    public class Sys_UserAuthority : Entity<int>
    {

        public int UserID { get; set; }
        public virtual Users Users { get; set; }

        public int AuthorityID { get; set; }
        public virtual Sys_Authorities Sys_Authorities { get; set; }
    }
}
