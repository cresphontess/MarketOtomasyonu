namespace MarketOtomasyonu.WFA
{
    partial class OrderForm
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
            this.btnOrderSave = new System.Windows.Forms.Button();
            this.cmbOrderProduct = new System.Windows.Forms.ComboBox();
            this.nmOrderQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbl_OrderTitle = new System.Windows.Forms.Label();
            this.LblOrderProduct = new System.Windows.Forms.Label();
            this.lblOrderQuantity = new System.Windows.Forms.Label();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.lblOrderList = new System.Windows.Forms.Label();
            this.lblOrderPrice = new System.Windows.Forms.Label();
            this.lblOrderPriceText = new System.Windows.Forms.Label();
            this.dtOrder = new System.Windows.Forms.DateTimePicker();
            this.lblOrderBarcode = new System.Windows.Forms.Label();
            this.txtOrderBarcode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmOrderQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrderSave
            // 
            this.btnOrderSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrderSave.Location = new System.Drawing.Point(48, 388);
            this.btnOrderSave.Name = "btnOrderSave";
            this.btnOrderSave.Size = new System.Drawing.Size(700, 59);
            this.btnOrderSave.TabIndex = 0;
            this.btnOrderSave.Text = "Kaydet";
            this.btnOrderSave.UseVisualStyleBackColor = true;
            // 
            // cmbOrderProduct
            // 
            this.cmbOrderProduct.FormattingEnabled = true;
            this.cmbOrderProduct.Location = new System.Drawing.Point(82, 248);
            this.cmbOrderProduct.Name = "cmbOrderProduct";
            this.cmbOrderProduct.Size = new System.Drawing.Size(166, 21);
            this.cmbOrderProduct.TabIndex = 1;
            // 
            // nmOrderQuantity
            // 
            this.nmOrderQuantity.Location = new System.Drawing.Point(336, 231);
            this.nmOrderQuantity.Name = "nmOrderQuantity";
            this.nmOrderQuantity.Size = new System.Drawing.Size(91, 20);
            this.nmOrderQuantity.TabIndex = 2;
            // 
            // lbl_OrderTitle
            // 
            this.lbl_OrderTitle.AutoSize = true;
            this.lbl_OrderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_OrderTitle.Location = new System.Drawing.Point(304, 14);
            this.lbl_OrderTitle.Name = "lbl_OrderTitle";
            this.lbl_OrderTitle.Size = new System.Drawing.Size(177, 55);
            this.lbl_OrderTitle.TabIndex = 3;
            this.lbl_OrderTitle.Text = "Sipariş";
            // 
            // LblOrderProduct
            // 
            this.LblOrderProduct.AutoSize = true;
            this.LblOrderProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOrderProduct.Location = new System.Drawing.Point(140, 225);
            this.LblOrderProduct.Name = "LblOrderProduct";
            this.LblOrderProduct.Size = new System.Drawing.Size(48, 20);
            this.LblOrderProduct.TabIndex = 4;
            this.LblOrderProduct.Text = "Ürün";
            // 
            // lblOrderQuantity
            // 
            this.lblOrderQuantity.AutoSize = true;
            this.lblOrderQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderQuantity.Location = new System.Drawing.Point(356, 207);
            this.lblOrderQuantity.Name = "lblOrderQuantity";
            this.lblOrderQuantity.Size = new System.Drawing.Size(47, 20);
            this.lblOrderQuantity.TabIndex = 5;
            this.lblOrderQuantity.Text = "Adet";
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.Location = new System.Drawing.Point(512, 174);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(276, 199);
            this.lstOrder.TabIndex = 6;
            // 
            // lblOrderList
            // 
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderList.Location = new System.Drawing.Point(582, 140);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(121, 20);
            this.lblOrderList.TabIndex = 7;
            this.lblOrderList.Text = "Sipariş Listesi";
            // 
            // lblOrderPrice
            // 
            this.lblOrderPrice.AutoSize = true;
            this.lblOrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderPrice.Location = new System.Drawing.Point(321, 277);
            this.lblOrderPrice.Name = "lblOrderPrice";
            this.lblOrderPrice.Size = new System.Drawing.Size(115, 20);
            this.lblOrderPrice.TabIndex = 8;
            this.lblOrderPrice.Text = "Sipariş Tutarı";
            // 
            // lblOrderPriceText
            // 
            this.lblOrderPriceText.AutoSize = true;
            this.lblOrderPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderPriceText.Location = new System.Drawing.Point(355, 307);
            this.lblOrderPriceText.Name = "lblOrderPriceText";
            this.lblOrderPriceText.Size = new System.Drawing.Size(48, 29);
            this.lblOrderPriceText.TabIndex = 9;
            this.lblOrderPriceText.Text = "0 tl";
            // 
            // dtOrder
            // 
            this.dtOrder.Location = new System.Drawing.Point(632, 14);
            this.dtOrder.Name = "dtOrder";
            this.dtOrder.Size = new System.Drawing.Size(156, 20);
            this.dtOrder.TabIndex = 10;
            // 
            // lblOrderBarcode
            // 
            this.lblOrderBarcode.AutoSize = true;
            this.lblOrderBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderBarcode.Location = new System.Drawing.Point(310, 107);
            this.lblOrderBarcode.Name = "lblOrderBarcode";
            this.lblOrderBarcode.Size = new System.Drawing.Size(146, 20);
            this.lblOrderBarcode.TabIndex = 25;
            this.lblOrderBarcode.Text = "Barkod Numarası";
            // 
            // txtOrderBarcode
            // 
            this.txtOrderBarcode.Location = new System.Drawing.Point(292, 130);
            this.txtOrderBarcode.Name = "txtOrderBarcode";
            this.txtOrderBarcode.Size = new System.Drawing.Size(193, 20);
            this.txtOrderBarcode.TabIndex = 24;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOrderBarcode);
            this.Controls.Add(this.txtOrderBarcode);
            this.Controls.Add(this.dtOrder);
            this.Controls.Add(this.lblOrderPriceText);
            this.Controls.Add(this.lblOrderPrice);
            this.Controls.Add(this.lblOrderList);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.lblOrderQuantity);
            this.Controls.Add(this.LblOrderProduct);
            this.Controls.Add(this.lbl_OrderTitle);
            this.Controls.Add(this.nmOrderQuantity);
            this.Controls.Add(this.cmbOrderProduct);
            this.Controls.Add(this.btnOrderSave);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.nmOrderQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderSave;
        private System.Windows.Forms.ComboBox cmbOrderProduct;
        private System.Windows.Forms.NumericUpDown nmOrderQuantity;
        private System.Windows.Forms.Label lbl_OrderTitle;
        private System.Windows.Forms.Label LblOrderProduct;
        private System.Windows.Forms.Label lblOrderQuantity;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Label lblOrderList;
        private System.Windows.Forms.Label lblOrderPrice;
        private System.Windows.Forms.Label lblOrderPriceText;
        private System.Windows.Forms.DateTimePicker dtOrder;
        private System.Windows.Forms.Label lblOrderBarcode;
        private System.Windows.Forms.TextBox txtOrderBarcode;
    }
}