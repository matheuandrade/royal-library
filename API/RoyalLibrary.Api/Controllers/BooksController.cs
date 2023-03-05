namespace RoyalLibrary.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using RoyalLibrary.Application.Services.Book;
using RoyalLibrary.Contracts.Book;

[ApiController]
[Route("books")]
public class BooksController : ControllerBase 
{
    private readonly IBookService _bookService;

    public BooksController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        var response = await _bookService.GetAllBooks();

        return Ok(response.Books);
    }

    [HttpPost]
    public IActionResult PostAsync(BookRequest request)
    {
        return Ok();
    }
}