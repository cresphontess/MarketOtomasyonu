namespace MarketOtomasyonu.WFA
{
    partial class BillForm
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
            this.lblBillTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.lstBillProducts = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBillTotalAmount = new System.Windows.Forms.Label();
            this.cmbBills = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetBill = new System.Windows.Forms.Button();
            this.lblBillTotalKDV = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetProducts = new System.Windows.Forms.Button();
            this.btnGetCategories = new System.Windows.Forms.Button();
            this.btnGetSaleCard = new System.Windows.Forms.Button();
            this.btnGetCash = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnGetDaySale = new System.Windows.Forms.Button();
            this.btnGetMonth = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBillTitle
            // 
            this.lblBillTitle.AutoSize = true;
            this.lblBillTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillTitle.Location = new System.Drawing.Point(320, 9);
            this.lblBillTitle.Name = "lblBillTitle";
            this.lblBillTitle.Size = new System.Drawing.Size(90, 55);
            this.lblBillTitle.TabIndex = 4;
            this.lblBillTitle.Text = "Fiş";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(310, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tarih :";
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillDate.Location = new System.Drawing.Point(375, 95);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(57, 20);
            this.lblBillDate.TabIndex = 6;
            this.lblBillDate.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(299, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fiş No :";
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillNo.Location = new System.Drawing.Point(374, 118);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(57, 20);
            this.lblBillNo.TabIndex = 8;
            this.lblBillNo.Text = "label4";
            // 
            // lstBillProducts
            // 
            this.lstBillProducts.FormattingEnabled = true;
            this.lstBillProducts.Location = new System.Drawing.Point(251, 149);
            this.lstBillProducts.Name = "lstBillProducts";
            this.lstBillProducts.Size = new System.Drawing.Size(449, 225);
            this.lstBillProducts.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(270, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "TOPLAM :";
            // 
            // lblBillTotalAmount
            // 
            this.lblBillTotalAmount.AutoSize = true;
            this.lblBillTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillTotalAmount.Location = new System.Drawing.Point(368, 395);
            this.lblBillTotalAmount.Name = "lblBillTotalAmount";
            this.lblBillTotalAmount.Size = new System.Drawing.Size(19, 20);
            this.lblBillTotalAmount.TabIndex = 13;
            this.lblBillTotalAmount.Text = "0";
            // 
            // cmbBills
            // 
            this.cmbBills.FormattingEnabled = true;
            this.cmbBills.Location = new System.Drawing.Point(10, 109);
            this.cmbBills.Name = "cmbBills";
            this.cmbBills.Size = new System.Drawing.Size(217, 21);
            this.cmbBills.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(88, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fişler";
            // 
            // btnGetBill
            // 
            this.btnGetBill.Location = new System.Drawing.Point(10, 149);
            this.btnGetBill.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetBill.Name = "btnGetBill";
            this.btnGetBill.Size = new System.Drawing.Size(216, 37);
            this.btnGetBill.TabIndex = 16;
            this.btnGetBill.Text = "Fişi Getir";
            this.btnGetBill.UseVisualStyleBackColor = true;
            this.btnGetBill.Click += new System.EventHandler(this.btnGetBill_Click);
            // 
            // lblBillTotalKDV
            // 
            this.lblBillTotalKDV.AutoSize = true;
            this.lblBillTotalKDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillTotalKDV.Location = new System.Drawing.Point(369, 430);
            this.lblBillTotalKDV.Name = "lblBillTotalKDV";
            this.lblBillTotalKDV.Size = new System.Drawing.Size(19, 20);
            this.lblBillTotalKDV.TabIndex = 17;
            this.lblBillTotalKDV.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(285, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "KDV";
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.Location = new System.Drawing.Point(10, 191);
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(216, 38);
            this.btnGetProducts.TabIndex = 19;
            this.btnGetProducts.Text = "Ürünleri Getir";
            this.btnGetProducts.UseVisualStyleBackColor = true;
            this.btnGetProducts.Click += new System.EventHandler(this.btnGetProducts_Click);
            // 
            // btnGetCategories
            // 
            this.btnGetCategories.Location = new System.Drawing.Point(10, 235);
            this.btnGetCategories.Name = "btnGetCategories";
            this.btnGetCategories.Size = new System.Drawing.Size(216, 42);
            this.btnGetCategories.TabIndex = 20;
            this.btnGetCategories.Text = "Kategorilere Göre Ürün Getir";
            this.btnGetCategories.UseVisualStyleBackColor = true;
            this.btnGetCategories.Click += new System.EventHandler(this.btnGetCategories_Click);
            // 
            // btnGetSaleCard
            // 
            this.btnGetSaleCard.Location = new System.Drawing.Point(10, 283);
            this.btnGetSaleCard.Name = "btnGetSaleCard";
            this.btnGetSaleCard.Size = new System.Drawing.Size(216, 41);
            this.btnGetSaleCard.TabIndex = 21;
            this.btnGetSaleCard.Text = "Kredi Kartı İle Yapılan Satışları Getir";
            this.btnGetSaleCard.UseVisualStyleBackColor = true;
            this.btnGetSaleCard.Click += new System.EventHandler(this.btnGetSaleCard_Click);
            // 
            // btnGetCash
            // 
            this.btnGetCash.Location = new System.Drawing.Point(10, 330);
            this.btnGetCash.Name = "btnGetCash";
            this.btnGetCash.Size = new System.Drawing.Size(216, 44);
            this.btnGetCash.TabIndex = 22;
            this.btnGetCash.Text = "Nakit Yapılan Satışlar Getir";
            this.btnGetCash.UseVisualStyleBackColor = true;
            this.btnGetCash.Click += new System.EventHandler(this.btnGetCash_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(10, 44);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 23;
            // 
            // btnGetDaySale
            // 
            this.btnGetDaySale.Location = new System.Drawing.Point(12, 380);
            this.btnGetDaySale.Name = "btnGetDaySale";
            this.btnGetDaySale.Size = new System.Drawing.Size(214, 35);
            this.btnGetDaySale.TabIndex = 24;
            this.btnGetDaySale.Text = "Günlük Satış Raporu";
            this.btnGetDaySale.UseVisualStyleBackColor = true;
            this.btnGetDaySale.Click += new System.EventHandler(this.btnGetDaySale_Click);
            // 
            // btnGetMonth
            // 
            this.btnGetMonth.Location = new System.Drawing.Point(12, 421);
            this.btnGetMonth.Name = "btnGetMonth";
            this.btnGetMonth.Size = new System.Drawing.Size(214, 38);
            this.btnGetMonth.TabIndex = 25;
            this.btnGetMonth.Text = "Aylık Satış Rapor";
            this.btnGetMonth.UseVisualStyleBackColor = true;
            this.btnGetMonth.Click += new System.EventHandler(this.btnGetMonth_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(598, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Kazanılan Tutar";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSum.Location = new System.Drawing.Point(630, 110);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(0, 20);
            this.lblSum.TabIndex = 27;
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 462);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGetMonth);
            this.Controls.Add(this.btnGetDaySale);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnGetCash);
            this.Controls.Add(this.btnGetSaleCard);
            this.Controls.Add(this.btnGetCategories);
            this.Controls.Add(this.btnGetProducts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBillTotalKDV);
            this.Controls.Add(this.btnGetBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBills);
            this.Controls.Add(this.lblBillTotalAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstBillProducts);
            this.Controls.Add(this.lblBillNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBillDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBillTitle);
            this.Name = "BillForm";
            this.Text = "BillForm";
            this.Load += new System.EventHandler(this.BillForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBillTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.ListBox lstBillProducts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBillTotalAmount;
        private System.Windows.Forms.ComboBox cmbBills;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetBill;
        private System.Windows.Forms.Label lblBillTotalKDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetProducts;
        private System.Windows.Forms.Button btnGetCategories;
        private System.Windows.Forms.Button btnGetSaleCard;
        private System.Windows.Forms.Button btnGetCash;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnGetDaySale;
        private System.Windows.Forms.Button btnGetMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSum;
    }
}