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
    
    public bool AddBooking(Booking newBooking)
    {
        if (IsBookingOverlapping(newBooking)) {
            return false;
        } else {
            Console.WriteLine("Booking added to database");
            collection.InsertOne(newBooking);
            return true;
        }
    }

    public bool IsBookingOverlapping(Booking newBooking)
    {
        //Adding filter that finds a selection of data 
        // - The StartDate of existing booking must be less than or equal to the EndDate of the new booking.
        // - The EndDate of the existing booking must be greater than or equal to the StartDate of the new booking.
        // - The ShelterId of the existing booking must match the ShelterId of the new booking.
        var newFilter = Builders<Booking>.Filter.And(
            Builders<Booking>.Filter.Lte("StartDate", newBooking.EndDate),
            Builders<Booking>.Filter.Gte("EndDate", newBooking.StartDate),
            Builders<Booking>.Filter.Eq("ShelterId", newBooking.ShelterId)
        );

        //Getting those data based on filter 
        var overlappingBookings = collection.Find(newFilter).ToList();

        //If none are found return true
        if (overlappingBookings.Count > 0)
        {
            return true;
        }
        //If any are found, return false 
        return false;
       
        
    }
    
    //Get bookings by ShelterId
    public List<Booking> GetBookingsById(string shelterId)
    {
        Console.WriteLine("Get bookings by ID repo:");
        var filter = Builders<Booking>.Filter.Eq("ShelterId", shelterId);
        return collection.Find(filter).ToList();
    }

}