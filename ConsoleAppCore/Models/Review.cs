using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleAppCore.Models
{
    public partial class Review
    {
        public long IdBook { get; set; }
        public long UserId { get; set; }
        public string Comments { get; set; }
        public int Star { get; set; }
        public DateTime? Time { get; set; }

        public virtual Book IdBookNavigation { get; set; }
        public virtual Userinfor User { get; set; }
    }
}
