using ShelterBookingApp.Shared.Models;

namespace ShelterBookingApp.Server.Interface;

public interface IBooking
{
    List<Booking> GetAllBookings();
    
    void AddBooking(Booking newBooking);

}