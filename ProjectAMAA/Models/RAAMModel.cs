using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAMAA.Models
{
    public class RAAMModel
    {

        public bool adult { get; set; }
        public string backdrop_path { get; set; }
        public int[] genre_ids { get; set; }
        public int id { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public string overview { get; set; }
        public float popularity { get; set; }
        public string poster_path { get; set; }
        public string release_date { get; set; }
        public string title { get; set; }
        public bool video { get; set; }
        public float vote_average { get; set; }
        public int vote_count { get; set; }
        public string character { get; set; }
        public string credit_id { get; set; }
        public int order { get; set; }
        public int actorId { get; set; }

    }
}