using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleAppCore.Models
{
    public partial class Discount
    {
        public Discount()
        {
            BookDiscounts = new HashSet<BookDiscount>();
        }

        public long IdDiscount { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string ContentDiscount { get; set; }
        public int Status { get; set; }
        public int DiscountPercent { get; set; }

        public virtual ICollection<BookDiscount> BookDiscounts { get; set; }
    }
}
