using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using MovieApp.Business.services;
using MovieApp.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TheatreController : ControllerBase
    {
        TheatreService _theatreService;
        public TheatreController(TheatreService theatreService)
        {
            _theatreService = theatreService;
        }

        [HttpPost("ÄddTheatre")]
        public IActionResult ÄddTheatre(TheatreModel theatreModel)
        {
            return Ok(_theatreService.AddTheatre(theatreModel));
        }

        [HttpGet("SelectTheatre")]
        public IActionResult SelectTheatre()
        {
            return Ok(_theatreService.SelectTheatre());
        }

        [HttpDelete("DeleteTheatre")]
        public IActionResult DeleteTheatre(int TheatreId)
        {
            _theatreService.DeleteTheatre(TheatreId);
            return Ok("Deleted");
        }

        [HttpPut("UpdateTheatre")]
        public IActionResult UpdateTheatre(TheatreModel theatreModel)
        {
            _theatreService.UpadateTheatre(theatreModel);
            return Ok("Updataed ");
        }

        [HttpGet("GetSpecificTheatre")]
        public IActionResult GetSpecificTheatre(int TheatreId)
        {
            return Ok(_theatreService.GetSpecificTheatre(TheatreId));
        }
    }
}
