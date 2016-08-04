using System.Collections.Generic;

namespace BooksSample.Models
{
    public class BooksService 
    {
        public Book GetTheBook() =>
            new Book { BookId = 1, Title = "Professional C# 6", Publisher = "Wrox Press" };

        public IEnumerable<Book> GetBooks() =>
            new List<Book>()
            {
                new Book { BookId = 1, Title = "Professional C# 6", Publisher = "Wrox Press", Authors= new string[] {"Christian Nagel" } },
                new Book { BookId = 2, Title = "Beginning Visual C#", Publisher = "Wrox Press", Authors = new string[] 
                {
                    "Karli Watson",
                    "Christian Nagel"
                } },
                new Book { BookId = 3, Title = "Enterprise Services", Publisher = "AWL" }
            };
    }
}
