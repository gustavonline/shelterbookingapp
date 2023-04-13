using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShelterBookingApp.Shared.Models
{
    public class Booking
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BookingId { get; set; } = "";
        
        //Herfra og ned bruges der ikke Bson mapping, da vores variabel navne er ens med vores navne i databasen
        
        public string ShelterId { get; set; } = "";
        
        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }
        
        public string BookeeName { get; set; } = "";
        
        public string BookeeAddress { get; set; } = "";
    
        public int BookeePhone { get; set; } = 0;
    }

}