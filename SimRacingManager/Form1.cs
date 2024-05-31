using Amazon.Runtime.Documents;
using MongoDB.Driver;
using MongoDB.Libmongocrypt;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace SimRacingManager
{
    public partial class SimRacingManager : Form
    {
        DDBBTools ddbbTools;
        Recording recording;
        string subMenuSelectedType;
        string subMenu2SelectedType;
        public SimRacingManager()
        {
            InitializeComponent();
        }

        
        private void Form1_Load_1(object sender, EventArgs e)
        {
            ddbbTools = new DDBBTools();
            frmLogin frmLogin = new frmLogin();
            frmLogin.StartPosition = FormStartPosition.CenterScreen;

            DialogResult result = frmLogin.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private async void btnImportRecord_Click(object sender, EventArgs e)
        {
            // Crea una instancia de OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                // Configura les propietats del quadre de dialeg
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                Title = "Select a JSON file"
            };

            // Mostra el quadre de dialeg i verifica si l'usuari selecciona un arxiu
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtenir la ruta del arxiu seleccionat
                string filePath = openFileDialog.FileName;

                // Crea una instancia de DDBBTools
                //DDBBTools ddbbTools = new DDBBTools();

                // Inserta les dades de la carrera  des del arxiu JSON a la base de dades
                await ddbbTools.InsertRaceDataFromJsonAsync(filePath);

                MessageBox.Show("Import data success.");
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void defineExportRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crea una instancia de FolderBrowserDialog
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
            {
                Description = "Select a folder to send the exported files"
            }; 

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderExportPath = folderBrowserDialog.SelectedPath;
                ProgramData.exportFolder = folderExportPath;
            }
        }

        /**
         * Metode per exportar de la base de dades a .JSON
         */
        private async void exportRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Obre el formulari de JSON SELECTOR
            frmJsonSelector frmJsonSelector = new frmJsonSelector();
            frmJsonSelector.StartPosition = FormStartPosition.CenterScreen;
            frmJsonSelector.ShowDialog();

            if (frmJsonSelector.DialogResult != DialogResult.OK)
            {
                return;
            }

            DDBBTools ddbbTools = new DDBBTools();

            List<RaceData> raceList;
            try
            {
                raceList = await ddbbTools.GetRaceData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load race data: " + ex.Message);
                return;
            }

            string pathName = ProgramData.exportFolder + "\\" + "Races.json";

            try
            {
                using (StreamWriter writer = new StreamWriter(pathName))
                {
                    foreach (var raceData in raceList)
                    {
                        var exportData = new Dictionary<string, object>();

                        if (frmJsonSelector.ExportRaceId)
                        {
                            exportData.Add("_id", raceData._id);
                        }
                        if (frmJsonSelector.ExportTrack)
                        {
                            exportData.Add("track", raceData.track);
                        }
                        if (frmJsonSelector.ExportNumSessions)
                        {
                            exportData.Add("number_of_sessions", raceData.number_of_sessions);
                        }
                        if (frmJsonSelector.ExportPlayers)
                        {
                            exportData.Add("players", raceData.players);
                        }
                        if (frmJsonSelector.ExportSessions)
                        {
                            exportData.Add("sessions", raceData.sessions);
                        }
                        if (frmJsonSelector.ExportExtras)
                        {
                            exportData.Add("extras", raceData.extras);
                        }

                        string raceDataJson = JsonSerializer.Serialize(exportData);
                        writer.WriteLine(raceDataJson);
                    }
                }
                MessageBox.Show("Export data success.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to export data: " + ex.Message);
                // Si la ruta no esta definida obrira el metode per fer-ho
                defineExportRouteToolStripMenuItem_Click(sender, e);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private async void newRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show();
            Task oTask = new Task(Record);
            oTask.Start();
            await oTask;
            //Hide();
            
        }

        public void Record()
        {
            Thread.Sleep(3000);
        }

        public void Show()
        {
            recording = new Recording();
            //recording.Show();
        }

        public void Hide()
        {
            if (recording != null)
            {
                recording.Hide();
            }
        }
        /**
         *  Metode per quan s'entri a la "tab" Results faci la consulta a la base de dades i 
         *  mostri els ids de les carreres al comboBox (selector)
         */
        private async void tabPage2_Click(object sender, EventArgs e)
        {
            try
            {
                // Obte la llista de dades de "RaceData" 
                List<RaceData> raceList = await ddbbTools.GetRaceData();
                // Converteix els Race_id en Strings
                List<string> ids = raceList.Select(race => race._id.ToString()).ToList();
                // Assigna els ids com a selector del comboBox
                comboBoxRaceId.DataSource = ids;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error to load the race data: " + ex.Message);
            }
        }
        /**
         * Metode per gestionar l'esdeveniment SelectedIndexChanged per al comboBoxRaceId
         */
        private async void comboBoxRaceId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<RaceData> races = await ddbbTools.GetRaceData();
                ComboBox comboBox = sender as ComboBox;
                string selectedRaceId = (string)comboBox.SelectedItem;
                
                // Aquesta vegada busca la carrera que coincideix amb l'ID seleccionat
                RaceData race = races.First(r => r._id.ToString().Equals(selectedRaceId));
                // Crea una llista amb les dades de la carrera seleccionada
                List<string> datos = new List<string>()
                {
                "Track: " + race.track,
                "Number of sessions: " + race.number_of_sessions.ToString(),
                "Players",
                "Sessions",
                "Extras"
                };
                // L'hi envia la llista de dades per al listBox1
                listBox1.DataSource = datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error to load the race data: " + ex.Message);
            }
        }
        /**
         * Metode per gestionar l'esdeveniment SelectedIndexChanged per al listBox1
         */
        private async void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                // Convertim l'objecte que s'envia a ListBox
                ListBox listBox = sender as ListBox;
                // Verifiquem si l'element seleccionat és "Players"
                if (listBox.SelectedItem.Equals("Players"))
                {
                    subMenuSelectedType = "Players";
                    List<RaceData> races = await ddbbTools.GetRaceData();
                    string raceId = comboBoxRaceId.Text;
                    comboBoxSubMenu.DataSource =
                        races
                            .First(r => r._id.ToString().Equals(raceId))
                            .players
                            .Select(p => p.name)
                            .ToList();
                }
                else
                {
                    if (listBox.SelectedItem.Equals("Sessions"))
                    {
                        subMenuSelectedType = "Sessions";
                        List<RaceData> races = await ddbbTools.GetRaceData();
                        string raceId = comboBoxRaceId.Text;
                        comboBoxSubMenu.DataSource =
                            races
                                .First(r => r._id.ToString().Equals(raceId))
                                .sessions
                                .Select(p => p.name)
                                .ToList();
                    }
                    else
                    {
                        if (listBox.SelectedItem.Equals("Extras"))
                        {
                            subMenuSelectedType = "Extras";
                            List<RaceData> races = await ddbbTools.GetRaceData();
                            string raceId = comboBoxRaceId.Text;
                            comboBoxSubMenu.DataSource =
                                races
                                    .First(r => r._id.ToString().Equals(raceId))
                                    .extras
                                    .Select(p => p.name)
                                    .ToList();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error to load the race data: " + ex.Message);
            }
        }
        
        private async void listBoxSubMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
                ListBox listBox = sender as ListBox;
                if (subMenuSelectedType.Equals("Sessions")
                    && listBoxSubMenu.SelectedItem.Equals("Laps"))
                {
                    subMenu2SelectedType = "Laps";
                    List<RaceData> races = await ddbbTools.GetRaceData();
                    string raceId = comboBoxRaceId.Text;
                    comboBoxSubMenu2.DataSource =
                        races
                            .First(r => r._id.ToString().Equals(raceId))
                            .sessions
                            .First(s => s.name.Equals(comboBoxSubMenu.SelectedItem.ToString()))
                            .laps
                            .Select(l => l.lap)
                            .ToList();
                }
                else
                {
                    if (subMenuSelectedType.Equals("Sessions")
                        && listBoxSubMenu.SelectedItem.Equals("Best laps"))
                    {
                        subMenu2SelectedType = "Best laps";
                        List<RaceData> races = await ddbbTools.GetRaceData();
                        string raceId = comboBoxRaceId.Text;
                        comboBoxSubMenu2.DataSource =
                            races
                                .First(r => r._id.ToString().Equals(raceId))
                                .sessions
                                .First(s => s.name.Equals(comboBoxSubMenu.SelectedItem.ToString()))
                                .bestLaps
                                .Select(l => l.car)
                                .ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error to load the race data: " + ex.Message);
            }
        }

        private async void comboBoxSubMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<RaceData> races = await ddbbTools.GetRaceData();
                ComboBox comboBox = sender as ComboBox;

                RaceData race = races.First(r => r._id.ToString().Equals(comboBoxRaceId.SelectedItem.ToString()));
                if (subMenuSelectedType.Equals("Players"))
                {
                    Player player = race.players.First(p => p.name.Equals(comboBoxSubMenu.SelectedItem.ToString()));
                    List<string> datos = new List<string>()
                {
                    "Name: " + player.name,
                    "Car: " + player.car,
                    "Skin: " + player.skin
                };
                    listBoxSubMenu.DataSource = datos;
                }
                else
                {
                    if (subMenuSelectedType.Equals("Sessions"))
                    {

                        Session session = race.sessions.First(s => s.name.Equals(comboBoxSubMenu.SelectedItem.ToString()));
                        List<string> datos = new List<string>()
                    {
                        "Name: " + session.name,
                        "Type: " + Convert.ToString(session.type),
                        "Laps count: " + Convert.ToString(session.lapsCount),
                        "Duration: " + Convert.ToString(session.duration),
                        "Laps",
                        "Total laps: " + String.Join(", ", session.lapstotal),
                        "Best laps"
                    };
                        listBoxSubMenu.DataSource = datos;
                    }
                    else
                    {
                        if (subMenuSelectedType.Equals("Extras"))
                        {
                            Extra extra = race.extras.First(ex => ex.name.Equals(comboBoxSubMenu.SelectedItem.ToString()));
                            List<string> datos = new List<string>()
                        {
                            "Name: " + extra.name,
                            "GUID: " + extra.guid,
                            "Max: " + Convert.ToString(extra.max),
                            "Tier: " + Convert.ToString(extra.tier)
                        };
                            listBoxSubMenu.DataSource = datos;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error to load the race data: " + ex.Message);
            }
        }

        private async void listBoxSubMenu2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private async void comboBoxSubMenu2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<RaceData> races = await ddbbTools.GetRaceData();
                ComboBox comboBox = sender as ComboBox;

                RaceData race = races.First(r => r._id.ToString().Equals(comboBoxRaceId.SelectedItem.ToString()));
                if (subMenuSelectedType.Equals("Sessions") && subMenu2SelectedType.Equals("Laps"))
                {
                    Session session = race.sessions.First(p => p.name.Equals(comboBoxSubMenu.SelectedItem.ToString()));
                    Lap lap = session.laps.First(l => Convert.ToString(l.lap).Equals(comboBoxSubMenu2.SelectedItem.ToString()));
                    List<string> datos = new List<string>()
                {
                    "Lap: " + Convert.ToString(lap.lap),
                    "Car: " + Convert.ToString(lap.car),
                    "Sectors: " + String.Join(", ", lap.sectors),
                    "Time: " + Convert.ToString(lap.time),
                    "Cuts: " + Convert.ToString(lap.cuts),
                    "Tyre: " + lap.tyre
                };
                    listBoxSubMenu2.DataSource = datos;
                }
                else
                {
                    if (subMenuSelectedType.Equals("Sessions") && subMenu2SelectedType.Equals("Best laps"))
                    {
                        Session session = race.sessions.First(p => p.name.Equals(comboBoxSubMenu.SelectedItem.ToString()));
                        BestLap bestLap = session.bestLaps.First(l => Convert.ToString(l.car).Equals(comboBoxSubMenu2.SelectedItem.ToString()));
                        List<string> datos = new List<string>()
                    {
                        "Car: " + Convert.ToString(bestLap.car),
                        "Time: " + Convert.ToString(bestLap.time),
                        "Lap: " + String.Join(", ", bestLap.lap)
                    };
                        listBoxSubMenu2.DataSource = datos;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error to load the race data: " + ex.Message);
            }
        }
    }
}