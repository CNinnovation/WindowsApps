using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksModelLib
{
    public class Book
    {
        public Book()
        {
        }

        public int BookId { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
    }
}
