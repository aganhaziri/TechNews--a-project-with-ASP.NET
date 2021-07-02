using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Testi.Models
{
    public class Post
    {
        [Key]

        public int Post_Id { get; set; }
        public string Post_Title { get; set; }

        public string Post_Description { get; set; }

        public string Category { get; set; }

        public DateTime Post_Date { get; set; }
    }
}
