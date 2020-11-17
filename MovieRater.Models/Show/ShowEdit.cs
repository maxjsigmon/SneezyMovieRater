using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models.Show
{
   public class ShowEdit
    {
        public int ContentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MaturityRating { get; set; }
        public int SeasonCount { get; set; }
    }
}
