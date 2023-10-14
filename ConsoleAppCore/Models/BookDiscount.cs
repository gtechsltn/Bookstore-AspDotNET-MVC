using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleAppCore.Models
{
    public partial class BookDiscount
    {
        public long IdBook { get; set; }
        public long IdDiscount { get; set; }

        public virtual Book IdBookNavigation { get; set; }
        public virtual Discount IdDiscountNavigation { get; set; }
    }
}
