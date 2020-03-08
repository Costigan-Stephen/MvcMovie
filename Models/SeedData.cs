using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-6-3"),
                        Genre = "Adventure",
                        Rating = "PG-13",
                        Price = 7.99M,
                        Image = "miracles.jpg"
                    },

                    new Movie
                    {
                        Title = "Joseph Smith: The Prophet of the Restoration",
                        ReleaseDate = DateTime.Parse("2005-12-24"),
                        Genre = "Drama",
                        Rating = "NR",
                        Price = 8.99M,
                        Image = "smith.jpg"
                    },

                    new Movie
                    {
                        Title = "Charly",
                        ReleaseDate = DateTime.Parse("2002-9-20"),
                        Genre = "Drama",
                        Rating = "PG-13",
                        Price = 9.99M,
                        Image = "charly.jpg"
                    },

                    new Movie
                    {
                        Title = "The other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2002-4-12"),
                        Genre = "Adventure",
                        Rating = "PG-13",
                        Price = 9.99M,
                        Image = "heaven.jpg"
                    },

                    new Movie
                    {
                        Title = "Saints and Soldiers",
                        ReleaseDate = DateTime.Parse("2005-3-25"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 7.99M,
                        Image = "soldiers.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
