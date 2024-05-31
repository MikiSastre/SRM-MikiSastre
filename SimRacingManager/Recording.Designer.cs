namespace SimRacingManager
{
    partial class Recording
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
            this.components = new System.ComponentModel.Container();
            this.timerRecording = new System.Windows.Forms.Timer(this.components);
            this.gifRecording = new System.Windows.Forms.PictureBox();
            this.labelRecordingNow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gifRecording)).BeginInit();
            this.SuspendLayout();
            // 
            // gifRecording
            // 
            this.gifRecording.Location = new System.Drawing.Point(12, 12);
            this.gifRecording.Name = "gifRecording";
            this.gifRecording.Size = new System.Drawing.Size(713, 401);
            this.gifRecording.TabIndex = 0;
            this.gifRecording.TabStop = false;
            // 
            // labelRecordingNow
            // 
            this.labelRecordingNow.AutoSize = true;
            this.labelRecordingNow.Font = new System.Drawing.Font("MS Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecordingNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelRecordingNow.Location = new System.Drawing.Point(232, 249);
            this.labelRecordingNow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecordingNow.Name = "labelRecordingNow";
            this.labelRecordingNow.Size = new System.Drawing.Size(257, 37);
            this.labelRecordingNow.TabIndex = 2;
            this.labelRecordingNow.Text = "RECORDING...";
            // 
            // Recording
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 305);
            this.Controls.Add(this.labelRecordingNow);
            this.Controls.Add(this.gifRecording);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recording";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recording";
            this.Load += new System.EventHandler(this.Recording_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gifRecording)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerRecording;
        private System.Windows.Forms.PictureBox gifRecording;
        private System.Windows.Forms.Label labelRecordingNow;
    }
}