using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RoyalLibrary.Application.Common.Interfaces.Persistance;
using RoyalLibrary.Infrastructure.Persistance;
using RoyalLibrary.Infrastructure.Persistance.Repositories;

namespace RoyalLibrary.Infrastructure;

public static class DependencyInjection 
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services)
    {

        services.AddDbContext<ApplicationContext>(options => {
            options.UseSqlServer("Data Source=localhost;Initial Catalog=RoyalLibrary;Persist Security Info=True;TrustServerCertificate=True;User ID=sa;Password=password123!");
        }, ServiceLifetime.Transient);

       services.AddScoped<IBookRepository, BookRepository>(); 

       return services;
    }
}