using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections;

namespace BookStore
{
    public struct Book
    {
        public string Title;
        public string Author;
        public decimal Price;
        public bool PapaerBack;

        public Book(string title, string author, decimal price, bool paperBack)
        {
            Title = title;
            Author = author;
            Price = price;
            PapaerBack = paperBack;
        }
    }

    public delegate void ProcessBookDelegate( Book book );

    public class BookDB
    {
        ArrayList list = new ArrayList();

        public void AddBook(string title, string author, decimal price, bool paperBack)
        {
            list.Add(new Book(title, author, price, paperBack));
        }

        public void ProcessPaperBackBooks(ProcessBookDelegate bookDelegate)
        {
            foreach (Book item in list)
            {
                if (item.PapaerBack)
                {
                    bookDelegate(item);
                }
            }
        }
    }
}
