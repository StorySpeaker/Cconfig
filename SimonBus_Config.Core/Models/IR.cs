using System;
using Abp.Domain.Entities;

namespace SimonBus_Config.Core
{
    public class IR : Entity<int>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string EName { get; set; }

        public string Type { get; set; }

        public int Sort { get; set; }

        public string Remark { get; set; }

        public string IRCode { get; set; }
    }
}
