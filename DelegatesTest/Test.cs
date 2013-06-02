using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookTestClient;

namespace BookStore
{
    class Test
    {   

        static void PrintTitle(Book b)
        {
            Console.WriteLine(" {0} " + b.Title);
        }

        static void Main(string[] a)
        {
            BookDB bookDB = new BookDB();

            AddBooks(bookDB);

            Console.WriteLine("Paperback Book Titles: ");

            bookDB.ProcessPaperBackBooks(new ProcessBookDelegate(PrintTitle));

            priceTotaller priceTotaller = new priceTotaller();

            bookDB.ProcessPaperBackBooks(new ProcessBookDelegate(priceTotaller.AddBookToTotal));

            Console.WriteLine("Average Paperback Book Price: ${0:#.##}",
             priceTotaller.AveragePrice());
        }

        // Initialize the book database with some test books:
        static void AddBooks(BookDB bookDB)
        {
            bookDB.AddBook("The C Programming Language",
               "Brian W. Kernighan and Dennis M. Ritchie", 19.95m, true);
            bookDB.AddBook("The Unicode Standard 2.0",
               "The Unicode Consortium", 39.95m, true);
            bookDB.AddBook("The MS-DOS Encyclopedia",
               "Ray Duncan", 129.95m, false);
            bookDB.AddBook("Dogbert's Clues for the Clueless",
               "Scott Adams", 12.00m, true);
        }
    }
}
