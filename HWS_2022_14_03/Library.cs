using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_2022_14_03
{
    public static class Library
    {
        //Static Fields
        public static Dictionary<string, Book> books = new();
        //Static Methods
        public static bool HaveThisBook(string title)
        {
            if (!books.ContainsKey(title))
            {
                return false;
            }
            return true;
        }
        public static bool AddBook(Book book)
        {
            if (book == null || HaveThisBook(book.Title))
            {
                return false;
            }
            Console.WriteLine($"added book - {book.Title}, written by - {book.Author}");
            books.Add(book.Title, book);
            return true;
        }
        public static bool RemoveBook(string title)
        {
            if (!HaveThisBook(title))
            {
                return false;
            }
            Console.WriteLine($"removed book - {title}");
            books.Remove(title);
            return true;
        }
        public static void Clear()
        {
            books.Clear();
            Console.WriteLine("All books cleared from library");
        }
        public static void GetAllBooks()
        {
            if (Count() == 0)
            {
                Console.WriteLine("Library is empty");
                return;
            }
            Console.WriteLine($"{Count()} books:\n");
            foreach (Book book in books.Values)
            {
                Console.WriteLine(book);
            }
        }
        public static void BrowseByCategory(CategoryTypes category)
        {
            foreach (Book book in books.Values)
            {
                if (book.Category == category)
                {
                    Console.WriteLine(book);
                }
            }
        }
        public static Book? GetBook(string title)
        {
            if (!HaveThisBook(title))
            {
                return null;
            }
            return books[title];
        }
        public static void ReadBook(Book book)
        {
            if (HaveThisBook(book.Title))
            {
                Console.WriteLine($"{books[book.Title].Content}");
            }
            return;
        }
        public static Book? GetBookByAuthor(string author)
        {
            if (GetAuthors().Contains(author))
            {
                foreach (Book book in books.Values)
                {
                    if (book.Author == author)
                    {
                        return book;
                    }
                }
            }
            return null;
        }
        public static List<string> GetAuthors()
        {
            List<string> authors = new();
            foreach (Book book in books.Values)
            {
                authors.Add(book.Author);
            }
            return authors;
        }
        public static SortedList<string, Book> GetBooksSortedByAuthor()
        {
            SortedList<string, Book> sortedList = new();
            foreach (Book book in books.Values)
            {
                sortedList.Add(book.Author, book);
            }
            return sortedList;
        }
        public static SortedList<string, Book> GetBooksSortedByTitle()
        {
            SortedList<string, Book> sortedList = new();
            foreach (Book book in books.Values)
            {
                sortedList.Add(book.Title, book);
            }
            return sortedList;
        }
        public static int Count()
        {
            return books.Count;
        }
    }
}
