using System.Collections.Generic;
using BookStore.Business.Interfaces;
using BookStore.DataAccess.Interfaces;
using BookStore.DataAccess.Models;

namespace BookStore.Presentation
{
	public class BookService : IBookService
	{
		private readonly IBookRepository _bookRepository;

		public BookService(IBookRepository bookRepository)
		{
			_bookRepository = bookRepository;
		}

		public IEnumerable<Book> GetAllBooks()
		{
			return _bookRepository.GetAllBooks();
		}

		public void AddBook(Book book)
		{
			_bookRepository.AddBook(book);
		}
	}
}

