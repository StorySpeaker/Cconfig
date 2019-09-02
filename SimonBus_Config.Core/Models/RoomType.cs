using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simon.Models.Configure
{
    public class RoomType : Entity<int>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Remark { get; set; }

        public string CreatedDate { get; set; }

    }
}
