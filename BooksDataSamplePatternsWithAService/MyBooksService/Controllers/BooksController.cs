using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BooksModelLib;
using MyBooksService.Services;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyBooksService.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly IBooksService _booksService;
        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _booksService.GetBooks();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return _booksService.GetBookById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Book value)
        {
            _booksService.AddBook(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Book value)
        {
            if (id != value.BookId) throw new InvalidOperationException();
        }

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
