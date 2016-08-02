using BooksDataBindingSample.Models;
using BooksDataBindingSample.Services;
using BooksSample.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BooksDataBindingSample.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private ObservableCollection<Book> _books;
        private readonly IMessageService _messageService;

        public MainPageViewModel(IMessageService messageService)
        {
            _messageService = messageService;

            _books = new ObservableCollection<Book>(new BooksService().GetBooks());
        }

        public IEnumerable<Book> Books => _books;


        public async void OnShowBook()
        {
            await _messageService.ShowMessageAsync($"{SelectedBook.Title}, {SelectedBook.Publisher}");
        }

        public void OnChangeBook()
        {
            SelectedBook.Title = SelectedBook.Title + "..";
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
