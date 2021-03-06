using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Data.Repositories;
using MovieApp.Entity;

namespace MovieApp.Business.services
{
    public class MovieService
    {
        IMovie _iMovie;
        public MovieService(IMovie imovie)
        {
            _iMovie = imovie;
        }

        public string AddMovie(MovieModel movieModel)
        {
            return _iMovie.AddMovie(movieModel);
        }

        public List<MovieModel> SelectMovies()
        {
            return _iMovie.SelectMovies();
        }

        public string UpdateMovie(MovieModel movieModel)
        {
            return _iMovie.UpdateMovie(movieModel);
        }

        /*public string UpdateMovieDetails(MovieModel movieModel)
        {
            return _iMovie.UpdateMovieDetails(movieModel);
        }*/

        public string DeleteMovie(int MovieId)
        {
            return _iMovie.DeleteMovie(MovieId);
        }


        public MovieModel GetSpecificMovie(int id)
        {
            return (_iMovie.GetSpecificMovie(id));
        }
    }
}
