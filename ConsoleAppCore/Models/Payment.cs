using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleAppCore.Models
{
    public partial class Payment
    {
        public Payment()
        {
            Orders = new HashSet<Order>();
        }

        public long IdPayment { get; set; }
        public string PaymentType { get; set; }
        public int? PaymentStatus { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
