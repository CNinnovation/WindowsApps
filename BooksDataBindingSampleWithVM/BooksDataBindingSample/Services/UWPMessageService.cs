using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
