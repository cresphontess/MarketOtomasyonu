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
            this.cmbPackageProduct = new System.Windows.Forms.ComboBox();
            this.nmOrderQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblOrderTitle = new System.Windows.Forms.Label();
            this.LblOrderProduct = new System.Windows.Forms.Label();
            this.lblOrderQuantity = new System.Windows.Forms.Label();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.lblOrderList = new System.Windows.Forms.Label();
            this.lblOrderPrice = new System.Windows.Forms.Label();
            this.lblOrderPriceText = new System.Windows.Forms.Label();
            this.lblOrderBarcode = new System.Windows.Forms.Label();
            this.txtPackageBarcode = new System.Windows.Forms.TextBox();
            this.txtOrderPackagePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbPackageBarcode = new System.Windows.Forms.PictureBox();
            this.btnAddBarcode = new System.Windows.Forms.Button();
            this.btnNewProductAdd = new System.Windows.Forms.Button();
            this.cmbOrderName = new System.Windows.Forms.ComboBox();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnOrderDelete = new System.Windows.Forms.Button();
            this.txtOrderName = new System.Windows.Forms.TextBox();
            this.lblOrderName = new System.Windows.Forms.Label();
            this.dtOrder = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmOrderQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPackageBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrderSave
            // 
            this.btnOrderSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrderSave.Location = new System.Drawing.Point(12, 469);
            this.btnOrderSave.Name = "btnOrderSave";
            this.btnOrderSave.Size = new System.Drawing.Size(341, 59);
            this.btnOrderSave.TabIndex = 0;
            this.btnOrderSave.Text = "Kaydet";
            this.btnOrderSave.UseVisualStyleBackColor = true;
            this.btnOrderSave.Click += new System.EventHandler(this.btnOrderSave_Click);
            // 
            // cmbPackageProduct
            // 
            this.cmbPackageProduct.FormattingEnabled = true;
            this.cmbPackageProduct.Location = new System.Drawing.Point(12, 315);
            this.cmbPackageProduct.Name = "cmbPackageProduct";
            this.cmbPackageProduct.Size = new System.Drawing.Size(166, 21);
            this.cmbPackageProduct.TabIndex = 1;
            this.cmbPackageProduct.DropDown += new System.EventHandler(this.cmbOrderProduct_DropDown);
            // 
            // nmOrderQuantity
            // 
            this.nmOrderQuantity.Location = new System.Drawing.Point(202, 316);
            this.nmOrderQuantity.Name = "nmOrderQuantity";
            this.nmOrderQuantity.Size = new System.Drawing.Size(91, 20);
            this.nmOrderQuantity.TabIndex = 2;
            this.nmOrderQuantity.ValueChanged += new System.EventHandler(this.nmOrderQuantity_ValueChanged);
            // 
            // lblOrderTitle
            // 
            this.lblOrderTitle.AutoSize = true;
            this.lblOrderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderTitle.Location = new System.Drawing.Point(304, 14);
            this.lblOrderTitle.Name = "lblOrderTitle";
            this.lblOrderTitle.Size = new System.Drawing.Size(177, 55);
            this.lblOrderTitle.TabIndex = 3;
            this.lblOrderTitle.Text = "Sipariş";
            // 
            // LblOrderProduct
            // 
            this.LblOrderProduct.AutoSize = true;
            this.LblOrderProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOrderProduct.Location = new System.Drawing.Point(69, 292);
            this.LblOrderProduct.Name = "LblOrderProduct";
            this.LblOrderProduct.Size = new System.Drawing.Size(48, 20);
            this.LblOrderProduct.TabIndex = 4;
            this.LblOrderProduct.Text = "Ürün";
            // 
            // lblOrderQuantity
            // 
            this.lblOrderQuantity.AutoSize = true;
            this.lblOrderQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderQuantity.Location = new System.Drawing.Point(222, 292);
            this.lblOrderQuantity.Name = "lblOrderQuantity";
            this.lblOrderQuantity.Size = new System.Drawing.Size(47, 20);
            this.lblOrderQuantity.TabIndex = 5;
            this.lblOrderQuantity.Text = "Adet";
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.Location = new System.Drawing.Point(533, 271);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(318, 186);
            this.lstOrder.TabIndex = 6;
            this.lstOrder.SelectedIndexChanged += new System.EventHandler(this.lstOrder_SelectedIndexChanged);
            // 
            // lblOrderList
            // 
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderList.Location = new System.Drawing.Point(619, 239);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(121, 20);
            this.lblOrderList.TabIndex = 7;
            this.lblOrderList.Text = "Sipariş Listesi";
            // 
            // lblOrderPrice
            // 
            this.lblOrderPrice.AutoSize = true;
            this.lblOrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderPrice.Location = new System.Drawing.Point(390, 345);
            this.lblOrderPrice.Name = "lblOrderPrice";
            this.lblOrderPrice.Size = new System.Drawing.Size(115, 20);
            this.lblOrderPrice.TabIndex = 8;
            this.lblOrderPrice.Text = "Sipariş Tutarı";
            // 
            // lblOrderPriceText
            // 
            this.lblOrderPriceText.AutoSize = true;
            this.lblOrderPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderPriceText.Location = new System.Drawing.Point(402, 372);
            this.lblOrderPriceText.Name = "lblOrderPriceText";
            this.lblOrderPriceText.Size = new System.Drawing.Size(48, 29);
            this.lblOrderPriceText.TabIndex = 9;
            this.lblOrderPriceText.Text = "0 tl";
            // 
            // lblOrderBarcode
            // 
            this.lblOrderBarcode.AutoSize = true;
            this.lblOrderBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderBarcode.Location = new System.Drawing.Point(54, 150);
            this.lblOrderBarcode.Name = "lblOrderBarcode";
            this.lblOrderBarcode.Size = new System.Drawing.Size(110, 20);
            this.lblOrderBarcode.TabIndex = 25;
            this.lblOrderBarcode.Text = "Koli Barkodu";
            // 
            // txtPackageBarcode
            // 
            this.txtPackageBarcode.Location = new System.Drawing.Point(12, 173);
            this.txtPackageBarcode.Name = "txtPackageBarcode";
            this.txtPackageBarcode.ReadOnly = true;
            this.txtPackageBarcode.Size = new System.Drawing.Size(193, 20);
            this.txtPackageBarcode.TabIndex = 24;
            this.txtPackageBarcode.TextChanged += new System.EventHandler(this.txtOrderBarcode_TextChanged);
            // 
            // txtOrderPackagePrice
            // 
            this.txtOrderPackagePrice.Location = new System.Drawing.Point(12, 411);
            this.txtOrderPackagePrice.Name = "txtOrderPackagePrice";
            this.txtOrderPackagePrice.Size = new System.Drawing.Size(166, 20);
            this.txtOrderPackagePrice.TabIndex = 26;
            this.txtOrderPackagePrice.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Paket Fiyat";
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(12, 239);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(166, 20);
            this.txtPackageName.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Paket Adı";
            // 
            // pbPackageBarcode
            // 
            this.pbPackageBarcode.Location = new System.Drawing.Point(298, 107);
            this.pbPackageBarcode.Name = "pbPackageBarcode";
            this.pbPackageBarcode.Size = new System.Drawing.Size(207, 104);
            this.pbPackageBarcode.TabIndex = 31;
            this.pbPackageBarcode.TabStop = false;
            // 
            // btnAddBarcode
            // 
            this.btnAddBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddBarcode.Location = new System.Drawing.Point(329, 214);
            this.btnAddBarcode.Name = "btnAddBarcode";
            this.btnAddBarcode.Size = new System.Drawing.Size(133, 28);
            this.btnAddBarcode.TabIndex = 32;
            this.btnAddBarcode.Text = "Barkod Ekle";
            this.btnAddBarcode.UseVisualStyleBackColor = true;
            this.btnAddBarcode.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNewProductAdd
            // 
            this.btnNewProductAdd.Location = new System.Drawing.Point(12, 342);
            this.btnNewProductAdd.Name = "btnNewProductAdd";
            this.btnNewProductAdd.Size = new System.Drawing.Size(166, 23);
            this.btnNewProductAdd.TabIndex = 30;
            this.btnNewProductAdd.Text = "Yeni Ürün Ekle";
            this.btnNewProductAdd.UseVisualStyleBackColor = true;
            this.btnNewProductAdd.Click += new System.EventHandler(this.btnBarcodeControl_Click);
            // 
            // cmbOrderName
            // 
            this.cmbOrderName.FormattingEnabled = true;
            this.cmbOrderName.Location = new System.Drawing.Point(621, 201);
            this.cmbOrderName.Name = "cmbOrderName";
            this.cmbOrderName.Size = new System.Drawing.Size(121, 21);
            this.cmbOrderName.TabIndex = 34;
            this.cmbOrderName.DropDown += new System.EventHandler(this.cmbOrderName_DropDown);
            this.cmbOrderName.SelectedIndexChanged += new System.EventHandler(this.cmbOrderName_SelectedIndexChanged);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateOrder.Location = new System.Drawing.Point(642, 159);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(82, 34);
            this.btnCreateOrder.TabIndex = 35;
            this.btnCreateOrder.Text = "Sipariş Oluştur";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(608, 479);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 33);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(719, 479);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 33);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrderDelete.Location = new System.Drawing.Point(762, 201);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.Size = new System.Drawing.Size(73, 26);
            this.btnOrderDelete.TabIndex = 39;
            this.btnOrderDelete.Text = "Sipariş Sil";
            this.btnOrderDelete.UseVisualStyleBackColor = true;
            this.btnOrderDelete.Click += new System.EventHandler(this.btnOrderDelete_Click);
            // 
            // txtOrderName
            // 
            this.txtOrderName.Location = new System.Drawing.Point(617, 130);
            this.txtOrderName.Name = "txtOrderName";
            this.txtOrderName.Size = new System.Drawing.Size(132, 20);
            this.txtOrderName.TabIndex = 40;
            // 
            // lblOrderName
            // 
            this.lblOrderName.AutoSize = true;
            this.lblOrderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderName.Location = new System.Drawing.Point(638, 107);
            this.lblOrderName.Name = "lblOrderName";
            this.lblOrderName.Size = new System.Drawing.Size(95, 20);
            this.lblOrderName.TabIndex = 41;
            this.lblOrderName.Text = "Sipariş Adı";
            // 
            // dtOrder
            // 
            this.dtOrder.Location = new System.Drawing.Point(695, 31);
            this.dtOrder.Name = "dtOrder";
            this.dtOrder.Size = new System.Drawing.Size(156, 20);
            this.dtOrder.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(566, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Sipariş Tarihi :";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 544);
            this.Controls.Add(this.lblOrderName);
            this.Controls.Add(this.txtOrderName);
            this.Controls.Add(this.btnOrderDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.cmbOrderName);
            this.Controls.Add(this.btnNewProductAdd);
            this.Controls.Add(this.btnAddBarcode);
            this.Controls.Add(this.pbPackageBarcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPackageName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrderPackagePrice);
            this.Controls.Add(this.lblOrderBarcode);
            this.Controls.Add(this.txtPackageBarcode);
            this.Controls.Add(this.dtOrder);
            this.Controls.Add(this.lblOrderPriceText);
            this.Controls.Add(this.lblOrderPrice);
            this.Controls.Add(this.lblOrderList);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.lblOrderQuantity);
            this.Controls.Add(this.LblOrderProduct);
            this.Controls.Add(this.lblOrderTitle);
            this.Controls.Add(this.nmOrderQuantity);
            this.Controls.Add(this.cmbPackageProduct);
            this.Controls.Add(this.btnOrderSave);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmOrderQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPackageBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderSave;
        private System.Windows.Forms.ComboBox cmbPackageProduct;
        private System.Windows.Forms.NumericUpDown nmOrderQuantity;
        private System.Windows.Forms.Label lblOrderTitle;
        private System.Windows.Forms.Label LblOrderProduct;
        private System.Windows.Forms.Label lblOrderQuantity;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Label lblOrderList;
        private System.Windows.Forms.Label lblOrderPrice;
        private System.Windows.Forms.Label lblOrderPriceText;
        private System.Windows.Forms.Label lblOrderBarcode;
        private System.Windows.Forms.TextBox txtPackageBarcode;
        private System.Windows.Forms.TextBox txtOrderPackagePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewProductAdd;
        private System.Windows.Forms.PictureBox pbPackageBarcode;
        private System.Windows.Forms.Button btnAddBarcode;
        private System.Windows.Forms.ComboBox cmbOrderName;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnOrderDelete;
        private System.Windows.Forms.TextBox txtOrderName;
        private System.Windows.Forms.Label lblOrderName;
        private System.Windows.Forms.DateTimePicker dtOrder;
        private System.Windows.Forms.Label label3;
    }
}