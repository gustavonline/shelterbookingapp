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
        
        // From here on down, we do not use Bson mapping since our variable names match our names in the database.
        
        public string ShelterId { get; set; } = "";
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "The name field is required")]
        public string BookeeName { get; set; } = "";
        [Required(ErrorMessage = "The address field is required")]
        public string BookeeAddress { get; set; } = "";


        //Specifies a match of exactly 8 digits.The "^" and "$" characters anchor the pattern to the beginning and end of the string
        [RegularExpression(@"^\d{8}$", ErrorMessage = "The phonenumber must be at least 8 characters (Danish PhoneNumber).")]
        public int BookeePhone { get; set; }
    }

}