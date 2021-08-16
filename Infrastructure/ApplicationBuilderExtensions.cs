namespace BookMarket.Infrastructure
{
    using System.Linq;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    using BookMarket.Data;
    using BookMarket.Data.Models;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(
            this IApplicationBuilder app)
        {
            using var scopedService = app.ApplicationServices.CreateScope();

            var data = scopedService.ServiceProvider.GetService<BookMarketDbContext>();

            data.Database.Migrate();

            SeedGenres(data);

            return app;
        }

        private static void SeedGenres(BookMarketDbContext data)
        {
            if (!data.Genres.Any())
            {
                return;
            }

            data.Genres.AddRange(new[]
            {
                new Genre{Name = "Mistery"},
                new Genre{Name = "Horror"},
                new Genre{Name = "Thriller"},
                new Genre{Name = "Fantasy"},
                new Genre{Name = "Romance"},
                new Genre{Name = "Biography"},
                new Genre{Name = "History"},
                new Genre{Name = "Children’s"},
                new Genre{Name = "Science & Technology’s"},
                new Genre{Name = "Action & Adventure"},
                new Genre{Name = "Graphic Novel"},
            });

            data.SaveChanges();
        }
    }
}
