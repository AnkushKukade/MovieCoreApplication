using MovieApp.Data.Repositories;
using MovieApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Business.services
{
    public class MovieShowTimeService
    {
        IMovieShowTime _movieShowTime;
        public MovieShowTimeService(IMovieShowTime movieShowTime)
        {
            _movieShowTime = movieShowTime;
        }
        public string InsertMovieShowTime(MovieShowTimeModel movieShowTimeModel)
        {
            return _movieShowTime.InsertMovieShowTime(movieShowTimeModel);
        }
        public List<MovieShowTimeModel> ShowMovieTimeList()
        {
            return _movieShowTime.ShowMovieTime();
        }
        public MovieShowTimeModel GetMovieShowTimeById(int ShowId, int TheatreId)
        {
            return _movieShowTime.GetMovieShowTimeById(ShowId);
        }
        public string UpdateMovieShowTime(MovieShowTimeModel movieShowTimeModel)
        {
            return _movieShowTime.UpdateMovieShowTime(movieShowTimeModel);
        }

        public string DeleteMovieShowTime(int ShowId)
        {
            return _movieShowTime.DeleteMovieShowTime(ShowId);
        }

        /*public object GetSpecificMovieShowTimeById(int id)
        {
            throw new NotImplementedException();
        }*/

        public List<MovieShowTimeModel> GetShowTimesAndDateForSpeTheatreAndMovie(int mId)
        {
            return _movieShowTime.GetShowTimesAndDateForSpeTheatreAndMovie(mId);
        }
    }
}
