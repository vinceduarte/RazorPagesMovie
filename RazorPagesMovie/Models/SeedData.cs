using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Spider-Man 2",
                        ReleaseDate = DateTime.Parse("2004-6-25"),
                        Genre = "Action",
                        Rating = "PG-13"
                    },

                    new Movie
                    {
                        Title = "Spider-Man: No Way Home",
                        ReleaseDate = DateTime.Parse("2021-12-17"),
                        Genre = "Action",
                        Rating = "PG-13"
                    },

                    new Movie
                    {
                        Title = "The Batman",
                        ReleaseDate = DateTime.Parse("2022-3-4"),
                        Genre = "Action",
                        Rating = "PG-13"
                    },

                    new Movie
                    {
                        Title = "Lone Survivor",
                        ReleaseDate = DateTime.Parse("2014-1-10"),
                        Genre = "Action",
                        Rating = "R"
                    }, 
                    
                    new Movie
                    {
                        Title = "Father Stu",
                        ReleaseDate = DateTime.Parse("2022-4-15"),
                        Genre = "Biography",
                        Rating = "R"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
