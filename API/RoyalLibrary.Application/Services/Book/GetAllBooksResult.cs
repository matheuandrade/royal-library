namespace RoyalLibrary.Application.Services.Book;

public record GetAllBooksResult(
    IEnumerable<Domain.Entities.Book> Books
);