using ShelterBookingApp.Shared.Models;
using System.Xml.Serialization;

namespace ShelterBookingApp.Server.Interface
{
    public interface IShelter
    {
        List<Shelter> GetAllShelters();

        Shelter GetShelterById(string id); 


         //Task Update(int id); 
    }
}
