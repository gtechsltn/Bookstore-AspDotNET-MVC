using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleAppCore.Models
{
    public partial class UserRole
    {
        public long UserRoleId { get; set; }
        public long? IdRole { get; set; }
        public long? UserId { get; set; }

        public virtual Role IdRoleNavigation { get; set; }
        public virtual Userinfor User { get; set; }
    }
}
