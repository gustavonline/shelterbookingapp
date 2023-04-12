using ShelterBookingApp.Shared.Models;

namespace ShelterBookingApp.Server.Interface
{
    public interface IShelter
    {
        List<Shelter> GetAllShelters(); 
        
         //Task Update(int id); 
    }
}
