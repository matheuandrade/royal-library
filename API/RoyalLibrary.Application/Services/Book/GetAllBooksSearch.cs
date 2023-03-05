namespace RoyalLibrary.Application.Services.Book;

public record GetAllBooksSearch(
    string SearchValue,
    BookType SearchBy
);

public enum BookType 
{
    Title,
    Author,
    Type,
    ISBN,
    Category,
}