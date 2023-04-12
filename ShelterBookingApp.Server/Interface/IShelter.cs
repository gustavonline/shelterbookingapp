using ShelterBookingApp.Shared.Models;

namespace ShelterBookingApp.Server.Interface
{
    public interface IShelter
    {
        Task<List<Shelter>> GetAllShelters(); 
        
         Task Update(int id); 
    }
}
