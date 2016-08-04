using System.Collections.Generic;
using System.Threading.Tasks;

namespace BooksSample.Models
{
    public interface IBooksService
    {
        Task<IEnumerable<Book>> GetBooksAsync(string url);
        Task<Book> GetTheBookAsync(string url);
    }
}