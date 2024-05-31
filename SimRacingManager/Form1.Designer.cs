namespace SimRacingManager
{
    partial class SimRacingManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimRacingManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImportRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.exportRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defineExportRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabHome = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSubtittle = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelTittle = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelSelectLapBestLap = new System.Windows.Forms.Label();
            this.labelSelectPlayerSessionExtras = new System.Windows.Forms.Label();
            this.labelSelectTheRaceId = new System.Windows.Forms.Label();
            this.listBoxSubMenu2 = new System.Windows.Forms.ListBox();
            this.listBoxSubMenu = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBoxSubMenu2 = new System.Windows.Forms.ComboBox();
            this.comboBoxSubMenu = new System.Windows.Forms.ComboBox();
            this.comboBoxRaceId = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1414, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRecordToolStripMenuItem,
            this.btnImportRecord,
            this.exportRecordToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newRecordToolStripMenuItem
            // 
            this.newRecordToolStripMenuItem.Name = "newRecordToolStripMenuItem";
            this.newRecordToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.newRecordToolStripMenuItem.Text = "New record";
            this.newRecordToolStripMenuItem.Click += new System.EventHandler(this.newRecordToolStripMenuItem_Click);
            // 
            // btnImportRecord
            // 
            this.btnImportRecord.Name = "btnImportRecord";
            this.btnImportRecord.Size = new System.Drawing.Size(190, 26);
            this.btnImportRecord.Text = "Import record";
            this.btnImportRecord.Click += new System.EventHandler(this.btnImportRecord_Click);
            // 
            // exportRecordToolStripMenuItem
            // 
            this.exportRecordToolStripMenuItem.Name = "exportRecordToolStripMenuItem";
            this.exportRecordToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.exportRecordToolStripMenuItem.Text = "Export record";
            this.exportRecordToolStripMenuItem.Click += new System.EventHandler(this.exportRecordToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defineExportRouteToolStripMenuItem});
            this.settingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.settingToolStripMenuItem.Text = "Settings";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // defineExportRouteToolStripMenuItem
            // 
            this.defineExportRouteToolStripMenuItem.Name = "defineExportRouteToolStripMenuItem";
            this.defineExportRouteToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.defineExportRouteToolStripMenuItem.Text = "Define export route";
            this.defineExportRouteToolStripMenuItem.Click += new System.EventHandler(this.defineExportRouteToolStripMenuItem_Click);
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.tabPage1);
            this.tabHome.Controls.Add(this.tabPage2);
            this.tabHome.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHome.Location = new System.Drawing.Point(12, 30);
            this.tabHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHome.Name = "tabHome";
            this.tabHome.SelectedIndex = 0;
            this.tabHome.Size = new System.Drawing.Size(1392, 794);
            this.tabHome.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.labelSubtittle);
            this.tabPage1.Controls.Add(this.labelWelcome);
            this.tabPage1.Controls.Add(this.labelTittle);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1384, 764);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HOME";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(413, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(568, 490);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelSubtittle
            // 
            this.labelSubtittle.AutoSize = true;
            this.labelSubtittle.Font = new System.Drawing.Font("MS Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelSubtittle.Location = new System.Drawing.Point(359, 683);
            this.labelSubtittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubtittle.Name = "labelSubtittle";
            this.labelSubtittle.Size = new System.Drawing.Size(676, 60);
            this.labelSubtittle.TabIndex = 4;
            this.labelSubtittle.Text = "MANAGE YOUR RACE DATA";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("MS Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelWelcome.Location = new System.Drawing.Point(476, 27);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(444, 80);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "WELCOME TO";
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.Font = new System.Drawing.Font("MS Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelTittle.Location = new System.Drawing.Point(336, 107);
            this.labelTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(731, 80);
            this.labelTittle.TabIndex = 2;
            this.labelTittle.Text = "SIMRACING MANAGER";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelSelectLapBestLap);
            this.tabPage2.Controls.Add(this.labelSelectPlayerSessionExtras);
            this.tabPage2.Controls.Add(this.labelSelectTheRaceId);
            this.tabPage2.Controls.Add(this.listBoxSubMenu2);
            this.tabPage2.Controls.Add(this.listBoxSubMenu);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.comboBoxSubMenu2);
            this.tabPage2.Controls.Add(this.comboBoxSubMenu);
            this.tabPage2.Controls.Add(this.comboBoxRaceId);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1384, 764);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RESULTS";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // labelSelectLapBestLap
            // 
            this.labelSelectLapBestLap.AutoSize = true;
            this.labelSelectLapBestLap.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectLapBestLap.ForeColor = System.Drawing.Color.Black;
            this.labelSelectLapBestLap.Location = new System.Drawing.Point(946, 23);
            this.labelSelectLapBestLap.Name = "labelSelectLapBestLap";
            this.labelSelectLapBestLap.Size = new System.Drawing.Size(206, 23);
            this.labelSelectLapBestLap.TabIndex = 11;
            this.labelSelectLapBestLap.Text = "Select the lap or best laps";
            // 
            // labelSelectPlayerSessionExtras
            // 
            this.labelSelectPlayerSessionExtras.AutoSize = true;
            this.labelSelectPlayerSessionExtras.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectPlayerSessionExtras.ForeColor = System.Drawing.Color.Black;
            this.labelSelectPlayerSessionExtras.Location = new System.Drawing.Point(479, 23);
            this.labelSelectPlayerSessionExtras.Name = "labelSelectPlayerSessionExtras";
            this.labelSelectPlayerSessionExtras.Size = new System.Drawing.Size(269, 23);
            this.labelSelectPlayerSessionExtras.TabIndex = 10;
            this.labelSelectPlayerSessionExtras.Text = "Select the player, session or extras";
            // 
            // labelSelectTheRaceId
            // 
            this.labelSelectTheRaceId.AutoSize = true;
            this.labelSelectTheRaceId.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectTheRaceId.ForeColor = System.Drawing.Color.Black;
            this.labelSelectTheRaceId.Location = new System.Drawing.Point(19, 23);
            this.labelSelectTheRaceId.Name = "labelSelectTheRaceId";
            this.labelSelectTheRaceId.Size = new System.Drawing.Size(144, 23);
            this.labelSelectTheRaceId.TabIndex = 9;
            this.labelSelectTheRaceId.Text = "Select the race ID";
            // 
            // listBoxSubMenu2
            // 
            this.listBoxSubMenu2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSubMenu2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxSubMenu2.FormattingEnabled = true;
            this.listBoxSubMenu2.ItemHeight = 28;
            this.listBoxSubMenu2.Location = new System.Drawing.Point(950, 95);
            this.listBoxSubMenu2.Name = "listBoxSubMenu2";
            this.listBoxSubMenu2.Size = new System.Drawing.Size(383, 648);
            this.listBoxSubMenu2.TabIndex = 8;
            this.listBoxSubMenu2.SelectedIndexChanged += new System.EventHandler(this.listBoxSubMenu2_SelectedIndexChanged);
            // 
            // listBoxSubMenu
            // 
            this.listBoxSubMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSubMenu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxSubMenu.FormattingEnabled = true;
            this.listBoxSubMenu.ItemHeight = 28;
            this.listBoxSubMenu.Location = new System.Drawing.Point(483, 95);
            this.listBoxSubMenu.Name = "listBoxSubMenu";
            this.listBoxSubMenu.Size = new System.Drawing.Size(383, 648);
            this.listBoxSubMenu.TabIndex = 7;
            this.listBoxSubMenu.SelectedIndexChanged += new System.EventHandler(this.listBoxSubMenu_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(23, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(383, 648);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // comboBoxSubMenu2
            // 
            this.comboBoxSubMenu2.FormattingEnabled = true;
            this.comboBoxSubMenu2.Location = new System.Drawing.Point(950, 55);
            this.comboBoxSubMenu2.Name = "comboBoxSubMenu2";
            this.comboBoxSubMenu2.Size = new System.Drawing.Size(237, 25);
            this.comboBoxSubMenu2.TabIndex = 5;
            this.comboBoxSubMenu2.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubMenu2_SelectedIndexChanged);
            // 
            // comboBoxSubMenu
            // 
            this.comboBoxSubMenu.FormattingEnabled = true;
            this.comboBoxSubMenu.Location = new System.Drawing.Point(483, 55);
            this.comboBoxSubMenu.Name = "comboBoxSubMenu";
            this.comboBoxSubMenu.Size = new System.Drawing.Size(237, 25);
            this.comboBoxSubMenu.TabIndex = 4;
            this.comboBoxSubMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubMenu_SelectedIndexChanged);
            // 
            // comboBoxRaceId
            // 
            this.comboBoxRaceId.FormattingEnabled = true;
            this.comboBoxRaceId.Location = new System.Drawing.Point(23, 55);
            this.comboBoxRaceId.Name = "comboBoxRaceId";
            this.comboBoxRaceId.Size = new System.Drawing.Size(237, 25);
            this.comboBoxRaceId.TabIndex = 3;
            this.comboBoxRaceId.SelectedIndexChanged += new System.EventHandler(this.comboBoxRaceId_SelectedIndexChanged);
            // 
            // SimRacingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1414, 836);
            this.Controls.Add(this.tabHome);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "SimRacingManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimRacing Manager - MikiSastre";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabHome.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnImportRecord;
        private System.Windows.Forms.ToolStripMenuItem exportRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.TabControl tabHome;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem defineExportRouteToolStripMenuItem;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelSubtittle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxRaceId;
        private System.Windows.Forms.ComboBox comboBoxSubMenu;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBoxSubMenu;
        private System.Windows.Forms.ListBox listBoxSubMenu2;
        private System.Windows.Forms.Label labelSelectTheRaceId;
        private System.Windows.Forms.Label labelSelectPlayerSessionExtras;
        private System.Windows.Forms.Label labelSelectLapBestLap;
        private System.Windows.Forms.ComboBox comboBoxSubMenu2;
    }
}

