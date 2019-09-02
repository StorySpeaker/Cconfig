using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simon.Models.Configure
{
    public class Packets : Entity<int>
    {
        public string IP { get; set; }

        public int Port { get; set; }

        public string SendData { get; set; }

        public string Result { get; set; }

        public string SendDate { get; set; }

        public string ReceiveData { get; set; }

    }
}
