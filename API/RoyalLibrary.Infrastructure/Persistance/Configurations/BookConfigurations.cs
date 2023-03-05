using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoyalLibrary.Domain.Entities;

namespace RoyalLibrary.Infrastructure.Persistance.Configurations;

public class BookConfigurations : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        ConfigureBooksTable(builder);
    }

    private static void ConfigureBooksTable(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("Books");

        builder.HasKey(m => m.Id);

        builder.Property(m => m.Title)
                .HasMaxLength(100);

         builder.Property(m => m.FirstName)
                .HasColumnName("first_name")
                .HasMaxLength(50);

         builder.Property(m => m.LastName)
                .HasColumnName("last_name")
                .HasMaxLength(50);

        builder.Property(m => m.TotalCopies)
                .HasColumnName("total_copies");

        builder.Property(m => m.CopiesInUse)
                .HasColumnName("copies_in_use");

        builder.Property(m => m.Type)
                .HasMaxLength(50);

        builder.Property(m => m.Isbn)
                .HasMaxLength(80);

        builder.Property(m => m.Category)
                .HasMaxLength(50);
    }
}