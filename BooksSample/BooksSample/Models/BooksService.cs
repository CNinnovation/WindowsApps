using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSample.Models
{
    public class BooksService
    {
        public Book GetTheBook() =>
            new Book { BookId = 1, Title = "Professional C# 6", Publisher = "Wrox Press" };

        public IEnumerable<Book> GetBooks() =>
            new List<Book>()
            {
                new Book { BookId = 1, Title = "Professional C# 6", Publisher = "Wrox Press" },
                new Book { BookId = 2, Title = "Beginning Visual C#", Publisher = "Wrox Press" },
                new Book { BookId = 3, Title = "Enterprise Services", Publisher = "AWL" }
            };
    }
}
