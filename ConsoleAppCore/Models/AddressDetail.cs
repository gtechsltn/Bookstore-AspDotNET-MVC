using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleAppCore.Models
{
    public partial class AddressDetail
    {
        public AddressDetail()
        {
            Orders = new HashSet<Order>();
            UserAddresses = new HashSet<UserAddress>();
        }

        public long AddressId { get; set; }
        public string AddressName { get; set; }
        public long WarrdId { get; set; }

        public virtual Ward Warrd { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
    }
}
