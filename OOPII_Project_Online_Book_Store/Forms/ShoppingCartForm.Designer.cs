namespace StockExchange
{
    partial class ShoppingCartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCartForm));
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpShopping = new System.Windows.Forms.TabPage();
            this.flPanelShopping = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tpPayment = new System.Windows.Forms.TabPage();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pnlPaymentCard = new System.Windows.Forms.Panel();
            this.lbCreditCartNumber = new System.Windows.Forms.Label();
            this.msTxtCreditCard = new System.Windows.Forms.MaskedTextBox();
            this.msTxtExpDate = new System.Windows.Forms.MaskedTextBox();
            this.msTxtCVC = new System.Windows.Forms.MaskedTextBox();
            this.lbExpDate = new System.Windows.Forms.Label();
            this.lbCVC = new System.Windows.Forms.Label();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.tabControl.SuspendLayout();
            this.tpShopping.SuspendLayout();
            this.tpPayment.SuspendLayout();
            this.pnlPaymentCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckout
            // 
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckout.Image")));
            this.btnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.Location = new System.Drawing.Point(159, 466);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(192, 77);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(420, 466);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(192, 77);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(69, 22);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(101, 23);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "Product";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpShopping);
            this.tabControl.Controls.Add(this.tpPayment);
            this.tabControl.Location = new System.Drawing.Point(27, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(826, 643);
            this.tabControl.TabIndex = 4;
            // 
            // tpShopping
            // 
            this.tpShopping.Controls.Add(this.flPanelShopping);
            this.tpShopping.Controls.Add(this.btnPayment);
            this.tpShopping.Controls.Add(this.btnCancel);
            this.tpShopping.Controls.Add(this.lblQuantity);
            this.tpShopping.Controls.Add(this.lblProduct);
            this.tpShopping.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpShopping.Location = new System.Drawing.Point(4, 29);
            this.tpShopping.Name = "tpShopping";
            this.tpShopping.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpShopping.Size = new System.Drawing.Size(818, 610);
            this.tpShopping.TabIndex = 0;
            this.tpShopping.Text = "Shopping Cart";
            this.tpShopping.UseVisualStyleBackColor = true;
            // 
            // flPanelShopping
            // 
            this.flPanelShopping.AutoScroll = true;
            this.flPanelShopping.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flPanelShopping.Location = new System.Drawing.Point(40, 77);
            this.flPanelShopping.Name = "flPanelShopping";
            this.flPanelShopping.Size = new System.Drawing.Size(771, 417);
            this.flPanelShopping.TabIndex = 10;
            // 
            // btnPayment
            // 
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.Image")));
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(40, 502);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(186, 77);
            this.btnPayment.TabIndex = 9;
            this.btnPayment.Text = "Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(282, 502);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(176, 77);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(615, 22);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(114, 23);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.Click += new System.EventHandler(this.lblQuantity_Click);
            // 
            // tpPayment
            // 
            this.tpPayment.Controls.Add(this.lblPrice);
            this.tpPayment.Controls.Add(this.pnlPaymentCard);
            this.tpPayment.Controls.Add(this.btnBack);
            this.tpPayment.Controls.Add(this.rbCreditCard);
            this.tpPayment.Controls.Add(this.btnCheckout);
            this.tpPayment.Controls.Add(this.rbCash);
            this.tpPayment.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPayment.Location = new System.Drawing.Point(4, 39);
            this.tpPayment.Name = "tpPayment";
            this.tpPayment.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpPayment.Size = new System.Drawing.Size(818, 600);
            this.tpPayment.TabIndex = 1;
            this.tpPayment.Text = "Payment";
            this.tpPayment.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(339, 45);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(115, 35);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // pnlPaymentCard
            // 
            this.pnlPaymentCard.Controls.Add(this.lbCreditCartNumber);
            this.pnlPaymentCard.Controls.Add(this.msTxtCreditCard);
            this.pnlPaymentCard.Controls.Add(this.msTxtExpDate);
            this.pnlPaymentCard.Controls.Add(this.msTxtCVC);
            this.pnlPaymentCard.Controls.Add(this.lbExpDate);
            this.pnlPaymentCard.Controls.Add(this.lbCVC);
            this.pnlPaymentCard.Location = new System.Drawing.Point(102, 197);
            this.pnlPaymentCard.Name = "pnlPaymentCard";
            this.pnlPaymentCard.Size = new System.Drawing.Size(588, 217);
            this.pnlPaymentCard.TabIndex = 8;
            this.pnlPaymentCard.Visible = false;
            // 
            // lbCreditCartNumber
            // 
            this.lbCreditCartNumber.AutoSize = true;
            this.lbCreditCartNumber.Location = new System.Drawing.Point(21, 35);
            this.lbCreditCartNumber.Name = "lbCreditCartNumber";
            this.lbCreditCartNumber.Size = new System.Drawing.Size(188, 17);
            this.lbCreditCartNumber.TabIndex = 1;
            this.lbCreditCartNumber.Text = "Credit Card Number";
            // 
            // msTxtCreditCard
            // 
            this.msTxtCreditCard.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msTxtCreditCard.Location = new System.Drawing.Point(218, 28);
            this.msTxtCreditCard.Mask = " 0000-0000-0000-0000";
            this.msTxtCreditCard.Name = "msTxtCreditCard";
            this.msTxtCreditCard.Size = new System.Drawing.Size(196, 24);
            this.msTxtCreditCard.TabIndex = 0;
            this.msTxtCreditCard.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // msTxtExpDate
            // 
            this.msTxtExpDate.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msTxtExpDate.Location = new System.Drawing.Point(192, 106);
            this.msTxtExpDate.Mask = " 00/00";
            this.msTxtExpDate.Name = "msTxtExpDate";
            this.msTxtExpDate.Size = new System.Drawing.Size(80, 24);
            this.msTxtExpDate.TabIndex = 2;
            this.msTxtExpDate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // msTxtCVC
            // 
            this.msTxtCVC.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msTxtCVC.Location = new System.Drawing.Point(378, 106);
            this.msTxtCVC.Mask = "000";
            this.msTxtCVC.Name = "msTxtCVC";
            this.msTxtCVC.Size = new System.Drawing.Size(36, 24);
            this.msTxtCVC.TabIndex = 5;
            this.msTxtCVC.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // lbExpDate
            // 
            this.lbExpDate.AutoSize = true;
            this.lbExpDate.Location = new System.Drawing.Point(21, 114);
            this.lbExpDate.Name = "lbExpDate";
            this.lbExpDate.Size = new System.Drawing.Size(158, 17);
            this.lbExpDate.TabIndex = 3;
            this.lbExpDate.Text = "Expiration Date";
            // 
            // lbCVC
            // 
            this.lbCVC.AutoSize = true;
            this.lbCVC.Location = new System.Drawing.Point(327, 111);
            this.lbCVC.Name = "lbCVC";
            this.lbCVC.Size = new System.Drawing.Size(38, 17);
            this.lbCVC.TabIndex = 4;
            this.lbCVC.Text = "CVC";
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Location = new System.Drawing.Point(410, 120);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(143, 21);
            this.rbCreditCard.TabIndex = 7;
            this.rbCreditCard.Text = "Credit Card";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            this.rbCreditCard.CheckedChanged += new System.EventHandler(this.rbCreditCard_CheckedChanged);
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Checked = true;
            this.rbCash.Location = new System.Drawing.Point(282, 120);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(73, 21);
            this.rbCash.TabIndex = 6;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged);
            // 
            // ShoppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 663);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShoppingCartForm";
            this.Text = "YourShoppingCart";
            this.Load += new System.EventHandler(this.ShoppingCartForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tpShopping.ResumeLayout(false);
            this.tpShopping.PerformLayout();
            this.tpPayment.ResumeLayout(false);
            this.tpPayment.PerformLayout();
            this.pnlPaymentCard.ResumeLayout(false);
            this.pnlPaymentCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TabPage tpPayment;
        private System.Windows.Forms.MaskedTextBox msTxtCVC;
        private System.Windows.Forms.Label lbCVC;
        private System.Windows.Forms.Label lbExpDate;
        private System.Windows.Forms.MaskedTextBox msTxtExpDate;
        private System.Windows.Forms.Label lbCreditCartNumber;
        private System.Windows.Forms.MaskedTextBox msTxtCreditCard;
        private System.Windows.Forms.Panel pnlPaymentCard;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.FlowLayoutPanel flPanelShopping;
        private System.Windows.Forms.TabPage tpShopping;
        private System.Windows.Forms.Label lblPrice;
    }
}