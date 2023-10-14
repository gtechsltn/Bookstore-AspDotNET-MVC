using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleAppCore.Models
{
    public partial class Role
    {
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public long IdRole { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
