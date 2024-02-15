using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Book
    {       
        public string Title { get; set; }
        public string Author { get; set; }
        
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {          
            Book myBook = new Book("The Physchology of money", "Morgan Housel");

            Console.WriteLine("Book Title: " + myBook.Title);
            Console.WriteLine("Author: " + myBook.Author);

            Console.ReadKey();
        }
    }
}
