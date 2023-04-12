using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShelterBookingApp.Shared.Models
{
    [BsonIgnoreExtraElements]
    public class Shelter
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("properties")]
        public ShelterProperties Properties { get; set; }
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