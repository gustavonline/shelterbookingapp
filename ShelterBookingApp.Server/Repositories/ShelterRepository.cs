using MongoDB.Driver;
using MongoDB.Bson;
using ShelterBookingApp.Server.Interface;
using ShelterBookingApp.Shared.Models;


namespace ShelterBookingApp.Server.Repositories
{
    public class ShelterRepository : IShelter
    {
        private const string connectionString = @"mongodb+srv://admin:W7IZknfnXB1pI2zq@clustershelterdata0.7zlpukv.mongodb.net/test";
        private const string databaseName = "shelterDB";
        private const string collectionName = "shelter_minus";
        private IMongoCollection<Shelter> collection;
        private IShelter _shelterImplementation;


        public ShelterRepository()
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            collection = database.GetCollection<Shelter>(collectionName);
        }


        public List<Shelter> GetAllShelters() 
        {

            //return await collection.Find(i => true).ToListAsync();
            return collection.Find(new BsonDocument()).ToList();
        }
        
        
        public Shelter GetShelterById(string shelterId)
        {
          
                Console.WriteLine("Get shelter by ID repo:");
                var filter = Builders<Shelter>.Filter.Eq("_id", ObjectId.Parse(shelterId));
                var shelter = collection.Find(filter).FirstOrDefault();
                return shelter;


                //Console.WriteLine("Get shelter by ID repo:");
                //Shelter shelter = (Shelter)collection.Find(new BsonDocument("Id", shelterId));
                //return shelter;



                //var filter = Builders<Shelter>.Filter.Eq(s => s.Id, id);
                //return collection.Find(filter).FirstOrDefault(



            
        }
        
    }
}
