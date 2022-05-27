using MovieApp.Data.Repositories;
using MovieApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Business.services
{
    public class UserInfoService
    {
        private IUser user;
        public UserInfoService(IUser user)
        {
            this.user = user;
        }
        public void Register(UserModel userModel)
        {
            this.user.Register(userModel);
        }
        public UserModel Login(UserModel userModel)
        {
            return this.user.Login(userModel);
        }
    }
}
