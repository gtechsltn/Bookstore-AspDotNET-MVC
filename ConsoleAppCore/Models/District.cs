using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleAppCore.Models
{
    public partial class District
    {
        public District()
        {
            Wards = new HashSet<Ward>();
        }

        public long DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string DistrictPrefix { get; set; }
        public long? ProvinceId { get; set; }

        public virtual Province Province { get; set; }
        public virtual ICollection<Ward> Wards { get; set; }
    }
}
