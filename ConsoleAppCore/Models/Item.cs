using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleAppCore.Models
{
    public partial class Item
    {
        public long ItemId { get; set; }
        public int QuantityBooks { get; set; }
        public long IdBook { get; set; }
        public long UserId { get; set; }

        public virtual Book IdBookNavigation { get; set; }
        public virtual Userinfor User { get; set; }
    }
}
