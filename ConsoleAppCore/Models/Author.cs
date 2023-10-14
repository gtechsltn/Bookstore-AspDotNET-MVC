using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleAppCore.Models
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public long IdAuthor { get; set; }
        public string AuthorName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
