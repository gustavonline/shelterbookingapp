using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShelterBookingApp.Shared.Models
{
    
    [BsonIgnoreExtraElements]
    public class Shelter
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = "";

        [BsonElement("properties")]
        public ShelterProperties Properties { get; set; }
        
        [BsonElement("bookings")]
        public ShelterBookings Bookings { get; set; }
        
    }

    [BsonIgnoreExtraElements]
    public class ShelterProperties
    {
        [BsonElement("navn")]
        public string Name { get; set; }

        [BsonElement("antal_pl")]
        public int Capacity { get; set; }

        [BsonElement("beskrivels")]
        public string Description { get; set; }

        [BsonElement("cvr_navn")]
        public string Municipality { get; set; }
    }
}