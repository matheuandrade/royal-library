using Microsoft.Extensions.DependencyInjection;
using RoyalLibrary.Application.Services.Book;

namespace RoyalLibrary.Application;

public static class DependencyInjection 
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IBookService, BookService>();
        
       return services;
    }
}