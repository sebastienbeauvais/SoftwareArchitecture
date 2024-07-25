using System;
using BookStore.Business.Interfaces;
using BookStore.Business;
using BookStore.DataAccess.Repositories;
using BookStore.DataAccess.Models;

namespace BookStore.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            IBookService bookService = new BookService(new BookRepository());

            Console.WriteLine("Welcome to the Book Store!");
            Console.WriteLine("1. Display all books");
            Console.WriteLine("2. Add a new book");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    var books = bookService.GetAllBooks();
                    foreach (var book in books)
                    {
                        Console.WriteLine($"{book.Id}. {book.Title} by {book.Author}");
                    }
                    break;
                case "2":
                    Console.Write("Enter book title: ");
                    var title = Console.ReadLine();
                    Console.Write("Enter book author: ");
                    var author = Console.ReadLine();
                    bookService.AddBook(new Book { Title = title, Author = author });
                    Console.WriteLine("Book added successfully.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}