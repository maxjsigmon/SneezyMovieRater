using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Data
{
    public class Rating
    {
        [Key]
        public int RatingId { get; set; }

        [Required]
        public Guid AuthorId { get; set; }

        [Required]
        public double Rate { get; set; }

        [Required]
        public string ReviewDescription { get; set; }

    }
}
