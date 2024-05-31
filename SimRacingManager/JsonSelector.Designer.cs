namespace SimRacingManager
{
    partial class frmJsonSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelJsonSelector = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkBoxTrack = new System.Windows.Forms.CheckBox();
            this.checkBoxNumSessions = new System.Windows.Forms.CheckBox();
            this.checkBoxPlayers = new System.Windows.Forms.CheckBox();
            this.checkBoxSessions = new System.Windows.Forms.CheckBox();
            this.checkBoxExtras = new System.Windows.Forms.CheckBox();
            this.btnJsonSubmit = new System.Windows.Forms.Button();
            this.checkBoxRaceId = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelJsonSelector
            // 
            this.labelJsonSelector.AutoSize = true;
            this.labelJsonSelector.Font = new System.Drawing.Font("MS Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJsonSelector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelJsonSelector.Location = new System.Drawing.Point(20, 19);
            this.labelJsonSelector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJsonSelector.Name = "labelJsonSelector";
            this.labelJsonSelector.Size = new System.Drawing.Size(277, 37);
            this.labelJsonSelector.TabIndex = 1;
            this.labelJsonSelector.Text = "JSON SELECTOR";
            // 
            // checkBoxTrack
            // 
            this.checkBoxTrack.AutoSize = true;
            this.checkBoxTrack.Location = new System.Drawing.Point(33, 124);
            this.checkBoxTrack.Name = "checkBoxTrack";
            this.checkBoxTrack.Size = new System.Drawing.Size(75, 27);
            this.checkBoxTrack.TabIndex = 3;
            this.checkBoxTrack.Text = "Track";
            this.checkBoxTrack.UseVisualStyleBackColor = true;
            this.checkBoxTrack.CheckedChanged += new System.EventHandler(this.checkBoxTrack_CheckedChanged);
            // 
            // checkBoxNumSessions
            // 
            this.checkBoxNumSessions.AutoSize = true;
            this.checkBoxNumSessions.Location = new System.Drawing.Point(33, 157);
            this.checkBoxNumSessions.Name = "checkBoxNumSessions";
            this.checkBoxNumSessions.Size = new System.Drawing.Size(187, 27);
            this.checkBoxNumSessions.TabIndex = 4;
            this.checkBoxNumSessions.Text = "Number of sessions";
            this.checkBoxNumSessions.UseVisualStyleBackColor = true;
            this.checkBoxNumSessions.CheckedChanged += new System.EventHandler(this.checkBoxNumSessions_CheckedChanged);
            // 
            // checkBoxPlayers
            // 
            this.checkBoxPlayers.AutoSize = true;
            this.checkBoxPlayers.Location = new System.Drawing.Point(33, 190);
            this.checkBoxPlayers.Name = "checkBoxPlayers";
            this.checkBoxPlayers.Size = new System.Drawing.Size(88, 27);
            this.checkBoxPlayers.TabIndex = 5;
            this.checkBoxPlayers.Text = "Players";
            this.checkBoxPlayers.UseVisualStyleBackColor = true;
            this.checkBoxPlayers.CheckedChanged += new System.EventHandler(this.checkBoxPlayers_CheckedChanged);
            // 
            // checkBoxSessions
            // 
            this.checkBoxSessions.AutoSize = true;
            this.checkBoxSessions.Location = new System.Drawing.Point(33, 223);
            this.checkBoxSessions.Name = "checkBoxSessions";
            this.checkBoxSessions.Size = new System.Drawing.Size(97, 27);
            this.checkBoxSessions.TabIndex = 6;
            this.checkBoxSessions.Text = "Sessions";
            this.checkBoxSessions.UseVisualStyleBackColor = true;
            this.checkBoxSessions.CheckedChanged += new System.EventHandler(this.checkBoxSessions_CheckedChanged);
            // 
            // checkBoxExtras
            // 
            this.checkBoxExtras.AutoSize = true;
            this.checkBoxExtras.Location = new System.Drawing.Point(33, 256);
            this.checkBoxExtras.Name = "checkBoxExtras";
            this.checkBoxExtras.Size = new System.Drawing.Size(80, 27);
            this.checkBoxExtras.TabIndex = 7;
            this.checkBoxExtras.Text = "Extras";
            this.checkBoxExtras.UseVisualStyleBackColor = true;
            this.checkBoxExtras.CheckedChanged += new System.EventHandler(this.checkBoxExtras_CheckedChanged);
            // 
            // btnJsonSubmit
            // 
            this.btnJsonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnJsonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJsonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJsonSubmit.ForeColor = System.Drawing.Color.White;
            this.btnJsonSubmit.Location = new System.Drawing.Point(33, 311);
            this.btnJsonSubmit.Name = "btnJsonSubmit";
            this.btnJsonSubmit.Size = new System.Drawing.Size(244, 40);
            this.btnJsonSubmit.TabIndex = 9;
            this.btnJsonSubmit.Text = "SUBMIT";
            this.btnJsonSubmit.UseVisualStyleBackColor = false;
            this.btnJsonSubmit.Click += new System.EventHandler(this.btnJsonSubmit_Click);
            // 
            // checkBoxRaceId
            // 
            this.checkBoxRaceId.AutoSize = true;
            this.checkBoxRaceId.Location = new System.Drawing.Point(33, 91);
            this.checkBoxRaceId.Name = "checkBoxRaceId";
            this.checkBoxRaceId.Size = new System.Drawing.Size(92, 27);
            this.checkBoxRaceId.TabIndex = 10;
            this.checkBoxRaceId.Text = "Race ID";
            this.checkBoxRaceId.UseVisualStyleBackColor = true;
            this.checkBoxRaceId.CheckedChanged += new System.EventHandler(this.checkBoxRaceId_CheckedChanged_1);
            // 
            // frmJsonSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(310, 381);
            this.Controls.Add(this.checkBoxRaceId);
            this.Controls.Add(this.btnJsonSubmit);
            this.Controls.Add(this.checkBoxExtras);
            this.Controls.Add(this.checkBoxSessions);
            this.Controls.Add(this.checkBoxPlayers);
            this.Controls.Add(this.checkBoxNumSessions);
            this.Controls.Add(this.checkBoxTrack);
            this.Controls.Add(this.labelJsonSelector);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmJsonSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JsonSelector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelJsonSelector;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox checkBoxTrack;
        private System.Windows.Forms.CheckBox checkBoxNumSessions;
        private System.Windows.Forms.CheckBox checkBoxPlayers;
        private System.Windows.Forms.CheckBox checkBoxSessions;
        private System.Windows.Forms.CheckBox checkBoxExtras;
        private System.Windows.Forms.Button btnJsonSubmit;
        private System.Windows.Forms.CheckBox checkBoxRaceId;
    }
}