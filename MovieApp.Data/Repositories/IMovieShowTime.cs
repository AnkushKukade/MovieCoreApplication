using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Entity;

namespace MovieApp.Data.Repositories
{
    public interface IMovieShowTime
    {
        string InsertMovieShowTime(MovieApp.Entity.MovieShowTimeModel movieShowTime);
        List<MovieApp.Entity.MovieShowTimeModel> ShowMovieShowTime();
    }
}
