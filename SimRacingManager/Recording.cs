﻿using System;
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
    public partial class Recording : Form
    {
        public Recording()
        {
            InitializeComponent();
        }

        private void Recording_Load(object sender, EventArgs e)
        {
            gifRecording.Load("recording.gif");
            gifRecording.Location = new Point(this.Width / 2 - gifRecording.Width / 2,
                this.Height / 2 - gifRecording.Width / 2);
        }
    }
}
