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
            this.lblBillTotalKDV = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBills = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetBill = new System.Windows.Forms.Button();
            this.btnGetProducts = new System.Windows.Forms.Button();
            this.btnGetCategories = new System.Windows.Forms.Button();
            this.btnGetSaleCard = new System.Windows.Forms.Button();
            this.btnGetCash = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnGetDaySale = new System.Windows.Forms.Button();
            this.btnGetMonth = new System.Windows.Forms.Button();
            this.lstReport = new System.Windows.Forms.ListBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBillTitle
            // 
            this.lblBillTitle.AutoSize = true;
            this.lblBillTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillTitle.Location = new System.Drawing.Point(710, -5);
            this.lblBillTitle.Name = "lblBillTitle";
            this.lblBillTitle.Size = new System.Drawing.Size(137, 83);
            this.lblBillTitle.TabIndex = 4;
            this.lblBillTitle.Text = "Fiş";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(968, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tarih :";
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillDate.Location = new System.Drawing.Point(1102, 36);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(0, 31);
            this.lblBillDate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(950, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fiş No :";
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillNo.Location = new System.Drawing.Point(1102, 67);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(0, 31);
            this.lblBillNo.TabIndex = 8;
            // 
            // lstBillProducts
            // 
            this.lstBillProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstBillProducts.FormattingEnabled = true;
            this.lstBillProducts.ItemHeight = 29;
            this.lstBillProducts.Location = new System.Drawing.Point(940, 112);
            this.lstBillProducts.Name = "lstBillProducts";
            this.lstBillProducts.Size = new System.Drawing.Size(354, 410);
            this.lstBillProducts.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(968, 577);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 33);
            this.label7.TabIndex = 12;
            this.label7.Text = "TOPLAM :";
            // 
            // lblBillTotalAmount
            // 
            this.lblBillTotalAmount.AutoSize = true;
            this.lblBillTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillTotalAmount.Location = new System.Drawing.Point(1148, 577);
            this.lblBillTotalAmount.Name = "lblBillTotalAmount";
            this.lblBillTotalAmount.Size = new System.Drawing.Size(32, 33);
            this.lblBillTotalAmount.TabIndex = 13;
            this.lblBillTotalAmount.Text = "0";
            // 
            // lblBillTotalKDV
            // 
            this.lblBillTotalKDV.AutoSize = true;
            this.lblBillTotalKDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillTotalKDV.Location = new System.Drawing.Point(1148, 616);
            this.lblBillTotalKDV.Name = "lblBillTotalKDV";
            this.lblBillTotalKDV.Size = new System.Drawing.Size(32, 33);
            this.lblBillTotalKDV.TabIndex = 17;
            this.lblBillTotalKDV.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1031, 616);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 33);
            this.label5.TabIndex = 18;
            this.label5.Text = "KDV :";
            // 
            // cmbBills
            // 
            this.cmbBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBills.FormattingEnabled = true;
            this.cmbBills.Location = new System.Drawing.Point(644, 238);
            this.cmbBills.Name = "cmbBills";
            this.cmbBills.Size = new System.Drawing.Size(217, 28);
            this.cmbBills.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(714, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fişler";
            // 
            // btnGetBill
            // 
            this.btnGetBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetBill.Location = new System.Drawing.Point(644, 306);
            this.btnGetBill.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetBill.Name = "btnGetBill";
            this.btnGetBill.Size = new System.Drawing.Size(230, 67);
            this.btnGetBill.TabIndex = 16;
            this.btnGetBill.Text = "Fişi Getir";
            this.btnGetBill.UseVisualStyleBackColor = true;
            this.btnGetBill.Click += new System.EventHandler(this.btnGetBill_Click);
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetProducts.Location = new System.Drawing.Point(37, 121);
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(230, 67);
            this.btnGetProducts.TabIndex = 19;
            this.btnGetProducts.Text = "Ürünleri Getir";
            this.btnGetProducts.UseVisualStyleBackColor = true;
            this.btnGetProducts.Click += new System.EventHandler(this.btnGetProducts_Click);
            // 
            // btnGetCategories
            // 
            this.btnGetCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetCategories.Location = new System.Drawing.Point(307, 121);
            this.btnGetCategories.Name = "btnGetCategories";
            this.btnGetCategories.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnGetCategories.Size = new System.Drawing.Size(230, 67);
            this.btnGetCategories.TabIndex = 20;
            this.btnGetCategories.Text = "Kategorilere Göre Ürün Getir";
            this.btnGetCategories.UseVisualStyleBackColor = true;
            this.btnGetCategories.Click += new System.EventHandler(this.btnGetCategories_Click);
            // 
            // btnGetSaleCard
            // 
            this.btnGetSaleCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetSaleCard.Location = new System.Drawing.Point(37, 216);
            this.btnGetSaleCard.Name = "btnGetSaleCard";
            this.btnGetSaleCard.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnGetSaleCard.Size = new System.Drawing.Size(230, 67);
            this.btnGetSaleCard.TabIndex = 21;
            this.btnGetSaleCard.Text = "Kredi Kartı İle Yapılan Satışları Getir";
            this.btnGetSaleCard.UseVisualStyleBackColor = true;
            this.btnGetSaleCard.Click += new System.EventHandler(this.btnGetSaleCard_Click);
            // 
            // btnGetCash
            // 
            this.btnGetCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetCash.Location = new System.Drawing.Point(307, 216);
            this.btnGetCash.Name = "btnGetCash";
            this.btnGetCash.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnGetCash.Size = new System.Drawing.Size(230, 67);
            this.btnGetCash.TabIndex = 22;
            this.btnGetCash.Text = "Nakit Yapılan Satışlar Getir";
            this.btnGetCash.UseVisualStyleBackColor = true;
            this.btnGetCash.Click += new System.EventHandler(this.btnGetCash_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDate.Location = new System.Drawing.Point(618, 121);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(270, 29);
            this.dtpDate.TabIndex = 23;
            // 
            // btnGetDaySale
            // 
            this.btnGetDaySale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetDaySale.Location = new System.Drawing.Point(37, 312);
            this.btnGetDaySale.Name = "btnGetDaySale";
            this.btnGetDaySale.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnGetDaySale.Size = new System.Drawing.Size(230, 67);
            this.btnGetDaySale.TabIndex = 24;
            this.btnGetDaySale.Text = "Günlük Satış Raporu";
            this.btnGetDaySale.UseVisualStyleBackColor = true;
            this.btnGetDaySale.Click += new System.EventHandler(this.btnGetDaySale_Click);
            // 
            // btnGetMonth
            // 
            this.btnGetMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetMonth.Location = new System.Drawing.Point(307, 312);
            this.btnGetMonth.Name = "btnGetMonth";
            this.btnGetMonth.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnGetMonth.Size = new System.Drawing.Size(230, 67);
            this.btnGetMonth.TabIndex = 25;
            this.btnGetMonth.Text = "Aylık Satış Rapor";
            this.btnGetMonth.UseVisualStyleBackColor = true;
            this.btnGetMonth.Click += new System.EventHandler(this.btnGetMonth_Click);
            // 
            // lstReport
            // 
            this.lstReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstReport.FormattingEnabled = true;
            this.lstReport.ItemHeight = 25;
            this.lstReport.Location = new System.Drawing.Point(39, 468);
            this.lstReport.Name = "lstReport";
            this.lstReport.Size = new System.Drawing.Size(822, 229);
            this.lstReport.TabIndex = 28;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSum.Location = new System.Drawing.Point(697, 77);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(0, 20);
            this.lblSum.TabIndex = 27;
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.lstReport);
            this.Controls.Add(this.lblSum);
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
        private System.Windows.Forms.Label lblBillTotalKDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBills;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetBill;
        private System.Windows.Forms.Button btnGetProducts;
        private System.Windows.Forms.Button btnGetCategories;
        private System.Windows.Forms.Button btnGetSaleCard;
        private System.Windows.Forms.Button btnGetCash;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnGetDaySale;
        private System.Windows.Forms.Button btnGetMonth;
        private System.Windows.Forms.ListBox lstReport;
        private System.Windows.Forms.Label lblSum;
    }
}