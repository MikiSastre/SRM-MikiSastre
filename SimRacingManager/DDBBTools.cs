using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime.Documents;

using System.IO;
using System.Windows.Forms;
using System.Text.Json;
//Connexió MongoDB
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using SharpCompress.Writers;
using System.Diagnostics;
using SharpCompress.Common;
using System.ComponentModel;
using MongoDB.Driver.Linq;

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

        /**
         * Metode per insertar un document a una colecció connectant al mongoDB
         */
        public async Task InsertDocumentAsync<T>(string collectionName, T document)
        {
            IMongoCollection<T> collection = database.GetCollection<T>(collectionName);
            await collection.InsertOneAsync(document);
        }
      
        // Metode per verificar que l'usuari i la contrassenya son correctes
        public async Task<bool> VerifyCredentialsAsync(string username, string password)
        {
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("Users");

            // Creem un filtre per buscar l'usuari al document
            var filter = Builders<BsonDocument>.Filter.Eq("username", username);

            // Busquem l'usuari a la colecció
            BsonDocument user = await collection.Find(filter).FirstOrDefaultAsync();

            if (user != null)
            {
                // Comparem la contrassenya
                string storedPassword = user["password"].AsString;
                return storedPassword == password;
            }

            return false;
        }

        /**
         * Aquest metode Llegeix el document JSON i envia les dades al metode InsertDocumentAsync
         */
        public async Task InsertRaceDataFromJsonAsync(string filePath)
        {
            // Leer el documento JSON
            string jsonString = File.ReadAllText(filePath);

            // Convertir el JSON amb l'instancia de RaceData
            RaceData raceData = JsonSerializer.Deserialize<RaceData>(jsonString);

            // Inserta l'información principal de la carrera
            await InsertDocumentAsync("Races", raceData);

            // Inserta els jugadors a la colecció "Players"
            foreach (var player in raceData.players)
            {
                await InsertDocumentAsync("Players", player);
            }

            // Inserta les sessions a la colecció "Sessions"
            foreach (var session in raceData.sessions)
            {
                await InsertDocumentAsync("Sessions", session);

                // Inserta les voltes de cada sessió en la colecció "Laps"
                foreach (var lap in session.laps)
                {
                    await InsertDocumentAsync("Laps", lap);
                }
            }

            // Insertar els extras a la colecció "Extras"
            foreach (var extra in raceData.extras)
            {
                await InsertDocumentAsync("Extras", extra);
            }
        }

        /**
         * Aquest metode recull tota la informació de la base de dades a traves de RaceData.cs
         */
        public async Task<List<RaceData>> GetRaceData()
        {
            // Recull la data de la collecció "Races" i l'envia a racesCollection
            IMongoCollection<RaceData> racesCollection = database.GetCollection<RaceData>("Races");
            // Fa un "Find" i la collecció mostra els documents guardant a raceList
            List<RaceData> raceList = racesCollection.Find(FilterDefinition<RaceData>.Empty).ToList();
            // Retorna la llista
            return raceList;
        }
    }
}   


