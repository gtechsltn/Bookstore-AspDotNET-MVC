using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleAppCore.Models
{
    public partial class Userinfor
    {
        public Userinfor()
        {
            Items = new HashSet<Item>();
            Orders = new HashSet<Order>();
            Reviews = new HashSet<Review>();
            UserAddresses = new HashSet<UserAddress>();
            UserRoles = new HashSet<UserRole>();
        }

        public long UserId { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int Gender { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }

        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
