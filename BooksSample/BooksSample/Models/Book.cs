using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSample.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }

        public override string ToString() => Title;
    }
}
