using BooksSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace BooksDataBindingSample
{
    public class BookTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultBookTemplate { get; set; }
        public DataTemplate WroxBookTemplate { get; set; }

        private DataTemplate _selectedTemplate;

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            Book b = item as Book;
            if (b == null) return _selectedTemplate;

            switch (b.Publisher)
            {
                case "Wrox Press":
                    _selectedTemplate = WroxBookTemplate;
                    break;
                default:
                    _selectedTemplate = DefaultBookTemplate;
                    break;
            }

            return _selectedTemplate;
        }
    }
}
