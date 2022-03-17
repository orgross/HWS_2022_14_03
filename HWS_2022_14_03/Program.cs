using System;

namespace HWS_2022_14_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = Book.books;
            
            // Adding books to the library
            Console.WriteLine("\n/////////////// Adding books to the library:\n");

            Book book1 = new("Lorem Ipsum", "Blokeria", CategoryTypes.Action);
            Book book2 = new("The Dragon Shards", "Mighty Mate", CategoryTypes.Drama);
            Book book3 = new("The Doors Of Perception", "Aldous Huxley", CategoryTypes.Philsophy);


            foreach (Book book in books)
            {
                Library.AddBook(book);
            }

            // Books in library(unsorted)
            Console.WriteLine("\n/////////////// Books in library(unsorted):\n");

            Library.GetAllBooks();

            // Browse books by category - Philsophy
            Console.WriteLine("\n/////////////// Browse books by category - Philsophy:\n");

            Library.BrowseByCategory(CategoryTypes.Philsophy);

            // Books sorted by author
            Console.WriteLine("\n/////////////// Books sorted by author:\n");

            PrintBookList(Library.GetBooksSortedByAuthor().Values.ToArray());

            // Books sorted by title
            Console.WriteLine("\n/////////////// Books sorted by title:\n");

            PrintBookList(Library.GetBooksSortedByTitle().Values.ToArray());

            // Read Books
            Console.WriteLine("\n/////////////// Read Books:\n");

            Console.WriteLine(book1);
            Library.ReadBook(book1);

            Console.WriteLine();

            Book? book4 = Library.GetBook("The Dragon Shards");
            Console.WriteLine(book4);
            Library.ReadBook(book4);

            Console.WriteLine();

            Book? book5 = Library.GetBookByAuthor("Aldous Huxley");
            Console.WriteLine(book5);
            Library.ReadBook(book5);

            // Remove Books
            Console.WriteLine("\n/////////////// Remove Books:\n");

            Library.RemoveBook(book2.Title);
            Library.RemoveBook(book3.Title);

            // Books in library(unsorted)
            Console.WriteLine("\n/////////////// Books in library(unsorted):\n");

            Library.GetAllBooks();

            // Clear books in library
            Console.WriteLine("\n/////////////// Clear books in library:\n");

            Library.Clear();
            Library.GetAllBooks();

            // Method for printing a bookslist 
            static void PrintBookList(params Book[] books)
            {
                foreach (Book book in books)
                {
                    Console.WriteLine(book);
                }
            }
        }
    }
}
