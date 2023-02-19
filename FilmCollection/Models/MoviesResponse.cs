using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmCollection.Models
{
    public class MoviesResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Year is required")]
        public Int32 Year { get; set; }
        [Required(ErrorMessage = "Director is required")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Rating is required")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [StringLength(25)]
        public string Notes { get; set; }

        //foreign key relationship
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
