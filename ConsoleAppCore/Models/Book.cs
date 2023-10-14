using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleAppCore.Models
{
    public partial class Book
    {
        public Book()
        {
            BookDiscounts = new HashSet<BookDiscount>();
            Items = new HashSet<Item>();
            OrderDetails = new HashSet<OrderDetail>();
            Reviews = new HashSet<Review>();
        }

        public long IdBook { get; set; }
        public string BookName { get; set; }
        public string DescribeBook { get; set; }
        public string Picture { get; set; }
        public decimal Price { get; set; }
        public DateTime PublishDay { get; set; }
        public int TotalQuantity { get; set; }
        public long IdAuthor { get; set; }
        public long CategoryId { get; set; }
        public long IdCompany { get; set; }

        public virtual Category Category { get; set; }
        public virtual Author IdAuthorNavigation { get; set; }
        public virtual PublishingCompany IdCompanyNavigation { get; set; }
        public virtual ICollection<BookDiscount> BookDiscounts { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
