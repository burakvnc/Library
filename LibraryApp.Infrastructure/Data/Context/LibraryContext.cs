using Microsoft.EntityFrameworkCore;
using LibraryApp.Infrastructure.Configurations;
using LibraryApp.Shared.Models;

namespace LibraryApp.Infrastructure.Data.Context
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Library> Libraries { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<LibraryBook> LibraryBooks { get; set; }
        public DbSet<LibraryAuthor> LibraryAuthors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BookAuthorConfiguration());
            modelBuilder.ApplyConfiguration(new LibraryBookConfiguration());
            modelBuilder.ApplyConfiguration(new LibraryAuthorConfiguration());
        }
    }
}
