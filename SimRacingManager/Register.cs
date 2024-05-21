using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SimRacingManager
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void linkToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void txtRegisterUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegisterPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegisterConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkbxShowPasRg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPasRg.Checked)
            {
                // Mostra la contrassenya
                txtRegisterPassword.PasswordChar = '\0'; // '\0' indica que no hi ha cap caracter de mascara
                txtRegisterConfirm.PasswordChar = '\0';
            }
            else
            {
                // Oculta la contrassenya
                txtRegisterPassword.PasswordChar = '*';
                txtRegisterConfirm.PasswordChar = '*';
            }
        }

        /**
         * Dades del Register per enviar a DB
         */
        private async void btnSubmit_Click(object sender, EventArgs e)
        {   
            // Guardem les dades rebudes en strings
            string username = txtRegisterUsername.Text;
            string password = txtRegisterPassword.Text;
            string confirm = txtRegisterConfirm.Text;

            // Comprovem si la contrassenya coincideix
            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match. Try again.");
                return;
            }

            // Creem l'instancia a DDBBTools
            DDBBTools ddbbTools = new DDBBTools();

            // Creem el document per nous usuaris
            BsonDocument newUser = new BsonDocument
            {
                {"username", username},
                {"password", password}
            };

            // Insertem el document a la collecció users
            await ddbbTools.InsertDocumentAsync("users", newUser);

            // Mostrem un missatge conforme s'ha creat l'usuari
            MessageBox.Show("Successful registration. Now you can log in.");
            this.Close();
        }

        private void btnRegisterClear_Click(object sender, EventArgs e)
        {
            //Netejarem les dades que hi hagi
            txtRegisterUsername.Text = "";
            txtRegisterPassword.Text = "";
            txtRegisterConfirm.Text = "";
        }
    }
}
