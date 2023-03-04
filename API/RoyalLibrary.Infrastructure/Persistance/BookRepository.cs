

using RoyalLibrary.Application.Common.Interfaces.Persistance;
using RoyalLibrary.Domain.Entities;

namespace RoyalLibrary.Infrastructure.Persistance;

public class BookRepository : IBookRepository
{
    private static readonly List<Book> _books = new();

    async Task<IReadOnlyCollection<Book>> IBookRepository.GetAllBooks()
    {
        await Task.CompletedTask;

        return _books;
    }
}