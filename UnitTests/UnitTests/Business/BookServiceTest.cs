using NUnit;
using BookStore.Presentation;
using BookStore.DataAccess.Interfaces;
using BookStore.DataAccess.Models;
using Moq;

namespace UnitTests.Business
{
    [TestFixture]
    public class BookServiceTest
    {
        private Mock<IBookRepository> _mockBookRepository;
        private BookService _bookService;

        [SetUp]
        public void SetUp()
        {
            _mockBookRepository = new Mock<IBookRepository>();
            _bookService = new BookService(_mockBookRepository.Object);
        }

        [Test]
        public void GetAllBooks_ReturnsAllBooks()
        {
            var books = new List<Book>
            {
                new Book { Id = 1, Title = "Moby Dick", Author = "Herman Melville"},
                new Book { Id = 2, Title = "Harry Potter and The Sorcerers Stone", Author = "J.K. Rowling"}
            };
            _mockBookRepository.Setup(x => x.GetAllBooks()).Returns(books);

            var result = _bookService.GetAllBooks();

            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("Moby Dick", result.First().Title);
            Assert.AreEqual("Harry Potter and The Sorcerers Stone", result.Last().Title);
        }
        [Test]
        public void AddBook_CallsRepositoryAddBook()
        {
            var newBook = new Book { Title = "Dune", Author = "Frank Herbert" };

            _bookService.AddBook(newBook);

            _mockBookRepository.Verify(x => x.AddBook(newBook), Times.Once);
        }
    }
}
