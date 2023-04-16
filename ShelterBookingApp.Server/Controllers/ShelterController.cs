using Microsoft.AspNetCore.Mvc;
using ShelterBookingApp.Server.Interface;
using ShelterBookingApp.Shared.Models; 

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShelterBookingApp.Server.Controllers
{
    [Route("api/Shelter")]
    [ApiController]
    public class ShelterController : ControllerBase
    {


        public readonly IShelter shelterRepository; // navngive som repo her 



        public ShelterController(IShelter ishelter)
        {
            shelterRepository = ishelter;
        }



        // GET: api/<ShelterController>
        [HttpGet]
        public List<Shelter> GetAllShelters()
        {
            Console.WriteLine("Get all shelters (Controller) ");

            return shelterRepository.GetAllShelters();
        }



        // PUT api/<ShelterController>/5

        [HttpGet("{shelterId}")]
        public Shelter GetShelterById(string shelterId)
        {
 
            Console.WriteLine("GetSHelterById controller");
            Shelter shelter = shelterRepository.GetShelterById(shelterId);
            return shelter;
        }

        // DELETE api/<ShelterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        // POST api/<ShelterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
