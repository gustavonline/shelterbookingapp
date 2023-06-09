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

        public readonly IBooking bookingRepository; // Navngive det her anderledes, det er et repository 
        
        public BookingController(IBooking iBooking)
        {
            bookingRepository = iBooking;
        }
        
        // GET: api/Booking
        [HttpGet]
        public List<Booking> GetAllBookings()
        {
            Console.WriteLine("Get all bookings ");

            return bookingRepository.GetAllBookings();
        }

        // GET: api/Booking/5
        [HttpGet("{shelterId}")]
        public List<Booking> GetBookingsById(string shelterId)
        {
            Console.WriteLine("Get bookings by id");
            List<Booking> bookings = bookingRepository.GetBookingsById(shelterId);
            return bookings;
        }



        // POST: api/Booking 
        // Making this Task<Iactionresult> because this enables http status code use 
        [HttpPost]
        public async Task<IActionResult> AddBooking(Booking newBooking) 
        {
            //If method returns tu
            if(bookingRepository.AddBooking(newBooking))
            {
                return Ok("Shelter successfully booked");
            }
            else
            {
                return BadRequest("Shelter is already booked on those dates");
            }
           
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
