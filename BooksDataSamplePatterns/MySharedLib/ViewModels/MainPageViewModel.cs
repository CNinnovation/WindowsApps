using BooksDataBindingSample.Services;
using BooksSample.Models;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BooksDataBindingSample.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private ObservableCollection<Book> _books;
        private readonly IMessageService _messageService;
        private readonly IBooksService _booksService;

        public MainPageViewModel(IMessageService messageService, IBooksService booksService)
        {
            _messageService = messageService;
            _booksService = booksService;

            AddBookCommand = new DelegateCommand(OnAddBook);
            InitBooks();
        }

        private void InitBooks()
        {
            _books = new ObservableCollection<Book>(_booksService.GetBooks());
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

        public ICommand AddBookCommand { get; }

        private Book _selectedBook;

        public Book SelectedBook
        {
            get { return _selectedBook; }
            set { SetProperty(ref _selectedBook, value); }
        }


    }
}
