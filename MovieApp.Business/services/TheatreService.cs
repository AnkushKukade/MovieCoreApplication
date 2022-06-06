using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Entity;
using MovieApp.Data.Repositories;

namespace MovieApp.Business.services
{
    public class TheatreService
    {
        ITheatre _iTheatre;
        public TheatreService(ITheatre iTheatre)
        {
            _iTheatre = iTheatre;
        }
        public string AddTheatre(TheatreModel theatreModel)
        {
            return _iTheatre.AddTheatre(theatreModel);
        }
        public List<TheatreModel> SelectTheatre()
        {
            return _iTheatre.SelectTheatres();
        }
        public void DeleteTheatre(int TheatreId)
        {
            _iTheatre.DeleteTheatre(TheatreId);
        }
        public void UpadateTheatre(TheatreModel theatreModel)
        {
            _iTheatre.UpdateTheatre(theatreModel);
        }

        public TheatreModel GetSpecificTheatre(int TheatreId)
        {
            return _iTheatre.GetSpecificTheatre(TheatreId);
        }
    }
}
