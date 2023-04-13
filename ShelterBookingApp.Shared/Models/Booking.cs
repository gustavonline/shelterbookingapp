using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace ShelterBookingApp.Shared.Models
{
    public class Booking
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ObjectId { get; set; } // Changed to string 
        
        //Herfra og ned bruges der ikke Bson mapping, da vores variabel navne er ens med vores navne i databasen
        
        public string ShelterId { get; set; } = "";
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public string BookeeName { get; set; } = "";
        [Required]
        public string BookeeAddress { get; set; } = "";
        [Required]
     
        public int BookeePhone { get; set; }
    }

}