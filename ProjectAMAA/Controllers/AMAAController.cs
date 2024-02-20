using ProjectAMAA.ApiDAL;
using ProjectAMAA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using static ProjectAMAA.Models.AMAAModel;

namespace ProjectAMAA.Controllers
{
    public class AMAAController : ApiController
    {
        [System.Web.Http.HttpGet]
        public AMAAModel GetMovieAndActors(String movieName)
        {
            OMDBApi omdbApi = new OMDBApi();
            OMDBModel omdbModel = omdbApi.GetOMDBMovie(movieName);
            AMAAModel amaaModel = ConvertToAMAAModel(omdbModel);
            return amaaModel;
        }

        protected AMAAModel ConvertToAMAAModel(OMDBModel omdbModel)
        {
            string[] actorNames = !string.IsNullOrEmpty(omdbModel.Actors) ? omdbModel.Actors.Split(',') : null;

            Actor[] actors = actorNames != null
        ? actorNames.Select(name => new Actor { name_surname = name, ActorsMovies = GetActorsMovies(name) }).ToArray()
        : null;

            Rating[] ratings = omdbModel.Ratings != null
        ? omdbModel.Ratings.Select(r => new Rating { Source = r.Source, Value = r.Value }).ToArray()
        : null;

            AMAAModel amaaModel = new AMAAModel
            {
                Title = omdbModel.Title,
                Year = omdbModel.Year,
                Released = omdbModel.Released,
                Runtime = omdbModel.Runtime,
                Genre = omdbModel.Genre,
                Director = omdbModel.Director,
                Writer = omdbModel.Writer,
                Actors = actors,
                Plot = omdbModel.Plot,
                Language = omdbModel.Language,
                Country = omdbModel.Country,
                Awards = omdbModel.Awards,
                Poster = omdbModel.Poster,
                Ratings = ratings,
                imdbRating = omdbModel.imdbRating,
                imdbVotes = omdbModel.imdbVotes,
                imdbID = omdbModel.imdbID,
                Type = omdbModel.Type,
                BoxOffice = omdbModel.BoxOffice
            };

            return amaaModel;
        }

        private List<ActorsMovies> GetActorsMovies(string actorName)
        {
            RAAMApi actorMovieApi = new RAAMApi();
            List<RAAMModel> actorsMovie = actorMovieApi.Actor(actorName);
            List<ActorsMovies> Movies = new List<ActorsMovies>();

            foreach (var actorMovie in actorsMovie)
            {
                Movies.Add(new ActorsMovies
                {
                    original_title = actorMovie.original_title,
                    english_title = actorMovie.title,
                    overview = actorMovie.overview,
                    character = actorMovie.character,
                    release_date = actorMovie.release_date,
                    poster_path = "https://image.tmdb.org/t/p/original" + actorMovie.poster_path,
                    original_language = actorMovie.original_language
                });
            }

            return Movies;
        }
    }
}