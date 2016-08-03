using BooksDataBindingSample.Services;
using BooksDataBindingSample.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.Extensions.DependencyInjection;

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
            this.ViewModel = (Application.Current as App).Container.GetService<MainPageViewModel>();
        }

        public MainPageViewModel ViewModel { get; set; }
    }
}
