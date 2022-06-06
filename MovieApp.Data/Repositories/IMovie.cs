using MovieApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Data.Repositories
{
    public interface IMovie
    {
        public List<MovieModel> SelectMovies();
        public string AddMovie(MovieModel movieModel);
        //public string Register(MovieModel movieModel);
        public string DeleteMovie(int MovieId);
        public string UpdateMovie(MovieModel movieModel);
        public MovieModel GetSpecificMovie(int MovieId);
    }
}
