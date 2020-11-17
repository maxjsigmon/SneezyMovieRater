using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models
{
    public class RatingCreate
    {
        //[Required]
        //public int ContentId { get; set; }

        [Required]
        public double Rate { get; set; }

        [Required]
        public string ReviewDescription { get; set; }
    }
}
