using BooksSample.Models;
using MySharedLib.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySharedLib.Models
{
    public class BooksAPIService : IBooksService
    {
        private readonly BooksClientManager _clientManager;
        public BooksAPIService(BooksClientManager clientManager)
        {
            _clientManager = clientManager;
        }

        public Task<IEnumerable<Book>> GetBooksAsync(string url)
        {
            return _clientManager.GetItemsAsync(url);
        }

        public Task<Book> GetTheBookAsync(string url)
        {
            return _clientManager.GetItemAsync(url);
        }
    }
}
