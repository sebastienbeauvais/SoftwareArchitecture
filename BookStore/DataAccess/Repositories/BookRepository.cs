using System;
using BookStore.DataAccess.Interfaces;
namespace BookStore.DataAccess.Models
{
	public class BookRepository : IBookRepository
	{
        private static List<Book> _books = new List<Book>();

        public IEnumerable<Book> GetAllBooks()
		{
			return _books;
		}
		public void AddBook(Book book)
		{
			book.Id = _books.Any() ? _books.Max(x => x.Id) + 1 : 1;
			_books.Add(book);
		}
	}
}

