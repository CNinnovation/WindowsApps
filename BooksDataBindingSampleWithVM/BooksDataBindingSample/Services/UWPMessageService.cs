using System;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace BooksDataBindingSample.Services
{
    public class UWPMessageService : IMessageService
    {
        public Task ShowMessageAsync(string message)
        {
            return new MessageDialog(message).ShowAsync().AsTask();
        }
    }
}
