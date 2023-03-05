using MediatR;
using RoyalLibrary.Application.Services.Book;

namespace RoyalLibrary.Application.Books.Queries.GetAllBySearch;

public record GetAllBySearchQuery(
    string SearchValue,
    string SearchBy 
) : IRequest<GetAllBooksResult>;