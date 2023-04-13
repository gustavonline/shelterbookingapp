using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShelterBookingApp.Server.Interface;
using ShelterBookingApp.Shared.Models; 

namespace ShelterBookingApp.Server.Controllers
{
    [Route("api/Booking")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        
        public readonly IBooking _Ibooking;
        
        public BookingController(IBooking iBooking)
        {
            _Ibooking = iBooking;
        }
        
        // GET: api/Booking
        [HttpGet]
        public List<Booking> GetAllBookings()
        {
            Console.WriteLine("Get all bookings ");

            return _Ibooking.GetAllBookings();
        }

        // GET: api/Booking/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Booking
        [HttpPost]
        public void AddBooking(Booking newBooking)
        {
            _Ibooking.AddBooking(newBooking);
        }

        // PUT: api/Booking/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Booking/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
