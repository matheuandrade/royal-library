

using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using RoyalLibrary.Application.Common.Interfaces.Persistance;
using RoyalLibrary.Domain.Entities;

namespace RoyalLibrary.Infrastructure.Persistance.Repositories;

public class BookRepository : IBookRepository
{
    protected readonly ApplicationContext _context;

    public BookRepository(ApplicationContext context)
    {
        _context = context;
    }

    async Task<IEnumerable<Book>> IBookRepository.GetAllBooks()
    {
        return await _context.Set<Book>().ToListAsync();
    }

    public async Task<IEnumerable<Book>> GetWhere(Expression<Func<Book, bool>> predicate)
    {
        return await _context.Set<Book>().Where(predicate).ToListAsync();
    }
}