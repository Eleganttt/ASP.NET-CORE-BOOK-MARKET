namespace BookMarket.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using BookMarket.Data.Models;
    public class BookMarketDbContext : IdentityDbContext
    {
        public BookMarketDbContext(DbContextOptions<BookMarketDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; init; }

        public DbSet<Author> Authors { get; init; }

        public DbSet<Genre> Genres { get; init; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Book>()
                .HasOne(g => g.Genre)
                .WithMany(g => g.Books)
                .HasForeignKey(g => g.GenreId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Book>()
                .HasOne(a => a.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(a => a.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);



            base.OnModelCreating(builder);
        }
    }
}
