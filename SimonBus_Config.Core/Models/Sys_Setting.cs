using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simon.Models.Configure
{
    public class Sys_Setting : Entity<int>
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }
    }
}
