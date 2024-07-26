using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentApp1
{
    public class Library
    {
        public List<Book> BookCollection;

        public Library() 
        { 
            BookCollection = new List<Book>();
        }

        //Method AddBook
        public void AddBook(Book book)
        {
            if (BookCollection.Exists(b => b.Title == book.Title))
            {
                Console.WriteLine($"Book berjudul '{book.Title}' sudah ada di library.");
            }
            else
            {
                BookCollection.Add(book);
                Console.WriteLine($"Buku berjudul '{book.Title}' ditambahkan library.");
            }
        }
        // Method RemoveBook
        public void RemoveBook(string title)
        {
            Book bookToRemove = BookCollection.Find(book=>book.Title == title);
            if (bookToRemove != null)
            {
                BookCollection.Remove(bookToRemove);
                Console.WriteLine($"\nBuku berjudul '{title}' dihapus dari library.");
            }
            else
            {
                Console.WriteLine($"Buku berjudul '{title}' tidak ada di library.");
            }
        }
        // Method DisplayBook
        public void DisplayBook()
        {
            if (BookCollection.Count > 0)
            {
                Console.WriteLine("Buku yang ada dalam Library: ");
                foreach (Book book in BookCollection)
                {
                    Console.WriteLine(book);
                }
            }
            else
            {
                Console.WriteLine("Tidak ada buku di dalam Library");
            }
        }
    }
}
