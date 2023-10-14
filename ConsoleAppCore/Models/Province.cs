using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleAppCore.Models
{
    public partial class Province
    {
        public Province()
        {
            Districts = new HashSet<District>();
        }

        public long ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public string ProvinceCode { get; set; }

        public virtual ICollection<District> Districts { get; set; }
    }
}
