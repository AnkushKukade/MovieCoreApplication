using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MovieApp.Entity;
using MovieApp.Data.DataConnection;
using Microsoft.EntityFrameworkCore;

namespace MovieApp.Data.Repositories
{
    /*
         AddTheatre
         UpdateTheatre
        DeleteTheatre
        SelectTheatres();
        GetSpecificTheatre
     */
   public class Theatre : ITheatre
    {
        MovieDbContext _movieDbContext;
        public Theatre(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }
        public void DeleteTheatre(int TheatreId)
        {
            TheatreModel theatre = _movieDbContext.theatreModel.Find(TheatreId);
            _movieDbContext.theatreModel.Remove(theatre);
            _movieDbContext.SaveChanges();
        }
        public string AddTheatre(TheatreModel theatreModel)
        {
            string msg = "";
            _movieDbContext.theatreModel.Add(theatreModel);
            _movieDbContext.SaveChanges();
            msg = "Theatre-Details Added !!";
            return msg;
        }
        public void UpdateTheatre(TheatreModel theatreModel)
        {
            _movieDbContext.Entry(theatreModel).State = EntityState.Modified;
            _movieDbContext.SaveChanges();
        }
        public List<TheatreModel> SelectTheatres()
        {
            return _movieDbContext.theatreModel.ToList();
        }
        public TheatreModel GetSpecificTheatre(int TheatreId)
        {
            return _movieDbContext.theatreModel.Find(TheatreId);
        }
    }
}
