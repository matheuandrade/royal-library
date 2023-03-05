using Microsoft.EntityFrameworkCore;
using RoyalLibrary.Domain.Entities;

namespace RoyalLibrary.Infrastructure.Persistance;


public class ApplicationContext : DbContext
{
    public ApplicationContext(){}

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}