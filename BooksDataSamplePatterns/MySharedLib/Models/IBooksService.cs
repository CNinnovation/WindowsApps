using System.Collections.Generic;

namespace BooksSample.Models
{
    public interface IBooksService
    {
        IEnumerable<Book> GetBooks();
        Book GetTheBook();
    }
}