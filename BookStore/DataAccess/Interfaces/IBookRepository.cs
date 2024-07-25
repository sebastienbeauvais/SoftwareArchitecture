using System.Collections.Generic;
using BookStore.DataAccess.Models;

namespace BookStore.DataAccess.Interfaces
{
	public interface IBookRepository
	{
		IEnumerable<Book> GetAllBooks();
		void AddBook(Book book);
	}
}

