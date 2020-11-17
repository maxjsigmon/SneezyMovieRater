using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models.Movie
{
    public class MovieCreate
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string MaturityRating { get; set; }

        [Required]
        public double RunTime { get; set; }
    }
}
