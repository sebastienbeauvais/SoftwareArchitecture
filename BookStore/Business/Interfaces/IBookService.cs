using System.Collections.Generic;
using BookStore.DataAccess.Models;

namespace BookStore.Business.Interfaces
{
	public interface IBookService
	{
		IEnumerable<Book> GetAllBooks();
		void AddBook(Book book);
	}
}

