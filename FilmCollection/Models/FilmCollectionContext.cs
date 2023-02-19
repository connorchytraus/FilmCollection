using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmCollection.Models
{
    public class FilmCollectionContext : DbContext
    {
        //contstructor
        public FilmCollectionContext (DbContextOptions<FilmCollectionContext> options) : base (options)
        {
            
        }

        public DbSet<MoviesResponse> responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName= "Sci-Fi"},
                new Category { CategoryId = 2, CategoryName = "Action" },
                new Category { CategoryId = 3, CategoryName = "Adventure" },
                new Category { CategoryId = 4, CategoryName = "Thriller" },
                new Category { CategoryId = 5, CategoryName = "Romance" },
                new Category { CategoryId = 6, CategoryName = "Western" },
                new Category { CategoryId = 7, CategoryName = "Horror" },
                new Category { CategoryId = 8, CategoryName = "Unknown" }
           );



            mb.Entity<MoviesResponse>().HasData(

                new MoviesResponse
                {
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "Interstellar",
                    Year = 2014,
                    Rating = "PG-13",
                    Director = "Christopher Nolan",
                    Edited = false,
                    LentTo = "Connor",
                    Notes = "good movie",
                },
                new MoviesResponse
                {
                    MovieId = 2,
                    CategoryId = 3,
                    Title = "Puss 'n Boots",
                    Year = 2022,
                    Rating = "PG",
                    Director = "Chris Miller",
                    Edited = true,
                    LentTo = "Hannah",
                    Notes = "great movie",
                },
                new MoviesResponse
                {
                    MovieId = 3,
                    CategoryId = 2,
                    Title = "Top Gun: Maverick",
                    Year = 2022,
                    Rating = "PG-13",
                    Director = "Joseph Kosinski",
                    Edited = false,
                    LentTo = "Cooper",
                    Notes = "fav",
                }
                );
        }
    }
}
