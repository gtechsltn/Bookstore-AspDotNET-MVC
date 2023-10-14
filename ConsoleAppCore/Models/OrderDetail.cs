using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleAppCore.Models
{
    public partial class OrderDetail
    {
        public long Id { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public long IdBook { get; set; }
        public long OrderId { get; set; }

        public virtual Book IdBookNavigation { get; set; }
        public virtual Order Order { get; set; }
    }
}
