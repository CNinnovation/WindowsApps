using System.Threading.Tasks;

namespace BooksDataBindingSample.Services
{
    public interface IMessageService
    {
        Task ShowMessageAsync(string message);
    }
}
