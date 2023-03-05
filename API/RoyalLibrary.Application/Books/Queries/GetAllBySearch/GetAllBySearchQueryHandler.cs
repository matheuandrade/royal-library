using MediatR;
using RoyalLibrary.Application.Common.Interfaces.Persistance;
using RoyalLibrary.Application.Services.Book;

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
        var books = await _bookRepository.GetAllBooks();

        return new GetAllBooksResult(books);
    }
}