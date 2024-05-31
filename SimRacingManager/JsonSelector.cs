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
    public partial class frmJsonSelector : Form
    {
        public bool ExportRaceId { get; private set; }
        public bool ExportTrack { get; private set; }
        public bool ExportNumSessions { get; private set; }
        public bool ExportPlayers { get; private set; }
        public bool ExportSessions { get; private set; }
        public bool ExportExtras { get; private set; }

        public frmJsonSelector()
        {
            InitializeComponent();
        }

        private void checkBoxRaceId_CheckedChanged_1(object sender, EventArgs e)
        {
            ExportRaceId = ((CheckBox)sender).Checked;
        }
        private void checkBoxTrack_CheckedChanged(object sender, EventArgs e)
        {
            ExportTrack = ((CheckBox)sender).Checked;
        }

        private void checkBoxNumSessions_CheckedChanged(object sender, EventArgs e)
        {
            ExportNumSessions = ((CheckBox)sender).Checked;
        }

        private void checkBoxPlayers_CheckedChanged(object sender, EventArgs e)
        {
            ExportPlayers = ((CheckBox)sender).Checked;
        }

        private void checkBoxSessions_CheckedChanged(object sender, EventArgs e)
        {
            ExportSessions = ((CheckBox)sender).Checked;
        }

        private void checkBoxExtras_CheckedChanged(object sender, EventArgs e)
        {
            ExportExtras = ((CheckBox)sender).Checked;
        }

        private void btnJsonSubmit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
