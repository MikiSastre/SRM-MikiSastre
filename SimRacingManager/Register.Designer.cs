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
            this.labelRegisterConfirm = new System.Windows.Forms.Label();
            this.txtRegisterConfirm = new System.Windows.Forms.TextBox();
            this.checkbxShowPasRg = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnRegisterClear = new System.Windows.Forms.Button();
            this.labelYesAccount = new System.Windows.Forms.Label();
            this.linkToLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("MS Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelRegister.Location = new System.Drawing.Point(52, 30);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(203, 43);
            this.labelRegister.TabIndex = 0;
            this.labelRegister.Text = "REGISTER";
            // 
            // labelRegisterUsername
            // 
            this.labelRegisterUsername.AutoSize = true;
            this.labelRegisterUsername.Location = new System.Drawing.Point(27, 92);
            this.labelRegisterUsername.Name = "labelRegisterUsername";
            this.labelRegisterUsername.Size = new System.Drawing.Size(89, 23);
            this.labelRegisterUsername.TabIndex = 1;
            this.labelRegisterUsername.Text = "Username";
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtRegisterUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegisterUsername.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterUsername.Location = new System.Drawing.Point(31, 118);
            this.txtRegisterUsername.Multiline = true;
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(244, 28);
            this.txtRegisterUsername.TabIndex = 2;
            this.txtRegisterUsername.TextChanged += new System.EventHandler(this.txtRegisterUsername_TextChanged);
            // 
            // labelRegisterPassword
            // 
            this.labelRegisterPassword.AutoSize = true;
            this.labelRegisterPassword.Location = new System.Drawing.Point(27, 158);
            this.labelRegisterPassword.Name = "labelRegisterPassword";
            this.labelRegisterPassword.Size = new System.Drawing.Size(84, 23);
            this.labelRegisterPassword.TabIndex = 3;
            this.labelRegisterPassword.Text = "Password";
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtRegisterPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegisterPassword.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterPassword.Location = new System.Drawing.Point(31, 184);
            this.txtRegisterPassword.Multiline = true;
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.PasswordChar = '*';
            this.txtRegisterPassword.Size = new System.Drawing.Size(244, 28);
            this.txtRegisterPassword.TabIndex = 4;
            this.txtRegisterPassword.TextChanged += new System.EventHandler(this.txtRegisterPassword_TextChanged);
            // 
            // labelRegisterConfirm
            // 
            this.labelRegisterConfirm.AutoSize = true;
            this.labelRegisterConfirm.Location = new System.Drawing.Point(27, 226);
            this.labelRegisterConfirm.Name = "labelRegisterConfirm";
            this.labelRegisterConfirm.Size = new System.Drawing.Size(155, 23);
            this.labelRegisterConfirm.TabIndex = 5;
            this.labelRegisterConfirm.Text = "Confirm Password";
            // 
            // txtRegisterConfirm
            // 
            this.txtRegisterConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtRegisterConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegisterConfirm.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterConfirm.Location = new System.Drawing.Point(31, 252);
            this.txtRegisterConfirm.Multiline = true;
            this.txtRegisterConfirm.Name = "txtRegisterConfirm";
            this.txtRegisterConfirm.PasswordChar = '*';
            this.txtRegisterConfirm.Size = new System.Drawing.Size(244, 28);
            this.txtRegisterConfirm.TabIndex = 6;
            this.txtRegisterConfirm.TextChanged += new System.EventHandler(this.txtRegisterConfirm_TextChanged);
            // 
            // checkbxShowPasRg
            // 
            this.checkbxShowPasRg.AutoSize = true;
            this.checkbxShowPasRg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbxShowPasRg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbxShowPasRg.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbxShowPasRg.Location = new System.Drawing.Point(158, 286);
            this.checkbxShowPasRg.Name = "checkbxShowPasRg";
            this.checkbxShowPasRg.Size = new System.Drawing.Size(117, 21);
            this.checkbxShowPasRg.TabIndex = 7;
            this.checkbxShowPasRg.Text = "Show Password";
            this.checkbxShowPasRg.UseVisualStyleBackColor = true;
            this.checkbxShowPasRg.CheckedChanged += new System.EventHandler(this.checkbxShowPasRg_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(31, 313);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(244, 40);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnRegisterClear
            // 
            this.btnRegisterClear.BackColor = System.Drawing.Color.White;
            this.btnRegisterClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnRegisterClear.Location = new System.Drawing.Point(31, 370);
            this.btnRegisterClear.Name = "btnRegisterClear";
            this.btnRegisterClear.Size = new System.Drawing.Size(244, 40);
            this.btnRegisterClear.TabIndex = 9;
            this.btnRegisterClear.Text = "CLEAR";
            this.btnRegisterClear.UseVisualStyleBackColor = false;
            this.btnRegisterClear.Click += new System.EventHandler(this.btnRegisterClear_Click);
            // 
            // labelYesAccount
            // 
            this.labelYesAccount.AutoSize = true;
            this.labelYesAccount.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYesAccount.Location = new System.Drawing.Point(38, 426);
            this.labelYesAccount.Name = "labelYesAccount";
            this.labelYesAccount.Size = new System.Drawing.Size(268, 23);
            this.labelYesAccount.TabIndex = 10;
            this.labelYesAccount.Text = "Did you already have an account?";
            // 
            // linkToLogin
            // 
            this.linkToLogin.AutoSize = true;
            this.linkToLogin.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkToLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.linkToLogin.Location = new System.Drawing.Point(101, 457);
            this.linkToLogin.Name = "linkToLogin";
            this.linkToLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkToLogin.Size = new System.Drawing.Size(106, 23);
            this.linkToLogin.TabIndex = 11;
            this.linkToLogin.TabStop = true;
            this.linkToLogin.Text = "Log in here!";
            this.linkToLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkToLogin.VisitedLinkColor = System.Drawing.Color.Navy;
            this.linkToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToLogin_LinkClicked);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(312, 498);
            this.Controls.Add(this.linkToLogin);
            this.Controls.Add(this.labelYesAccount);
            this.Controls.Add(this.btnRegisterClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.checkbxShowPasRg);
            this.Controls.Add(this.txtRegisterConfirm);
            this.Controls.Add(this.labelRegisterConfirm);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.labelRegisterPassword);
            this.Controls.Add(this.txtRegisterUsername);
            this.Controls.Add(this.labelRegisterUsername);
            this.Controls.Add(this.labelRegister);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.Label labelRegisterConfirm;
        private System.Windows.Forms.TextBox txtRegisterConfirm;
        private System.Windows.Forms.CheckBox checkbxShowPasRg;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnRegisterClear;
        private System.Windows.Forms.Label labelYesAccount;
        private System.Windows.Forms.LinkLabel linkToLogin;
    }
}