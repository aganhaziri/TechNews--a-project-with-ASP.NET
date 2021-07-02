using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItNews.Models;
namespace ItNews
{
    public class Data
    {

        public static List<NewsItem> ItNews { get; set; }

        static Data()
        {
            ItNews = new List<NewsItem>();
        }
    }
}
