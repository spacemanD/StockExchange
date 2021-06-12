namespace StockExchange
{
    partial class BondsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BondsForm));
            this.pbmusicCD = new System.Windows.Forms.PictureBox();
            this.nudmussicCD = new System.Windows.Forms.NumericUpDown();
            this.btnpurchase = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbmusicCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudmussicCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbmusicCD
            // 
            this.pbmusicCD.BackColor = System.Drawing.Color.Transparent;
            this.pbmusicCD.Location = new System.Drawing.Point(15, 52);
            this.pbmusicCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbmusicCD.Name = "pbmusicCD";
            this.pbmusicCD.Size = new System.Drawing.Size(222, 283);
            this.pbmusicCD.TabIndex = 0;
            this.pbmusicCD.TabStop = false;
            // 
            // nudmussicCD
            // 
            this.nudmussicCD.Location = new System.Drawing.Point(870, 411);
            this.nudmussicCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudmussicCD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudmussicCD.Name = "nudmussicCD";
            this.nudmussicCD.Size = new System.Drawing.Size(96, 26);
            this.nudmussicCD.TabIndex = 1;
            this.nudmussicCD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnpurchase
            // 
            this.btnpurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnpurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpurchase.FlatAppearance.BorderSize = 0;
            this.btnpurchase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnpurchase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnpurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpurchase.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpurchase.Image = ((System.Drawing.Image)(resources.GetObject("btnpurchase.Image")));
            this.btnpurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpurchase.Location = new System.Drawing.Point(774, 449);
            this.btnpurchase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnpurchase.Name = "btnpurchase";
            this.btnpurchase.Size = new System.Drawing.Size(262, 115);
            this.btnpurchase.TabIndex = 2;
            this.btnpurchase.Text = "Add to Cart";
            this.btnpurchase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpurchase.UseVisualStyleBackColor = false;
            this.btnpurchase.Click += new System.EventHandler(this.btnpurchase_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(12, 397);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(88, 23);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Name: ";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.BackColor = System.Drawing.Color.Transparent;
            this.lbltype.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.Location = new System.Drawing.Point(12, 449);
            this.lbltype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(88, 23);
            this.lbltype.TabIndex = 4;
            this.lbltype.Text = "Type: ";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.Color.Transparent;
            this.lblprice.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(12, 503);
            this.lblprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(101, 23);
            this.lblprice.TabIndex = 5;
            this.lblprice.Text = "Price: ";
            // 
            // txtIssue
            // 
            this.txtIssue.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtIssue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIssue.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssue.Location = new System.Drawing.Point(328, 326);
            this.txtIssue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIssue.Multiline = true;
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.ReadOnly = true;
            this.txtIssue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIssue.Size = new System.Drawing.Size(436, 422);
            this.txtIssue.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(328, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BondsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 752);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtIssue);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnpurchase);
            this.Controls.Add(this.nudmussicCD);
            this.Controls.Add(this.pbmusicCD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BondsForm";
            this.Text = "BondsForm";
            this.Load += new System.EventHandler(this.BondsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbmusicCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudmussicCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbmusicCD;
        private System.Windows.Forms.NumericUpDown nudmussicCD;
        private System.Windows.Forms.Button btnpurchase;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}