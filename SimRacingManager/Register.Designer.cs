namespace SimRacingManager
{
    partial class frmRegister
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
            this.labelRegister = new System.Windows.Forms.Label();
            this.labelRegisterUsername = new System.Windows.Forms.Label();
            this.txtRegisterUsername = new System.Windows.Forms.TextBox();
            this.labelRegisterPassword = new System.Windows.Forms.Label();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("MS Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelRegister.Location = new System.Drawing.Point(48, 34);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(203, 43);
            this.labelRegister.TabIndex = 1;
            this.labelRegister.Text = "REGISTER";
            // 
            // labelRegisterUsername
            // 
            this.labelRegisterUsername.AutoSize = true;
            this.labelRegisterUsername.Location = new System.Drawing.Point(24, 127);
            this.labelRegisterUsername.Name = "labelRegisterUsername";
            this.labelRegisterUsername.Size = new System.Drawing.Size(89, 23);
            this.labelRegisterUsername.TabIndex = 2;
            this.labelRegisterUsername.Text = "Username";
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtRegisterUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegisterUsername.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterUsername.Location = new System.Drawing.Point(28, 153);
            this.txtRegisterUsername.Multiline = true;
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(244, 28);
            this.txtRegisterUsername.TabIndex = 3;
            // 
            // labelRegisterPassword
            // 
            this.labelRegisterPassword.AutoSize = true;
            this.labelRegisterPassword.Location = new System.Drawing.Point(24, 204);
            this.labelRegisterPassword.Name = "labelRegisterPassword";
            this.labelRegisterPassword.Size = new System.Drawing.Size(84, 23);
            this.labelRegisterPassword.TabIndex = 4;
            this.labelRegisterPassword.Text = "Password";
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtRegisterPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegisterPassword.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterPassword.Location = new System.Drawing.Point(34, 235);
            this.txtRegisterPassword.Multiline = true;
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.PasswordChar = '*';
            this.txtRegisterPassword.Size = new System.Drawing.Size(244, 28);
            this.txtRegisterPassword.TabIndex = 5;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(312, 498);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.labelRegisterPassword);
            this.Controls.Add(this.txtRegisterUsername);
            this.Controls.Add(this.labelRegisterUsername);
            this.Controls.Add(this.labelRegister);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRegister";
            this.Text = "SRM-Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Label labelRegisterUsername;
        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.Label labelRegisterPassword;
        private System.Windows.Forms.TextBox txtRegisterPassword;
    }
}