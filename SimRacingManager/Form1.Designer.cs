namespace SimRacingManager
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCompetitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImportRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.exportRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabHome = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1419, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCompetitionToolStripMenuItem,
            this.newRecordToolStripMenuItem,
            this.btnImportRecord,
            this.exportRecordToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.fileToolStripMenuItem.Text = " File";
            // 
            // newCompetitionToolStripMenuItem
            // 
            this.newCompetitionToolStripMenuItem.Name = "newCompetitionToolStripMenuItem";
            this.newCompetitionToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.newCompetitionToolStripMenuItem.Text = "New competition";
            this.newCompetitionToolStripMenuItem.Click += new System.EventHandler(this.newCompetitionToolStripMenuItem_Click);
            // 
            // newRecordToolStripMenuItem
            // 
            this.newRecordToolStripMenuItem.Name = "newRecordToolStripMenuItem";
            this.newRecordToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.newRecordToolStripMenuItem.Text = "New record";
            // 
            // btnImportRecord
            // 
            this.btnImportRecord.Name = "btnImportRecord";
            this.btnImportRecord.Size = new System.Drawing.Size(207, 26);
            this.btnImportRecord.Text = "Import record";
            this.btnImportRecord.Click += new System.EventHandler(this.btnImportRecord_Click);
            // 
            // exportRecordToolStripMenuItem
            // 
            this.exportRecordToolStripMenuItem.Name = "exportRecordToolStripMenuItem";
            this.exportRecordToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.exportRecordToolStripMenuItem.Text = "Export record";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingToolStripMenuItem.Text = "Settings";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.tabPage1);
            this.tabHome.Controls.Add(this.tabPage2);
            this.tabHome.Location = new System.Drawing.Point(12, 31);
            this.tabHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHome.Name = "tabHome";
            this.tabHome.SelectedIndex = 0;
            this.tabHome.Size = new System.Drawing.Size(1392, 794);
            this.tabHome.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1384, 765);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HOME";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1384, 765);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RESULTS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1348, 696);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 838);
            this.Controls.Add(this.tabHome);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabHome.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCompetitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnImportRecord;
        private System.Windows.Forms.ToolStripMenuItem exportRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.TabControl tabHome;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

