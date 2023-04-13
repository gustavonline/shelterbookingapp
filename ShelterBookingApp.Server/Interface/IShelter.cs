using ShelterBookingApp.Shared.Models;

namespace ShelterBookingApp.Server.Interface
{
    public interface IShelter
    {
        List<Shelter> GetAllShelters();

        Shelter GetShelterById(string id);
    }
}
