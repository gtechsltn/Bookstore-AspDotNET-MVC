using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleAppCore.Models
{
    public partial class UserAddress
    {
        public long AddressId { get; set; }
        public long UserId { get; set; }

        public virtual AddressDetail Address { get; set; }
        public virtual Userinfor User { get; set; }
    }
}
