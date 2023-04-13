using ShelterBookingApp.Shared.Models;

namespace ShelterBookingApp.Server.Interface;

public interface IBooking
{
    List<Booking> GetAllBookings();
    
    bool AddBooking(Booking newBooking);
    bool IsBookingOverlapping(Booking newBooking); // Adding method for overlap check

    public List<Booking> GetBookingsById(string shelterId);

}