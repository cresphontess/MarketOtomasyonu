namespace MarketOtomasyonu.WFA
{
    partial class SaleForm
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
            this.lblSaleTitle = new System.Windows.Forms.Label();
            this.dtSale = new System.Windows.Forms.DateTimePicker();
            this.lblOrderBarcode = new System.Windows.Forms.Label();
            this.lblTotalAmountText = new System.Windows.Forms.Label();
            this.lblSaleTotalAmount = new System.Windows.Forms.Label();
            this.lstProduct = new System.Windows.Forms.ListBox();
            this.btnSaleProductPass = new System.Windows.Forms.Button();
            this.rbSaleCash = new System.Windows.Forms.RadioButton();
            this.gbPayingType = new System.Windows.Forms.GroupBox();
            this.rbSaleCreditCard = new System.Windows.Forms.RadioButton();
            this.lblOrderList = new System.Windows.Forms.Label();
            this.txtSaleReceivedAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaleRemainAmount = new System.Windows.Forms.Label();
            this.btnSaleBill = new System.Windows.Forms.Button();
            this.lblSaleRemainAmountText = new System.Windows.Forms.Label();
            this.cmbProductBarcode = new System.Windows.Forms.ComboBox();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaleDelete = new System.Windows.Forms.Button();
            this.btnSaleUpdate = new System.Windows.Forms.Button();
            this.gbPayingType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaleTitle
            // 
            this.lblSaleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaleTitle.Location = new System.Drawing.Point(637, 24);
            this.lblSaleTitle.Name = "lblSaleTitle";
            this.lblSaleTitle.Size = new System.Drawing.Size(207, 93);
            this.lblSaleTitle.TabIndex = 4;
            this.lblSaleTitle.Text = "Satış";
            // 
            // dtSale
            // 
            this.dtSale.Location = new System.Drawing.Point(1373, 30);
            this.dtSale.Name = "dtSale";
            this.dtSale.Size = new System.Drawing.Size(164, 20);
            this.dtSale.TabIndex = 5;
            // 
            // lblOrderBarcode
            // 
            this.lblOrderBarcode.AutoSize = true;
            this.lblOrderBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderBarcode.Location = new System.Drawing.Point(25, 359);
            this.lblOrderBarcode.Name = "lblOrderBarcode";
            this.lblOrderBarcode.Size = new System.Drawing.Size(276, 29);
            this.lblOrderBarcode.TabIndex = 27;
            this.lblOrderBarcode.Text = "Ürün Barkod Numarası";
            // 
            // lblTotalAmountText
            // 
            this.lblTotalAmountText.AutoSize = true;
            this.lblTotalAmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalAmountText.Location = new System.Drawing.Point(1119, 242);
            this.lblTotalAmountText.Name = "lblTotalAmountText";
            this.lblTotalAmountText.Size = new System.Drawing.Size(71, 42);
            this.lblTotalAmountText.TabIndex = 29;
            this.lblTotalAmountText.Text = "0 tl";
            // 
            // lblSaleTotalAmount
            // 
            this.lblSaleTotalAmount.AutoSize = true;
            this.lblSaleTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaleTotalAmount.Location = new System.Drawing.Point(1079, 213);
            this.lblSaleTotalAmount.Name = "lblSaleTotalAmount";
            this.lblSaleTotalAmount.Size = new System.Drawing.Size(170, 29);
            this.lblSaleTotalAmount.TabIndex = 28;
            this.lblSaleTotalAmount.Text = "Toplam Tutar";
            // 
            // lstProduct
            // 
            this.lstProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.ItemHeight = 29;
            this.lstProduct.Location = new System.Drawing.Point(552, 292);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(331, 381);
            this.lstProduct.TabIndex = 30;
            this.lstProduct.SelectedIndexChanged += new System.EventHandler(this.lstProduct_SelectedIndexChanged);
            // 
            // btnSaleProductPass
            // 
            this.btnSaleProductPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaleProductPass.Location = new System.Drawing.Point(349, 438);
            this.btnSaleProductPass.Name = "btnSaleProductPass";
            this.btnSaleProductPass.Size = new System.Drawing.Size(154, 74);
            this.btnSaleProductPass.TabIndex = 31;
            this.btnSaleProductPass.Text = "Ürün Geç -->";
            this.btnSaleProductPass.UseVisualStyleBackColor = true;
            this.btnSaleProductPass.Click += new System.EventHandler(this.btnSaleProductPass_Click);
            // 
            // rbSaleCash
            // 
            this.rbSaleCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSaleCash.Location = new System.Drawing.Point(36, 54);
            this.rbSaleCash.Name = "rbSaleCash";
            this.rbSaleCash.Size = new System.Drawing.Size(88, 40);
            this.rbSaleCash.TabIndex = 32;
            this.rbSaleCash.TabStop = true;
            this.rbSaleCash.Text = "Nakit";
            this.rbSaleCash.UseVisualStyleBackColor = true;
            // 
            // gbPayingType
            // 
            this.gbPayingType.Controls.Add(this.rbSaleCash);
            this.gbPayingType.Controls.Add(this.rbSaleCreditCard);
            this.gbPayingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbPayingType.Location = new System.Drawing.Point(1007, 334);
            this.gbPayingType.Name = "gbPayingType";
            this.gbPayingType.Size = new System.Drawing.Size(332, 135);
            this.gbPayingType.TabIndex = 35;
            this.gbPayingType.TabStop = false;
            this.gbPayingType.Text = "Ödeme Tipi";
            // 
            // rbSaleCreditCard
            // 
            this.rbSaleCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSaleCreditCard.Location = new System.Drawing.Point(163, 54);
            this.rbSaleCreditCard.Name = "rbSaleCreditCard";
            this.rbSaleCreditCard.Size = new System.Drawing.Size(144, 40);
            this.rbSaleCreditCard.TabIndex = 33;
            this.rbSaleCreditCard.TabStop = true;
            this.rbSaleCreditCard.Text = "KrediKartı";
            this.rbSaleCreditCard.UseVisualStyleBackColor = true;
            // 
            // lblOrderList
            // 
            this.lblOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderList.Location = new System.Drawing.Point(664, 228);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(111, 42);
            this.lblOrderList.TabIndex = 36;
            this.lblOrderList.Text = "Sepet";
            // 
            // txtSaleReceivedAmount
            // 
            this.txtSaleReceivedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSaleReceivedAmount.Location = new System.Drawing.Point(1028, 545);
            this.txtSaleReceivedAmount.Name = "txtSaleReceivedAmount";
            this.txtSaleReceivedAmount.Size = new System.Drawing.Size(100, 29);
            this.txtSaleReceivedAmount.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1020, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Alınan Tutar";
            // 
            // lblSaleRemainAmount
            // 
            this.lblSaleRemainAmount.AutoSize = true;
            this.lblSaleRemainAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaleRemainAmount.Location = new System.Drawing.Point(1186, 510);
            this.lblSaleRemainAmount.Name = "lblSaleRemainAmount";
            this.lblSaleRemainAmount.Size = new System.Drawing.Size(99, 24);
            this.lblSaleRemainAmount.TabIndex = 40;
            this.lblSaleRemainAmount.Text = "Para Üstü";
            // 
            // btnSaleBill
            // 
            this.btnSaleBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaleBill.Location = new System.Drawing.Point(958, 614);
            this.btnSaleBill.Name = "btnSaleBill";
            this.btnSaleBill.Size = new System.Drawing.Size(392, 98);
            this.btnSaleBill.TabIndex = 41;
            this.btnSaleBill.Text = "Satışı Yap Ve Fiş Oluştur";
            this.btnSaleBill.UseVisualStyleBackColor = true;
            this.btnSaleBill.Click += new System.EventHandler(this.btnSaleBill_Click);
            // 
            // lblSaleRemainAmountText
            // 
            this.lblSaleRemainAmountText.AutoSize = true;
            this.lblSaleRemainAmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaleRemainAmountText.Location = new System.Drawing.Point(1200, 545);
            this.lblSaleRemainAmountText.Name = "lblSaleRemainAmountText";
            this.lblSaleRemainAmountText.Size = new System.Drawing.Size(65, 29);
            this.lblSaleRemainAmountText.TabIndex = 42;
            this.lblSaleRemainAmountText.Text = "0 TL";
            // 
            // cmbProductBarcode
            // 
            this.cmbProductBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbProductBarcode.FormattingEnabled = true;
            this.cmbProductBarcode.Location = new System.Drawing.Point(71, 401);
            this.cmbProductBarcode.Name = "cmbProductBarcode";
            this.cmbProductBarcode.Size = new System.Drawing.Size(202, 32);
            this.cmbProductBarcode.TabIndex = 43;
            // 
            // nmQuantity
            // 
            this.nmQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmQuantity.Location = new System.Drawing.Point(113, 524);
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(120, 29);
            this.nmQuantity.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(142, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 46;
            this.label2.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1279, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 47;
            this.label3.Text = "Tarih :";
            // 
            // btnSaleDelete
            // 
            this.btnSaleDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaleDelete.Location = new System.Drawing.Point(583, 783);
            this.btnSaleDelete.Name = "btnSaleDelete";
            this.btnSaleDelete.Size = new System.Drawing.Size(128, 48);
            this.btnSaleDelete.TabIndex = 48;
            this.btnSaleDelete.Text = " Sil";
            this.btnSaleDelete.UseVisualStyleBackColor = true;
            this.btnSaleDelete.Click += new System.EventHandler(this.btnSaleDelete_Click);
            // 
            // btnSaleUpdate
            // 
            this.btnSaleUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaleUpdate.Location = new System.Drawing.Point(749, 783);
            this.btnSaleUpdate.Name = "btnSaleUpdate";
            this.btnSaleUpdate.Size = new System.Drawing.Size(122, 48);
            this.btnSaleUpdate.TabIndex = 49;
            this.btnSaleUpdate.Text = "Güncelle";
            this.btnSaleUpdate.UseVisualStyleBackColor = true;
            this.btnSaleUpdate.Click += new System.EventHandler(this.btnSaleUpdate_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.btnSaleUpdate);
            this.Controls.Add(this.btnSaleDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmQuantity);
            this.Controls.Add(this.cmbProductBarcode);
            this.Controls.Add(this.lblSaleRemainAmountText);
            this.Controls.Add(this.btnSaleBill);
            this.Controls.Add(this.lblSaleRemainAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaleReceivedAmount);
            this.Controls.Add(this.lblOrderList);
            this.Controls.Add(this.gbPayingType);
            this.Controls.Add(this.btnSaleProductPass);
            this.Controls.Add(this.lstProduct);
            this.Controls.Add(this.lblTotalAmountText);
            this.Controls.Add(this.lblSaleTotalAmount);
            this.Controls.Add(this.lblOrderBarcode);
            this.Controls.Add(this.dtSale);
            this.Controls.Add(this.lblSaleTitle);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.gbPayingType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaleTitle;
        private System.Windows.Forms.DateTimePicker dtSale;
        private System.Windows.Forms.Label lblOrderBarcode;
        private System.Windows.Forms.Label lblTotalAmountText;
        private System.Windows.Forms.Label lblSaleTotalAmount;
        private System.Windows.Forms.ListBox lstProduct;
        private System.Windows.Forms.Button btnSaleProductPass;
        private System.Windows.Forms.RadioButton rbSaleCash;
        private System.Windows.Forms.GroupBox gbPayingType;
        private System.Windows.Forms.Label lblOrderList;
        private System.Windows.Forms.TextBox txtSaleReceivedAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaleRemainAmount;
        private System.Windows.Forms.Button btnSaleBill;
        private System.Windows.Forms.Label lblSaleRemainAmountText;
        private System.Windows.Forms.ComboBox cmbProductBarcode;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaleDelete;
        private System.Windows.Forms.Button btnSaleUpdate;
        private System.Windows.Forms.RadioButton rbSaleCreditCard;
    }
}