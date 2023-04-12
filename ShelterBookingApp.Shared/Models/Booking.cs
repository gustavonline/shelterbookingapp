using MongoDB.Bson.Serialization.Attributes;

namespace ShelterBookingApp.Shared.Models
{
    
    [BsonIgnoreExtraElements]
    public class ShelterBookings
    {
       [BsonElement("BookingId")]
    public int BookingId { get; set; }
    
    [BsonElement("StartDate")]
    public DateTime StartDate { get; set; }
    
    [BsonElement("EndDate")]
    public DateTime EndDate { get; set; }
    
    [BsonElement("BookeeInfo")]
    public BookeeInfo BookeeInfo { get; set; }
    
    }
    
    [BsonIgnoreExtraElements]
    public class BookeeInfo
    {
        [BsonElement("BookeeName")]
        public string Name { get; set; }
        
        [BsonElement("BookeMobile")]
        public string Email { get; set; }
        
        [BsonElement("BookeeAddress")]
        public string Phone { get; set; }
    }
    
    
}
