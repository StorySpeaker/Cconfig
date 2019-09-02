using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simon.Models.Configure
{
    public class Users : Entity<int>
    {
        public string Account { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public int Sort { get; set; }

        public string Remark { get; set; }

        public bool ActiveIndicator { get; set; }

        public string CreatedDate { get; set; }

        public int CurrentUser { get; set; }

        public int Language { get; set; }
    }
}
