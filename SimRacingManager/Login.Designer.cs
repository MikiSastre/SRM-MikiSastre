namespace SimRacingManager
{
    partial class frmLogin
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelLoginUsername = new System.Windows.Forms.Label();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.checkbxShowPas = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("MS Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelLogin.Location = new System.Drawing.Point(88, 33);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(134, 43);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "LOGIN";
            // 
            // labelLoginUsername
            // 
            this.labelLoginUsername.AutoSize = true;
            this.labelLoginUsername.Location = new System.Drawing.Point(30, 139);
            this.labelLoginUsername.Name = "labelLoginUsername";
            this.labelLoginUsername.Size = new System.Drawing.Size(89, 23);
            this.labelLoginUsername.TabIndex = 1;
            this.labelLoginUsername.Text = "Username";
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtLoginUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginUsername.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUsername.Location = new System.Drawing.Point(34, 178);
            this.txtLoginUsername.Multiline = true;
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(244, 28);
            this.txtLoginUsername.TabIndex = 2;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginPassword.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPassword.Location = new System.Drawing.Point(34, 265);
            this.txtLoginPassword.Multiline = true;
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(244, 28);
            this.txtLoginPassword.TabIndex = 4;
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.Location = new System.Drawing.Point(30, 226);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(84, 23);
            this.labelLoginPassword.TabIndex = 3;
            this.labelLoginPassword.Text = "Password";
            // 
            // checkbxShowPas
            // 
            this.checkbxShowPas.AutoSize = true;
            this.checkbxShowPas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbxShowPas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbxShowPas.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbxShowPas.Location = new System.Drawing.Point(161, 299);
            this.checkbxShowPas.Name = "checkbxShowPas";
            this.checkbxShowPas.Size = new System.Drawing.Size(117, 21);
            this.checkbxShowPas.TabIndex = 5;
            this.checkbxShowPas.Text = "Show Password";
            this.checkbxShowPas.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(34, 339);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(244, 40);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnClear.Location = new System.Drawing.Point(34, 394);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(244, 40);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(312, 498);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.checkbxShowPas);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.labelLoginPassword);
            this.Controls.Add(this.txtLoginUsername);
            this.Controls.Add(this.labelLoginUsername);
            this.Controls.Add(this.labelLogin);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.Text = "SRM-Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelLoginUsername;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.CheckBox checkbxShowPas;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;
    }
}