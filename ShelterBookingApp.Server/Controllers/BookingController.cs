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
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        
        public readonly IBooking _Ibooking; // Navngive det her anderledes, det er et repository 
        
        public BookingController(IBooking iBooking)
        {
            _Ibooking = iBooking;
        }
        
        // GET: api/Booking
        [HttpGet]
        public List<Booking> GetAllBookings()
        {
            Console.WriteLine("Get all bookings(Controller) ");

            return _Ibooking.GetAllBookings();
        }

        // GET: api/Booking/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Booking 
        // Making this Task<Iactionresult> because this enables http status code use 
        [HttpPost]
        public async Task<IActionResult> AddBooking(Booking newBooking) 
        {
            //If method returns tu
            if(_Ibooking.AddBooking(newBooking))
            {
                return Ok("Shelter successfully booked");
            }
            else
            {
                return BadRequest("Shelter is occupied on the chosen dates");
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
