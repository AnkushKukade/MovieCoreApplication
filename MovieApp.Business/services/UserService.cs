using MovieApp.Data.Repositories;
using MovieApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Business.services
{
    public class UserService
    {
         IUser _iuser;
        public UserService(IUser iuser)
        {
           _iuser = iuser;
        }
        public string Register(UserModel userModel)
        {
           return _iuser.Register(userModel);
        }
        public UserModel Login(UserModel userModel)
        {
            return _iuser.Login(userModel);
        }
    }
}
