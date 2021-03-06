using MovieApp.Data.Repositories;
using MovieApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Business.services
{
    public class BookingService
    {
        IBooking _iBooking;
        public BookingService(IBooking iBooking)
        {
            _iBooking = iBooking;
        }

        public string AddBooking(BookingModel bookingModel)
        {
            return _iBooking.BookingRegister(bookingModel);
        }

        public List<BookingModel> GetAllBooking()
        {
            return _iBooking.GetAllBooking();
        }
    }
}
