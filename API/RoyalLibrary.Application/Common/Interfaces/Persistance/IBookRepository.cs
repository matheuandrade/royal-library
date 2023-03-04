using RoyalLibrary.Domain.Entities;

namespace RoyalLibrary.Application.Common.Interfaces.Persistance;

public interface IBookRepository
{
    public Task<IReadOnlyCollection<Book>> GetAllBooks();
}