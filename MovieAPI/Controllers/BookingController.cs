using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Business.services;
using MovieApp.Entity;

namespace MovieAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        BookingService _bookingService;
        public BookingController(BookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpPost("AddBooking")]
        public IActionResult AddBooking(BookingModel bookingModel)
        {
            return Ok(_bookingService.AddBooking(bookingModel));
        }
        [HttpGet("GetAllBookings")]
        public IActionResult GetAllBookings()
        {
            return Ok(_bookingService.GetAllBooking());
        }
    }
}
