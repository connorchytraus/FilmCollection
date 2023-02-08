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
    }
}
