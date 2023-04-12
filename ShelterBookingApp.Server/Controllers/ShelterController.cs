﻿using Microsoft.AspNetCore.Mvc;
using ShelterBookingApp.Server.Interface;
using ShelterBookingApp.Shared.Models; 

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShelterBookingApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShelterController : ControllerBase
    {


        public readonly IShelter _Ishelter; 



        public ShelterController(IShelter ishelter)
        {
            _Ishelter = ishelter;
        }



        // GET: api/<ShelterController>
        [HttpGet]
        public Task<List<Shelter>> GetAllShelters()
        {
            Console.WriteLine("Get all shelters (Controller) ");

            return _Ishelter.GetAllShelters();
        }

        // GET api/<ShelterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ShelterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ShelterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ShelterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
