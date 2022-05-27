using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Data.Repositories;
using MovieApp.Entity;

namespace MovieApp.Business.services
{
    public class MovieService
    {
        IMovie movie;
        public MovieService(IMovie movie)
        {
            this.movie = movie;
        }

        // add movie 
        public string AddMovie(MovieModel movieModel)
        {
            return movie.AddMovie(movieModel);
        }
    }
}
