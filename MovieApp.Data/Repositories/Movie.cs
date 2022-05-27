using MovieApp.Data.DataConnection;
using MovieApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Data.Repositories
{
    public class Movie : IMovie
    {
        MovieDbContext _movieDbContext;
        public Movie(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }
        public string AddMovie(MovieModel movieModel)
        {
            string message = "";
            _movieDbContext.movieModel.Add(movieModel);
            _movieDbContext.SaveChanges();
            message = "Movie insetted !!";
            return message;
        }

    }
}
