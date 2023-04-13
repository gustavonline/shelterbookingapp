using ShelterBookingApp.Shared.Models;
using MongoDB.Bson;

namespace ShelterBookingApp.Server.Interface;

public interface IBooking
{
    List<Booking> GetAllBookings();
    
    void AddBooking(Booking newBooking);

    void DeleteBooking(string id);
}