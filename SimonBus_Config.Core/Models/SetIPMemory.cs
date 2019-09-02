using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simon.Models.Configure
{
    public class SetIPMemory : Entity<int>
    {
        public string IP { get; set; }
    }
}
