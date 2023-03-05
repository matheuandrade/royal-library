using MediatR;
using RoyalLibrary.Application.Services.Book;

namespace RoyalLibrary.Application.Books.Queries.GetAll;

public record GetAllQuery(

) : IRequest<GetAllBooksResult>;