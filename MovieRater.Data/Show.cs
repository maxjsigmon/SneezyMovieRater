using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Data
{
    public class Show : Content
    {
        public int SeasonCount { get; set; }

        public Guid AuthorId { get; set; }
    }
}
