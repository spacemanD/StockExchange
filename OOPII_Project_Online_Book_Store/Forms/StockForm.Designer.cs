namespace StockExchange
{
    partial class StockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockForm));
            this.lblStockName = new System.Windows.Forms.Label();
            this.lblStockPrice = new System.Windows.Forms.Label();
            this.picbxStockPicture = new System.Windows.Forms.PictureBox();
            this.nudPurchase = new System.Windows.Forms.NumericUpDown();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbxStockPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStockName
            // 
            this.lblStockName.AutoSize = true;
            this.lblStockName.BackColor = System.Drawing.Color.Transparent;
            this.lblStockName.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockName.Location = new System.Drawing.Point(48, 378);
            this.lblStockName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(98, 17);
            this.lblStockName.TabIndex = 0;
            this.lblStockName.Text = "StockName";
            // 
            // lblStockPrice
            // 
            this.lblStockPrice.AutoSize = true;
            this.lblStockPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblStockPrice.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockPrice.Location = new System.Drawing.Point(50, 585);
            this.lblStockPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockPrice.Name = "lblStockPrice";
            this.lblStockPrice.Size = new System.Drawing.Size(118, 17);
            this.lblStockPrice.TabIndex = 1;
            this.lblStockPrice.Text = "StockPrice:";
            // 
            // picbxStockPicture
            // 
            this.picbxStockPicture.BackColor = System.Drawing.Color.Transparent;
            this.picbxStockPicture.Location = new System.Drawing.Point(51, 48);
            this.picbxStockPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picbxStockPicture.Name = "picbxStockPicture";
            this.picbxStockPicture.Size = new System.Drawing.Size(300, 308);
            this.picbxStockPicture.TabIndex = 2;
            this.picbxStockPicture.TabStop = false;
            // 
            // nudPurchase
            // 
            this.nudPurchase.Location = new System.Drawing.Point(552, 403);
            this.nudPurchase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudPurchase.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPurchase.Name = "nudPurchase";
            this.nudPurchase.Size = new System.Drawing.Size(180, 26);
            this.nudPurchase.TabIndex = 4;
            this.nudPurchase.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(48, 412);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(78, 17);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.Color.Transparent;
            this.lblISBN.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(48, 446);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(58, 17);
            this.lblISBN.TabIndex = 7;
            this.lblISBN.Text = "Code:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.BackColor = System.Drawing.Color.Transparent;
            this.lblPublisher.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(48, 483);
            this.lblPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(108, 17);
            this.lblPublisher.TabIndex = 8;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblPercent.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.Location = new System.Drawing.Point(48, 552);
            this.lblPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(88, 17);
            this.lblPercent.TabIndex = 9;
            this.lblPercent.Text = "Percent(%):";
            this.lblPercent.Click += new System.EventHandler(this.lblpage_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(48, 517);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(58, 17);
            this.lblType.TabIndex = 10;
            this.lblType.Text = "Type:";
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPurchase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchase.Image")));
            this.btnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.Location = new System.Drawing.Point(528, 458);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(264, 129);
            this.btnPurchase.TabIndex = 11;
            this.btnPurchase.Text = "Add to Cart";
            this.btnPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(551, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1401, 709);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.nudPurchase);
            this.Controls.Add(this.picbxStockPicture);
            this.Controls.Add(this.lblStockPrice);
            this.Controls.Add(this.lblStockName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StockForm";
            this.Text = "StockForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbxStockPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStockName;
        private System.Windows.Forms.Label lblStockPrice;
        private System.Windows.Forms.PictureBox picbxStockPicture;
        private System.Windows.Forms.NumericUpDown nudPurchase;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}