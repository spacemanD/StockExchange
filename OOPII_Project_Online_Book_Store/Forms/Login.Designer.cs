namespace StockExchange
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbRemind = new System.Windows.Forms.CheckBox();
            this.pbBook = new System.Windows.Forms.PictureBox();
            this.S = new System.Windows.Forms.Label();
            this.lblSıgnUp = new System.Windows.Forms.Label();
            this.pbShowPassword = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(73, 151);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(114, 24);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(73, 199);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(114, 24);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(188, 151);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(112, 26);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(188, 198);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(112, 26);
            this.txtPassword.TabIndex = 4;
            // 
            // cbRemind
            // 
            this.cbRemind.AutoSize = true;
            this.cbRemind.BackColor = System.Drawing.Color.Transparent;
            this.cbRemind.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRemind.Location = new System.Drawing.Point(78, 238);
            this.cbRemind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRemind.Name = "cbRemind";
            this.cbRemind.Size = new System.Drawing.Size(145, 23);
            this.cbRemind.TabIndex = 6;
            this.cbRemind.Text = "Remind Me?";
            this.cbRemind.UseVisualStyleBackColor = false;
            // 
            // pbBook
            // 
            this.pbBook.BackColor = System.Drawing.Color.Transparent;
            this.pbBook.Image = ((System.Drawing.Image)(resources.GetObject("pbBook.Image")));
            this.pbBook.Location = new System.Drawing.Point(126, 31);
            this.pbBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBook.Name = "pbBook";
            this.pbBook.Size = new System.Drawing.Size(129, 91);
            this.pbBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBook.TabIndex = 8;
            this.pbBook.TabStop = false;
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.BackColor = System.Drawing.Color.Transparent;
            this.S.Cursor = System.Windows.Forms.Cursors.Hand;
            this.S.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S.Location = new System.Drawing.Point(93, 431);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(218, 23);
            this.S.TabIndex = 9;
            this.S.Text = "Forgot Password?";
            this.S.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // lblSıgnUp
            // 
            this.lblSıgnUp.AutoSize = true;
            this.lblSıgnUp.BackColor = System.Drawing.Color.Transparent;
            this.lblSıgnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSıgnUp.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSıgnUp.Location = new System.Drawing.Point(140, 388);
            this.lblSıgnUp.Name = "lblSıgnUp";
            this.lblSıgnUp.Size = new System.Drawing.Size(101, 24);
            this.lblSıgnUp.TabIndex = 10;
            this.lblSıgnUp.Text = "SIGN UP";
            this.lblSıgnUp.Click += new System.EventHandler(this.lblSıgnUp_Click);
            // 
            // pbShowPassword
            // 
            this.pbShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.pbShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbShowPassword.Image")));
            this.pbShowPassword.Location = new System.Drawing.Point(307, 198);
            this.pbShowPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbShowPassword.Name = "pbShowPassword";
            this.pbShowPassword.Size = new System.Drawing.Size(40, 28);
            this.pbShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowPassword.TabIndex = 12;
            this.pbShowPassword.TabStop = false;
            this.pbShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbShowPassword_MouseDown);
            this.pbShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbShowPassword_MouseUp);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(144, 288);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(78, 80);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // loginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 518);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pbShowPassword);
            this.Controls.Add(this.lblSıgnUp);
            this.Controls.Add(this.S);
            this.Controls.Add(this.pbBook);
            this.Controls.Add(this.cbRemind);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.ForeColor = System.Drawing.Color.FloralWhite;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.loginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox cbRemind;
        private System.Windows.Forms.PictureBox pbBook;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Label lblSıgnUp;
        private System.Windows.Forms.PictureBox pbShowPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}

