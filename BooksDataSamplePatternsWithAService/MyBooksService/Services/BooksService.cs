using BooksModelLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBooksService.Services
{
    public sealed class BooksService : IDisposable, IBooksService
    {
        private BooksContext _context;
        public BooksService(BooksContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetBooks() => _context.Books;


        public Book GetBookById(int id) =>
            _context.Books.Single(b => b.BookId == id);

        public void AddBook(Book b)
        {
            _context.Books.Add(b);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
