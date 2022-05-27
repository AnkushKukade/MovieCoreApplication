using MovieApp.Data.DataConnection;
using MovieApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieApp.Data.Repositories
{
    public class User : IUser
    {
        private MovieDbContext _movieDbContext;
        public User(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }
        public UserModel Login(UserModel userModel)
        {
            UserModel user = null;
            var result = _movieDbContext.userModel.Where(obj => obj.Email == user.Email && obj.Password == user.Password).ToList();
            if(result.Count > 0)
            {
                userModel = result[0];
            }
            return userModel;
        }

        public void Register(UserModel userModel)
        {
            _movieDbContext.userModel.Add(userModel);
            _movieDbContext.SaveChanges();
        }
    }
}
