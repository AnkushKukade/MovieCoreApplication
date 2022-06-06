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
    public class MovieShowTimeController : ControllerBase
    {
        MovieShowTimeService _movieShowTimeService;
        public MovieShowTimeController(MovieShowTimeService movieShowTimeService)
        {
            _movieShowTimeService = movieShowTimeService;
        }
        [HttpGet("SelectMovieShowTime")]
        public IActionResult SelectMovieShowTime()
        {
            return Ok(_movieShowTimeService.ShowMovieTimeList());
        }
        [HttpPost("InsertMovieShowTime")]
        public IActionResult InsertMovieShowTime(MovieShowTimeModel movieShowTimeModel)
        {
            return Ok(_movieShowTimeService.InsertMovieShowTime(movieShowTimeModel));
        }

        [HttpGet("GetSpecificMovieShowTime")]
        public IActionResult GetSpecificMovieShowTime(int ShowId, int TheatreId)
        {
            return Ok(_movieShowTimeService.GetMovieShowTimeById(ShowId, TheatreId));
        }

        [HttpPut("UpdateMovieShowTime")]
        public IActionResult UpdateMovieShowTime(MovieShowTimeModel movieShowTimeModel)
        {
            return Ok(_movieShowTimeService.UpdateMovieShowTime(movieShowTimeModel));
        }

        [HttpDelete("DeleteMovieShowTime")]
        public IActionResult DeleteMovieShowTime (int ShowId)
        {
            return Ok(_movieShowTimeService.DeleteMovieShowTime(ShowId));
        }

        [HttpGet("GetShowTimesAndDateForSpeTheatreAndMovie")]
        public IActionResult GetShowTimesAndDateForSpeTheatreAndMovie(int mId)
        {
            return Ok(_movieShowTimeService.GetShowTimesAndDateForSpeTheatreAndMovie(mId));
        }
    }
}
