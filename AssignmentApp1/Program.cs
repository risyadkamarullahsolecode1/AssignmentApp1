// See https://aka.ms/new-console-template for more information
using AssignmentApp1;

Console.WriteLine("Hello, World!");
// Create Library object
Library Library = new Library();

// Tambah book ke library
Book book1 = new Book("To Kill a Mockingbird", "Harper Lee", 1960);
Book book2 = new Book("1984", "George Orwell", 1949);
Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925);

Library.AddBook(book1);
Library.AddBook(book2);
Library.AddBook(book3);

// Percobaan add book yang sudah ada (diharapkan muncul pesan buku sudah ada di library"
Library.AddBook(book2);

// Display books sebelum dihapus
Console.WriteLine("\nSebelum Dihapus :");
Library.DisplayBook();

// hapus book dari library
Library.RemoveBook("To Kill a Mockingbird");

// Display books sesudah dihapus
Console.WriteLine("\nSesudah Dihapus :");
Library.DisplayBook();