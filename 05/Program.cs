using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class LibraryBook
    {
        public string Title { get; }
        public string Author { get; }
        public bool Available { get; private set; }

        public LibraryBook(string title, string author, bool available = true)
        {
            Title = title;
            Author = author;
            Available = available;
        }
        public void BorrowBook()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine($"Book '{Title}' by {Author} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"Book '{Title}' by {Author} is not available for borrowing.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LibraryBook book1 = new LibraryBook("The Great Gatsby", "F. Scott Fitzgerald");
            LibraryBook book2 = new LibraryBook("To Kill a Mockingbird", "Harper Lee");
            LibraryBook book3 = new LibraryBook("1984", "George Orwell");

            Console.WriteLine("Initial Library Status:");
            DisplayLibraryStatus(book1);
            DisplayLibraryStatus(book2);
            DisplayLibraryStatus(book3);

            Console.WriteLine("\nBorrowing Books:");
            book1.BorrowBook();
            book2.BorrowBook();
            book3.BorrowBook();

            Console.WriteLine("\nUpdated Library Status:");
            DisplayLibraryStatus(book1);
            DisplayLibraryStatus(book2);
            DisplayLibraryStatus(book3);

            Console.ReadKey();
        }

        static void DisplayLibraryStatus(LibraryBook book)
        {
            string availability = book.Available ? "Available" : "Not Available";
            Console.WriteLine($"Book: {book.Title} by {book.Author} - {availability}");
        }
    }
}