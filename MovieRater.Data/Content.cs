using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Data
{
    public class Content
    {
        [Key]
        public int ContentId { get; set; } 

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
      
        [Required]
        public string MaturityRating { get; set; }
    }
}
