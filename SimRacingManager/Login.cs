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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLoginUsername.Text;
            string password = txtLoginPassword.Text;

            if (username == "admin" && password == "1234")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid user or password, please try again", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.StartPosition = FormStartPosition.CenterScreen;

            frmRegister.ShowDialog();
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                // Mostrar la contrassenya
                txtLoginPassword.PasswordChar = '\0'; // '\0' indica que no hi ha cap caracter de mascara
            }
            else
            {
                // Ocultar la contrassenya
                txtLoginPassword.PasswordChar = '*';
            }
        }
    }
}
