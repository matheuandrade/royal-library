using System.Linq.Expressions;
using MediatR;
using RoyalLibrary.Application.Common.Interfaces.Persistance;
using RoyalLibrary.Application.Services.Book;
using RoyalLibrary.Domain.Entities;

namespace RoyalLibrary.Application.Books.Queries.GetAllBySearch;

public class GetAllBySearchQueryHandler : IRequestHandler<GetAllBySearchQuery, GetAllBooksResult>
{
    private readonly IBookRepository _bookRepository;

    public GetAllBySearchQueryHandler(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<GetAllBooksResult> Handle(GetAllBySearchQuery request, CancellationToken cancellationToken)
    {
        Expression<Func<Book, bool>> predicate = x => true;
        
        switch (request.SearchBy)
        {
            case nameof(BookType.Author):
                predicate = x => x.FirstName.ToUpper().Contains(request.SearchValue.ToUpper())
                || x.LastName.ToUpper().Contains(request.SearchValue.ToUpper());
                break;

            case nameof(BookType.Category):
                predicate = x => x.Category.ToUpper().Contains(request.SearchValue.ToUpper());
                break;

            case nameof(BookType.ISBN):
                predicate = x => x.Isbn.ToUpper().Contains(request.SearchValue.ToUpper());
                break;

            case nameof(BookType.Title):
                predicate = x => x.Title.ToUpper().Contains(request.SearchValue.ToUpper());
                break;

            case nameof(BookType.Type):
                predicate = x => x.Type.ToUpper().Contains(request.SearchValue.ToUpper());
                break;
            default:
                break;
        }

        var books = await _bookRepository.GetWhere(predicate);

        return new GetAllBooksResult(books);
    }
}