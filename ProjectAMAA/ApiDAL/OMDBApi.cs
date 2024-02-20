using Newtonsoft.Json;
using ProjectAMAA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace ProjectAMAA.ApiDAL
{
    public class OMDBApi
    {
        public OMDBModel GetOMDBMovie(String movieName)
        {
            OMDBModel movie;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("http://www.omdbapi.com/?apikey=8adaa67c&t=" + movieName).Result;
                
                string responseBody = response.Content.ReadAsStringAsync().Result;

                movie = JsonConvert.DeserializeObject<OMDBModel>(responseBody);
            }
            return movie;
        }
    }
}