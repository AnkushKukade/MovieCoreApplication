using MovieApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Data.Repositories
{
    public interface IUser
    {
        void Register(UserModel userModel);
        UserModel Login(UserModel user);
    }
}
