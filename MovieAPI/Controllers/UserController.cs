using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Business.services;
using MovieApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
         UserInfoService _userInfoService;
        public UserController(UserInfoService user)
        {
            _userInfoService = user;
        }
        [HttpPost("Register")]
        public IActionResult Register(UserModel userModel)
        {
            _userInfoService.Register(userModel);
            return Ok("Register Successfully !!");
        }
        [HttpPost("Login")]
        public IActionResult Login(UserModel userModel)
        {
            UserModel user = _userInfoService.Login(userModel);
            if (user != null)
                return Ok("Login Success!!");
            else
                return NotFound();
        }
    }
}
