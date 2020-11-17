using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models.Movie
{
   public  class MovieListItem
    {
        public int ContentId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string MaturityRating { get; set; }
        public double RunTime { get; set; }


    }
}
