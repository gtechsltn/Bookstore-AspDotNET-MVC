using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleAppCore.Models
{
    public partial class PublishingCompany
    {
        public PublishingCompany()
        {
            Books = new HashSet<Book>();
        }

        public long IdCompany { get; set; }
        public string CompanyName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
