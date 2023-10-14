using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleAppCore.Models
{
    public partial class Ward
    {
        public Ward()
        {
            AddressDetails = new HashSet<AddressDetail>();
        }

        public long WardId { get; set; }
        public string WardName { get; set; }
        public string WardPrefix { get; set; }
        public long DistrictId { get; set; }

        public virtual District District { get; set; }
        public virtual ICollection<AddressDetail> AddressDetails { get; set; }
    }
}
