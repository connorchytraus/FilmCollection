using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmCollection.Models
{
    public class FilmCollectionContext : DbContext
    {
        //ccontstructor
        public FilmCollectionContext (DbContextOptions<FilmCollectionContext> options) : base (options)
        {
            
        }

        public DbSet<MoviesResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
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
                    CategoryId = 2,
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
                    CategoryId = 3,
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
