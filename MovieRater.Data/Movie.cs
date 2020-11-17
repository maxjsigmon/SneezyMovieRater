using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Data
{
    public class Movie : Content
    {
        [Required]
        public double RunTime { get; set; }
        [Required]
        public Guid AuthorId { get; set; }
    }
}
