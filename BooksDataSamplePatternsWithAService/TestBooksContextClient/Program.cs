using BooksModelLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBooksContextClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateBooks();
        }

        private static void CreateBooks()
        {
            using (var context = new BooksContext())
            {
                bool created = context.Database.EnsureCreated();
                Console.WriteLine($"{created} database");
                context.Books.Add(new Book { Title = "Professional C# 6", Publisher = "Wrox Press" });
                int records = context.SaveChanges();
                Console.WriteLine($"{records} changed");
            }
        }
    }
}
