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
    [ApiController] //HTTPGET,HTTPPUT,HTTPPOST - req json response
    public class UserController : ControllerBase
    {
            UserService _userService;
            public UserController(UserService userService)
            {
                _userService = userService;
            }
            [HttpGet("SelectUsers")]
            public IActionResult SelectUsers()
            {
                return Ok(_userService.SelectUsers());
            }
            [HttpPost("Register")]
            public IActionResult Register(UserModel userModel)
            {
                return Ok(_userService.Register(userModel));
            }
            [HttpDelete("DeleteUser")]
            public IActionResult DeleteUser(int userId)
            {
                return Ok(_userService.DeleteUser(userId));
            }
            [HttpPut("UpdateUser")]
            public IActionResult UpdateUser(UserModel userModel)
            {
                return Ok(_userService.Updateuser(userModel));
            }
            [HttpPost("Login")]
            public IActionResult Login(UserModel userModel)
            {
                return Ok(_userService.Login(userModel));
            }
            [HttpGet("SelectUserById")]
            public IActionResult SelectUserById(int userId)
            {
                return Ok(_userService.SelectUserById(userId));
            }
        
    }
}
