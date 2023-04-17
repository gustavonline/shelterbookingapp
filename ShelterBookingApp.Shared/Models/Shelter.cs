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

        // Here we use Bson mapping to "go deeper" into our object and map out the necessary values. The data is nested in MongoDB.
        [BsonElement("properties")]
        public ShelterProperties Properties { get; set; }

    }

// From here on down, we are mapping data in the object. Note that ShelterProperties is a nested variable that we created above, so the driver understands what to look for.
    [BsonIgnoreExtraElements]
    public class ShelterProperties
    {
        [BsonElement("navn")]
        public string Name { get; set; }

        [BsonElement("antal_pl")]
        public int Capacity { get; set; }

        [BsonElement("cvr_navn")]
        public string Municipality { get; set; }
    }
}