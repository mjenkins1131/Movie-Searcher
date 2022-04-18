using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MovieSearchService.Models;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieSearchService.Controllers
{
    [Route("api/SearchMovie")]
    [ApiController]
    public class SearchMovie : ControllerBase
    {
        // GET api/<SearchMovie>/Lilo
        [HttpGet("{name}")]
        public async Task<List<string>> GetAsync(string name)
        {
            List<Movie> movieNameList = new List<Movie>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://api.themoviedb.org/3/search/movie?api_key=4544d8b9aba2eabf203d74f96d505707&query={name}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    DatabaseAPIResponse responseObject = JsonConvert.DeserializeObject<DatabaseAPIResponse>(apiResponse);
                    movieNameList = responseObject.Results;
                }
            }

            return movieNameList.Count() > 1 ? movieNameList.Select(p => p.Title).ToList() : new List<string>() { "No Movie Found!"};
        }
    }
}
