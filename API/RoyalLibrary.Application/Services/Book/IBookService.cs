namespace RoyalLibrary.Application.Services.Book;

public interface IBookService
{
    Task<GetAllBooksResult> GetAllBooks();
}