using BooksSample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BooksDataBindingSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Book _theBook;
        private ObservableCollection<Book> _books;
        public MainPage()
        {
            this.InitializeComponent();
            _theBook = new BooksService().GetTheBook();
            _books = new ObservableCollection<Book>(new BooksService().GetBooks());

            // this.DataContext = this;
        }

        public IEnumerable<Book> Books => _books;


        private async void OnShowBook(object sender, RoutedEventArgs e)
        {
            await new MessageDialog($"{_theBook.Title} {_theBook.Publisher}").ShowAsync();
        }

        private void OnChangeBook(object sender, RoutedEventArgs e)
        {
            _theBook.Title = "Professional C# 7";
        }

        private void OnAddBook()
        {
            _books.Add(new Book { BookId = 42, Title = "A Cool new book", Publisher = "Self" });
        }



        public Book SelectedBook
        {
            get { return (Book)GetValue(SelectedBookProperty); }
            set { SetValue(SelectedBookProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedBook.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedBookProperty =
            DependencyProperty.Register("SelectedBook", typeof(Book), typeof(MainPage), new PropertyMetadata(null));



    }
}
