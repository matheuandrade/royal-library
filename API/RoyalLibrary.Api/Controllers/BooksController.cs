namespace RoyalLibrary.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using RoyalLibrary.Application.Services.Book;

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
    public IActionResult PostAsync()
    {
        // var loginResult = _authenticationService.Login(
        //     request.Email,
        //     request.Password);

        // var response = new AuthenticationResponse(loginResult.User.Id,
        //     loginResult.User.FirstName,
        //     loginResult.User.LastName,
        //     loginResult.User.Email,
        //     loginResult.Token);

        return Ok();
    }
}