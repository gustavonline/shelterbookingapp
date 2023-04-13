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

        //Her bruges Bson mapping til at "gå dybere" i vores objekt, og mapper de nødvendige værdier ud, dataen er altså nested i MongoDB
        [BsonElement("properties")]
        public ShelterProperties Properties { get; set; }

    }

    // Herfra og ned mapper vi data i objected, lig mærke til at ShelterProperties er en nested variable som vi lavede ovenover så driveren forstår hvad den skal kigge efter
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