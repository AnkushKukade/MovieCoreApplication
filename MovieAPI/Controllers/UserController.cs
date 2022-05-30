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
         UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }
        [HttpPost("Register")]
        public IActionResult Register(UserModel userModel)
        {
            _userService.Register(userModel);
            return Ok("Register Successfully !!");
        }
        [HttpPost("Login")]
        public IActionResult Login(UserModel userModel)
        {
             _userService.Login(userModel);
         
            return Ok("Login Success!!");
          
        }
    }
}
