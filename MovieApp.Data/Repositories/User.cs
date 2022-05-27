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
         MovieDbContext _movieDbContext;
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

        public string Register(UserModel userModel)
        {
            string message = "";
            _movieDbContext.userModel.Add(userModel);
            _movieDbContext.SaveChanges();
            message = "Record inserted Successfully!!";
            return message;
        }
    }
}
