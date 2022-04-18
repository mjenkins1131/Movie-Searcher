using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieSearchService.Models
{
    public class Movie
    {
        public string Poster_Path { get; set; }
        public bool Adult { get; set; }
        public string Overview { get; set; }
        public string Release_Date { get; set; }
        public int[] Genre_ids { get; set; }
        public int Id { get; set; }
        public string Original_Title { get; set; }
        public string Original_Language { get; set; }
        public string Title { get; set; }
        public string Backdrop_Path { get; set; }
        public bool Popularity { get; set; }
        public int Vote_Count { get; set; }
        public bool Video { get; set; }
        public double Vote_Average { get; set; }
    }
}
