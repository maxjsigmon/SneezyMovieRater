using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models.Show
{
   public class ShowCreate
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Too many characters.")]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000, ErrorMessage = "Keep descirption to fewer than 1000 characters.")]
        public string Description { get; set; }
        
        [Required]
        public string MaturityRating { get; set; }

        [Required]
        public int SeasonCount { get; set; }
    }
}
