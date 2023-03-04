namespace RoyalLibrary.Application.Services.Book;

public record GetAllBooksResult(
    IReadOnlyCollection<Domain.Entities.Book> Books
);