using System;

namespace tasker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library1 = new Library(5);

            library1.AddBook("Danabas kendinin ehvalatlari", "Celil Memmedquluzade", 1960);
            library1.AddBook("Ferrarisini satan rahib", "Robin Sharm", 2006);
            library1.AddBook("Yalnizliqdan sizofreniyaya", "OAR", 1999);
            library1.AddBook("Xeyanet", "Elxan Elatli", 2008);
            library1.AddBook("Menim sirin portagal agacim", "Joseph Maurino", 2013);
            library1.AddBook("Antichrist", "Nitsche", 1895);

            Console.WriteLine("Menim lib1 kitablarim:");
            Console.WriteLine("                                    ");


            foreach (Book book in library1.books)
            {
                Console.WriteLine($"{book.Title} by {book.Author} in ({book.Year})");
            }

            Console.WriteLine("                                    ");

            Console.WriteLine("Birinci bu qeder idi.");

            Library library2 = new Library(2);

            Console.WriteLine("                                    ");

            library2.AddBook("Cinayet ve ceza", "Fyodor Dostoyevski", 1970);
            library2.AddBook("Qurur ve qerez", "Ceyms Ostin", 2023);

            Console.WriteLine("Menim lib2 kitablarim:");

            foreach (Book book in library2.books)
            {
                Console.WriteLine($"{book.Title} by {book.Author} in ({book.Year})");
            }

        }
    }
}
