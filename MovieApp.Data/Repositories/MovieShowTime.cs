using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Data.DataConnection;
using System.Linq;
using MovieApp.Entity;

namespace MovieApp.Data.Repositories
{
    public class MovieShowTime : IMovieShowTime
    {
        MovieDbContext _movieDbContext;
        public MovieShowTime(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }
        public string DeleteMovieShowTime(int ShowId)
        {
            string msg = "";
            MovieShowTimeModel movieShowTimeModel = _movieDbContext.movieShowTimeModel.Find(ShowId);
            _movieDbContext.movieShowTimeModel.Remove(movieShowTimeModel);
            _movieDbContext.SaveChanges();
            msg = "MovieShowTime Deleted !!";
            return msg;
        }
        public string InsertMovieShowTime(MovieApp.Entity.MovieShowTimeModel movieShowTimeModel)
        {
            _movieDbContext.movieShowTimeModel.Add(movieShowTimeModel);
            _movieDbContext.SaveChanges();
            return "Inserted";
        }

        public List<MovieApp.Entity.MovieShowTimeModel> ShowMovieTime()
        {
            return _movieDbContext.movieShowTimeModel.ToList();

        }
        public MovieShowTimeModel GetMovieShowTimeById(int ShowId)
        {
            return _movieDbContext.movieShowTimeModel.Find(ShowId);

        }
        public string UpdateMovieShowTime(MovieShowTimeModel movieShowTimeModel)
        {
            _movieDbContext.Entry(movieShowTimeModel).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _movieDbContext.SaveChanges();
            return "MovieShowTime Updated !!";
        }
        public List<MovieShowTimeModel> GetShowTimesAndDateForSpeTheatreAndMovie(int mId)
        {
            // moviemodel
            var movieShowTime = _movieDbContext.movieShowTimeModel.Where(u => u.MovieId == mId).ToList();
            return movieShowTime;
        }
    }
}
