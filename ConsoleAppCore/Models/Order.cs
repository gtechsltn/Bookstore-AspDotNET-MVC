using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleAppCore.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public long OrderId { get; set; }
        public string NameOfCustomer { get; set; }
        public DateTime? OrderDay { get; set; }
        public int? OrderStatus { get; set; }
        public string PhoneOfCustomer { get; set; }
        public decimal TotalPrice { get; set; }
        public long? AddressId { get; set; }
        public long? UserId { get; set; }
        public long? IdPayment { get; set; }

        public virtual AddressDetail Address { get; set; }
        public virtual Payment IdPaymentNavigation { get; set; }
        public virtual Userinfor User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
