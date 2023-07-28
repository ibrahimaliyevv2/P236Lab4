using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasker
{
    internal class Library
    {
        public Book[] books;
        public int count;

        public Library(int capacity)
        {
            books = new Book[capacity];
            count = 0;
        }

        public void AddBook(string title, string author, int year)
        {
            if (count < books.Length)
            {
                Book newBook = new Book(title, author, year);
                books[count] = newBook;
                count++;
            }
            else
            {
                Console.WriteLine("Kitabxana doludur. Daha cox kitab elave edile bilmez.");
            }
        }
    }
}
