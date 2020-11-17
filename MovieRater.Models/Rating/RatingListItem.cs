using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models.Rating
{
    public class RatingListItem
    {
        public int RatingId { get; set; }

        public double Rate { get; set; }

        public string ReviewDescription { get; set; }
    }
}
