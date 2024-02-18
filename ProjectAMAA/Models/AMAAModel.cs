using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAMAA.Models
{
    public class AMAAModel
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public Actor[] Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Awards { get; set; }
        public string Poster { get; set; }
        public Rating[] Ratings { get; set; }
        public string imdbRating { get; set; }
        public string imdbVotes { get; set; }
        public string imdbID { get; set; }
        public string Type { get; set; }
        public string BoxOffice { get; set; }

        public class Rating
        {
            public string Source { get; set; }
            public string Value { get; set; }
        }
        public class Actor
        {
            public string name_surname { get; set; }
            public ActorsMovies[] ActorsMovies { get; set; }
        }

        public class ActorsMovies
        {
            public string original_title { get; set; }
            public string english_title { get; set; }
            public string overview { get; set; }
            public string character { get; set; } = "unspecified";
            public string release_date { get; set; }
            public string poster_path { get; set; }
            public string original_language { get; set; }
        }
    }
}