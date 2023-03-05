namespace RoyalLibrary.Contracts.Book;

public class BookRequest
{
    public string SearchValue { get; set; }
    public BookType SearchBy { get; set; }
}

public enum BookType 
{
    Title,
    Author,
    Type,
    ISBN,
    Category,
}