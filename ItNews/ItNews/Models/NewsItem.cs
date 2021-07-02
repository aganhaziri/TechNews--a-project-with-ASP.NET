using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItNews.Models
{
    public class NewsItem
    {
        [Required]
        public Guid Post_Id { get; set; }
        [Required]
        public String Post_Title { get; set; }
        [Required]
        [MinLength(20)]
        public String Post_Content { get; set; }
        public bool Complete { get; set; }
    }
        
}
