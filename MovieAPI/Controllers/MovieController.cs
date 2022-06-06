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
    public class MovieController : ControllerBase
    {
        MovieService _movieService;

        public MovieController(MovieService movieService)
        {
            _movieService = movieService;
        }
        [HttpGet("SelectMovie")]
        public IActionResult SelectMovie()
        {
            return Ok(_movieService.SelectMovies());
        }
        [HttpGet("GetSpecificMovie")]
        public IActionResult GetSpecificMovie(int id)
        {
            return Ok(_movieService.GetSpecificMovie(id));
        }
        [HttpPost("AddMovie")]
        public IActionResult AddMovie(MovieModel movieModel)
        {
            return Ok(_movieService.AddMovie(movieModel));
        }
        [HttpPut("UpdateMovie")]
        public IActionResult UpdateMovie([FromBody] MovieModel movieModel)
        {
            return Ok(_movieService.UpdateMovie(movieModel));
        }
        [HttpDelete("DeleteMovie")]
        public IActionResult DeleteMovie(int MovieId)
        {
            return Ok(_movieService.DeleteMovie(MovieId));
        }

    }
}
