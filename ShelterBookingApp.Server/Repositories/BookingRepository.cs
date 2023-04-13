using MongoDB.Driver;
using MongoDB.Bson;
using ShelterBookingApp.Server.Interface;
using ShelterBookingApp.Shared.Models;

namespace ShelterBookingApp.Server.Repositories;

public class BookingRepository : IBooking
{
    private const string connectionString = @"mongodb+srv://admin:W7IZknfnXB1pI2zq@clustershelterdata0.7zlpukv.mongodb.net/test";
    private const string databaseName = "shelterDB";
    private const string collectionName = "bookings";
    private IMongoCollection<Booking> collection;
    private IBooking _bookingImplementation;
    
    
public BookingRepository()
    {
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(databaseName);
        collection = database.GetCollection<Booking>(collectionName);
    }

    public List<Booking> GetAllBookings()
    {
        return collection.Find(new BsonDocument()).ToList();
    }
    
    public void AddBooking(Booking newBooking)
    {
        collection.InsertOne(newBooking);
    }

    public void DeleteBooking(string id)
    {
        collection.DeleteOne(booking => booking.Id == id);
    }
}