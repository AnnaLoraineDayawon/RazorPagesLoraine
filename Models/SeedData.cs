using Microsoft.EntityFrameworkCore;
using RazorPagesLoraine.Data;
namespace RazorPagesLoraine.Models
{
    public static class SeedData
    {
        public static void Intialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesLoraineContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesLoraineContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazorPagesLoraineContext");
                }
                if(context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry met Barney",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "RomCom",
                        Price = 7.99m,
                    },
                    new Movie
                    {
                        Title = "Ghoster",
                        ReleaseDate = DateTime.Parse("1984-2-12"),
                        Genre = "Comedy",
                        Price = 8.99m,
                    },
                    new Movie
                    {
                        Title = "Ghoster 2",
                        ReleaseDate = DateTime.Parse("1984-2-12"),
                        Genre = "Comedy",
                        Price = 9.99m,
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
