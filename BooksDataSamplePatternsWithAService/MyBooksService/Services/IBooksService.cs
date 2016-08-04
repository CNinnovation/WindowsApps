using System.Collections.Generic;
using BooksModelLib;

namespace MyBooksService.Services
{
    public interface IBooksService
    {
        void AddBook(Book b);
        Book GetBookById(int id);
        IEnumerable<Book> GetBooks();
    }
}