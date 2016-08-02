using BooksDataBindingSample.Models;
using BooksDataBindingSample.Services;
using BooksSample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace BooksDataBindingSample.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private Book _theBook;
        private ObservableCollection<Book> _books;
        private readonly IMessageService _messageService;

        public MainPageViewModel(IMessageService messageService)
        {
            _messageService = messageService;

            _theBook = new BooksService().GetTheBook();
            _books = new ObservableCollection<Book>(new BooksService().GetBooks());
        }

        public IEnumerable<Book> Books => _books;


        public async void OnShowBook()
        {
            await _messageService.ShowMessageAsync($"{SelectedBook.Title}, {SelectedBook.Publisher}");
        }

        public void OnChangeBook()
        {
            _theBook.Title = "Professional C# 7";
        }

        public void OnAddBook()
        {
            _books.Add(new Book { BookId = 42, Title = "A Cool new book", Publisher = "Self" });
        }

        private Book _selectedBook;

        public Book SelectedBook
        {
            get { return _selectedBook; }
            set { SetProperty(ref _selectedBook, value); }
        }


    }
}
