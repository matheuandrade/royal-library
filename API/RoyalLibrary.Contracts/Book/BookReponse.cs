namespace RoyalLibrary.Contracts.Book;

public record BookResponse(
    Guid Id,
    string Title,
    string FirstName,
    string LastName,
    int TotalCopies,
    int CopiesInUse,
    string Type,
    string Isbn,
    string Category
);