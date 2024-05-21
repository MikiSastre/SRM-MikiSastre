using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime.Documents;

//Connexió MongoDB
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;

namespace SimRacingManager
{
    /**
     * Clase per fer les connexions a la base de dades.
     */
    public class DDBBTools
    {
        // Guardem en una string la connexió.
        private String connectionString = "mongodb://localhost:27017";
        // IMongoDatabase es una interficie que proporciona metodes per gestionar la db de MongoDB en .NET.
        private IMongoDatabase database;

        public DDBBTools()
        {
            // Creem l'instancia del client de MongoDB
            MongoClient client = new MongoClient(connectionString);

            // Obtenim la base de datos (si no existeix, es crearà)
            database = client.GetDatabase("simracing-manager");
        }

        // Metode per insertar un document a una colecció
        public async Task InsertDocumentAsync<T>(string collectionName, T document)
        {
            IMongoCollection<T> collection = database.GetCollection<T>(collectionName);
            await collection.InsertOneAsync(document);
        }

        // Metode per obtenir tots els d'una colecció
        public async Task<List<T>> GetDocumentsAsync<T>(string collectionName)
        {
            IMongoCollection<T> collection = database.GetCollection<T>(collectionName);
            return await collection.Find(new BsonDocument()).ToListAsync();
        }
    }
}
