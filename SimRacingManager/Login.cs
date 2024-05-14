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

        private void btnLogin(object sender, EventArgs e)
        {
            string username = txtLoginUsername.Text;
            string password = txtLoginPassword.Text;

            // Aquí debes agregar la lógica para verificar las credenciales
            if (username == "admin" && password == "admin")
            {
                // Si las credenciales son correctas, cierra el formulario de inicio de sesión
                // y establece el resultado de DialogResult en OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Si las credenciales son incorrectas, muestra un mensaje de error al usuario
                MessageBox.Show("Credenciales incorrectas. Por favor, inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
