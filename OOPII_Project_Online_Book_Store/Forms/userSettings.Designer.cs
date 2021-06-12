﻿namespace StockExchange
{
    partial class userSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userSettings));
            this.pbSignUp = new System.Windows.Forms.PictureBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.pbShowPassword = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPasswordSingUp = new System.Windows.Forms.Label();
            this.lblUsernameSignUp = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSignUp
            // 
            this.pbSignUp.BackColor = System.Drawing.Color.Transparent;
            this.pbSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSignUp.Image = ((System.Drawing.Image)(resources.GetObject("pbSignUp.Image")));
            this.pbSignUp.Location = new System.Drawing.Point(254, 409);
            this.pbSignUp.Name = "pbSignUp";
            this.pbSignUp.Size = new System.Drawing.Size(74, 72);
            this.pbSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSignUp.TabIndex = 33;
            this.pbSignUp.TabStop = false;
            this.pbSignUp.Click += new System.EventHandler(this.pbSignUp_Click);
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(168, 208);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(256, 161);
            this.txtAdress.TabIndex = 29;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.BackColor = System.Drawing.Color.Transparent;
            this.lblAdress.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.Location = new System.Drawing.Point(45, 208);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(88, 24);
            this.lblAdress.TabIndex = 32;
            this.lblAdress.Text = "Adress";
            // 
            // pbShowPassword
            // 
            this.pbShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.pbShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbShowPassword.Image")));
            this.pbShowPassword.Location = new System.Drawing.Point(432, 126);
            this.pbShowPassword.Name = "pbShowPassword";
            this.pbShowPassword.Size = new System.Drawing.Size(33, 28);
            this.pbShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowPassword.TabIndex = 31;
            this.pbShowPassword.TabStop = false;
            this.pbShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbShowPassword_MouseDown);
            this.pbShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbShowPassword_MouseUp);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(168, 163);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(256, 26);
            this.txtEmail.TabIndex = 28;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(168, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(256, 26);
            this.txtPassword.TabIndex = 25;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(168, 85);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(256, 26);
            this.txtUsername.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(168, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 26);
            this.txtName.TabIndex = 19;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(56, 171);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(88, 23);
            this.lblMail.TabIndex = 26;
            this.lblMail.Text = "E-Mail";
            // 
            // lblPasswordSingUp
            // 
            this.lblPasswordSingUp.AutoSize = true;
            this.lblPasswordSingUp.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordSingUp.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordSingUp.Location = new System.Drawing.Point(32, 125);
            this.lblPasswordSingUp.Name = "lblPasswordSingUp";
            this.lblPasswordSingUp.Size = new System.Drawing.Size(114, 23);
            this.lblPasswordSingUp.TabIndex = 24;
            this.lblPasswordSingUp.Text = "Password";
            // 
            // lblUsernameSignUp
            // 
            this.lblUsernameSignUp.AutoSize = true;
            this.lblUsernameSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameSignUp.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameSignUp.Location = new System.Drawing.Point(28, 85);
            this.lblUsernameSignUp.Name = "lblUsernameSignUp";
            this.lblUsernameSignUp.Size = new System.Drawing.Size(114, 23);
            this.lblUsernameSignUp.TabIndex = 22;
            this.lblUsernameSignUp.Text = "Username";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(76, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 23);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdate.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(249, 500);
            this.lblUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(82, 23);
            this.lblUpdate.TabIndex = 34;
            this.lblUpdate.Text = "UPDATE";
            // 
            // userSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 560);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.pbSignUp);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.pbShowPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPasswordSingUp);
            this.Controls.Add(this.lblUsernameSignUp);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "userSettings";
            this.Text = "User Settings";
            this.Load += new System.EventHandler(this.userSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSignUp;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.PictureBox pbShowPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPasswordSingUp;
        private System.Windows.Forms.Label lblUsernameSignUp;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUpdate;
    }
}