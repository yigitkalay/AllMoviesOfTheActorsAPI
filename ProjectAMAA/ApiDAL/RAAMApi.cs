using Newtonsoft.Json;
using ProjectAMAA.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace ProjectAMAA.ApiDAL
{
    public class RAAMApi
    {
        public List<RAAMModel> Actor(String actorName)
        {
            List<RAAMModel> movie;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation("X-RapidAPI-Key", File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "RAAMKey.txt"));
                client.DefaultRequestHeaders.TryAddWithoutValidation("X-RapidAPI-Host", "actor-movie-api1.p.rapidapi.com");

                HttpResponseMessage response = client.GetAsync("https://actor-movie-api1.p.rapidapi.com/getid/"+actorName+"?apiKey=62ffac58c57333a136053150eaa1b587").Result;

                string responseBody = response.Content.ReadAsStringAsync().Result;

                movie = JsonConvert.DeserializeObject<List<RAAMModel>>(responseBody);
            }
            return movie;
        }
    }
}