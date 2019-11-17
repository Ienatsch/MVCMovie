using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class SeedData
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
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2015-2-26"),
                        Genre = "Documentary",
                        Price = 6.99M,
                        Rating = "PG",
                        IMDB_ID = "tt4003774"
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-6-03"),
                        Genre = "History",
                        Price = 5.99M,
                        Rating = "PG",
                        IMDB_ID = "tt1909270"
                    },

                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2004-2-20"),
                        Genre = "Comedy",
                        Price = 2.99M,
                        Rating = "PG",
                        IMDB_ID = "tt0377038"
                    },

                    new Movie
                    {
                        Title = "The Saratov Approach",
                        ReleaseDate = DateTime.Parse("2013-10-09"),
                        Genre = "Drama",
                        Price = 9.99M,
                        Rating = "PG-13",
                        IMDB_ID = "tt2887322"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
