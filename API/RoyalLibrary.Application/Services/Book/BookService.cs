using RoyalLibrary.Application.Common.Interfaces.Persistance;

namespace RoyalLibrary.Application.Services.Book;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<GetAllBooksResult> GetAllBooks()
    {
        await Task.CompletedTask;

        var books = await _bookRepository.GetAllBooks();

        return new GetAllBooksResult(books);
    }
}