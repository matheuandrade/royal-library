using Microsoft.Extensions.DependencyInjection;
using RoyalLibrary.Application.Common.Interfaces.Persistance;
using RoyalLibrary.Infrastructure.Persistance;

namespace RoyalLibrary.Infrastructure;

public static class DependencyInjection 
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services)
    {

       services.AddScoped<IBookRepository, BookRepository>(); 

       return services;
    }
}