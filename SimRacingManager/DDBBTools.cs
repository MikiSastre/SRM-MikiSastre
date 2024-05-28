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

        // Metode per insertar un document a una colecció
        public async Task InsertDocumentAsync<T>(string collectionName, T document)
        {
            IMongoCollection<T> collection = database.GetCollection<T>(collectionName);
            await collection.InsertOneAsync(document);
        }
      
        // Metode per verificar que l'usuari i la contrassenya son correctes
        public async Task<bool> VerifyCredentialsAsync(string username, string password)
        {
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("users");

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

        public async Task GetRaceData()
        {
            IMongoCollection<RaceData> racesCollection = database.GetCollection<RaceData>("Races");
            List<RaceData> racesList = racesCollection.Find(FilterDefinition<RaceData>.Empty).ToList();

            string pathName = ProgramData.exportFolder + "\\" + "Races.csv";
            using (StreamWriter writer = new StreamWriter(pathName))
            {
                // Li posem un titol a cada casella del .csv
                writer.WriteLine("ID,track,number_of_sessions,players,sessions,extras");

                // Recorre i escriu cada casella al csv
                foreach (var raceData in racesList)
                {
                    string players = JsonSerializer.Serialize(raceData.players);
                    string sessions = JsonSerializer.Serialize(raceData.sessions);
                    string extras = JsonSerializer.Serialize(raceData.extras);

                    writer.WriteLine($"{raceData._id},{raceData.track},{raceData.number_of_sessions},\"{players}\",\"{sessions}\",\"{extras}\"");
                }
            }
        }

        public async Task ShowDataGrid()
        {
            IMongoCollection<RaceData> racesCollection = database.GetCollection<RaceData>("RaceData");
            List<RaceData> dataList = racesCollection.Find(FilterDefinition<RaceData>.Empty).ToList();

            foreach (var raceData in dataList)
            {
                dataList.Add(raceData);

                string[] row1 = new string[] { raceData._id.ToString() };
                string[] row2 = new string[] { raceData.track.ToString() };
                string[] row3 = new string[] { raceData.number_of_sessions.ToString() };
            }
        }
    }
}   


