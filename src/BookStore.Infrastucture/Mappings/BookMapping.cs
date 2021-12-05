using BookStore.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Infrastucture.Mappings
{
    public class BookMapping : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(true);

            builder.Property(b => b.Author)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(true);

            builder.Property(b => b.Description)
                .IsRequired(false)
                .HasMaxLength(150)
                .IsUnicode(true);

            builder.Property(b => b.Value)
                .IsRequired();

            builder.Property(b => b.PublishDate)
                .IsRequired();

            builder.Property(b => b.CategoryId)
                .IsRequired();


            builder.ToTable("Books");




        }
    }
}
