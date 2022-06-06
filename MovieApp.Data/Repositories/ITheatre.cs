using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Entity;

namespace MovieApp.Data.Repositories
{
    public interface ITheatre
    {
        public string AddTheatre(TheatreModel theatreModel);
        public void UpdateTheatre(TheatreModel theatreModel);
        public void DeleteTheatre(int TheatreId);
        public List<TheatreModel> SelectTheatres();
        public TheatreModel GetSpecificTheatre(int TheatreId);
    }
}
