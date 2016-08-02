using BooksDataBindingSample.Services;
using BooksDataBindingSample.ViewModels;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BooksDataBindingSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
            this.ViewModel = new MainPageViewModel(new UWPMessageService());
        }

        public MainPageViewModel ViewModel { get; set; }
    }
}
