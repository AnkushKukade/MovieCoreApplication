using MovieApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Data.DataConnection;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
        public string DeleteMovie(int MovieId)
        {
            string msg = "";
            MovieModel movie = _movieDbContext.movieModel.Find(MovieId);
            _movieDbContext.movieModel.Remove(movie);
            _movieDbContext.SaveChanges();
            msg = "Deleted Movie !!";
            return msg;
        }
        public string UpdateMovie(MovieModel movieModel)
        {
            string msg = "";
            _movieDbContext.Entry(movieModel).State = EntityState.Modified;
            _movieDbContext.SaveChanges();
            msg = "Movie field Updated !!";
            return msg;
        }
        public List<MovieModel> SelectMovies()
        {
            return _movieDbContext.movieModel.ToList();
        }


        public MovieModel GetSpecificMovie(int MovieId)
        {
            return _movieDbContext.movieModel.Find(MovieId);
        }
    }
}
