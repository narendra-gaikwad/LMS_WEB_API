using LMS_WEB_API.Models;
using Microsoft.EntityFrameworkCore;

namespace LMS_WEB_API.Data 
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(b => b.TotalCopies)
                .HasDefaultValue(0);

            modelBuilder.Entity<Book>()
                .Property(b => b.IssuedCopies)
                .HasDefaultValue(0);
        }
    }
}
