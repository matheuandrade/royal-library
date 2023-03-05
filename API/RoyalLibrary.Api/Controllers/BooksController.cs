namespace RoyalLibrary.Api.Controllers;

using MediatR;
using Microsoft.AspNetCore.Mvc;
using RoyalLibrary.Application.Books.Queries.GetAll;
using RoyalLibrary.Application.Books.Queries.GetAllBySearch;

[ApiController]
[Route("books")]
public class BooksController : ControllerBase 
{
    private readonly ISender _mediator;

    public BooksController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllBooksAsync()
    {
        var command = new GetAllQuery();

        var response = await _mediator.Send(command);

        return Ok(response.Books);
    }

    [HttpGet("{searchValue}")]
    public async Task<IActionResult> GetAllBooksBySearchAsync([FromQuery] string searchValue, string searchType)
    {
        var command = new GetAllBySearchQuery(searchValue, searchType);

        var response = await _mediator.Send(command);

        return Ok(response.Books);
    }
}