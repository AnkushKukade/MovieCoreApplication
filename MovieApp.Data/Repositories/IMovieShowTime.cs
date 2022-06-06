using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Entity;

namespace MovieApp.Data.Repositories
{
    public interface IMovieShowTime
    {
        string InsertMovieShowTime(MovieApp.Entity.MovieShowTimeModel movieShowTimeModel);
        List<MovieApp.Entity.MovieShowTimeModel> ShowMovieTime();
        public string UpdateMovieShowTime(MovieShowTimeModel movieShowTimeModel);
        string DeleteMovieShowTime(int ShowId);
        MovieShowTimeModel GetMovieShowTimeById(int ShowId);
        public List<MovieShowTimeModel> GetShowTimesAndDateForSpeTheatreAndMovie(int mId);
    }
}
