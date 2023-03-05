using System.Linq.Expressions;
using RoyalLibrary.Domain.Entities;

namespace RoyalLibrary.Application.Common.Interfaces.Persistance;

public interface IBookRepository
{
    Task<IEnumerable<Book>> GetWhere(Expression<Func<Book, bool>> predicate);
    public Task<IEnumerable<Book>> GetAllBooks();
}