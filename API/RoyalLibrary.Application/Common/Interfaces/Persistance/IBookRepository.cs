using System.Linq.Expressions;
using RoyalLibrary.Domain.Entities;

namespace RoyalLibrary.Application.Common.Interfaces.Persistance;

public interface IBookRepository
{
    public Task<IEnumerable<Book>> GetWhere(Expression<Func<Book, bool>> predicate);
    public Task<IEnumerable<Book>> GetAllBooks();
}