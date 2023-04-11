﻿using MongoDB.Driver;
using MongoDB.Bson;
using ShelterBookingApp.Server.Interface;
using ShelterBookingApp.Server.Models;


namespace ShelterBookingApp.Server.Repositories
{
    public class ShelterRepository : IShelter
    {
        private const string connectionString = @"mongodb+srv://admin:W7IZknfnXB1pI2zq@clustershelterdata0.7zlpukv.mongodb.net/test";
        private const string databaseName = "ShelterDB";
        private const string collectionName = "shelter_minus";
        private IMongoCollection<Shelter> collection;


        public ShelterRepository()
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            collection = database.GetCollection<Shelter>(collectionName);
        }


        public Task<List<Shelter>> GetAllShelters() {

            return collection.Find(i => true).ToListAsync();
            //return collection.Find(new BsonDocument()).ToListAsync();
        }


    }
}
