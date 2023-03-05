using MediatR;
using RoyalLibrary.Application.Common.Interfaces.Persistance;
using RoyalLibrary.Application.Services.Book;

namespace RoyalLibrary.Application.Books.Queries.GetAll;

public class GetAllQueryHandler : IRequestHandler<GetAllQuery, GetAllBooksResult>
{
    private readonly IBookRepository _bookRepository;

    public GetAllQueryHandler(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<GetAllBooksResult> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        var books = await _bookRepository.GetAllBooks();

        return new GetAllBooksResult(books);
    }
}