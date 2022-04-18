using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieSearchService.Models
{
    public class DatabaseAPIResponse
    {
        public int page { get; set; }
        public List<Movie> Results { get; set; }
        public int Total_Pages { get; set; }
        public int Total_Results { get; set; }
    }
}
