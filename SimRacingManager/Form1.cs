using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimRacingManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load_1(object sender, EventArgs e)
        {
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

        private void newCompetitionToolStripMenuItem_Click(object sender, EventArgs e)
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
                DDBBTools ddbbTools = new DDBBTools();

                // Inserta les dades de la carrera  des del arxiu JSON a la base de dades
                await ddbbTools.InsertRaceDataFromJsonAsync(filePath);

                MessageBox.Show("Dades importades correctament.");
            }
        }
        
    }
}
