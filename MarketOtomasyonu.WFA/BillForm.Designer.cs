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
            this.SuspendLayout();
            // 
            // lblBillTitle
            // 
            this.lblBillTitle.AutoSize = true;
            this.lblBillTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillTitle.Location = new System.Drawing.Point(427, 11);
            this.lblBillTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBillTitle.Name = "lblBillTitle";
            this.lblBillTitle.Size = new System.Drawing.Size(113, 69);
            this.lblBillTitle.TabIndex = 4;
            this.lblBillTitle.Text = "Fiş";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(413, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tarih :";
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillDate.Location = new System.Drawing.Point(500, 117);
            this.lblBillDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(70, 25);
            this.lblBillDate.TabIndex = 6;
            this.lblBillDate.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(399, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fiş No :";
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillNo.Location = new System.Drawing.Point(499, 145);
            this.lblBillNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(70, 25);
            this.lblBillNo.TabIndex = 8;
            this.lblBillNo.Text = "label4";
            // 
            // lstBillProducts
            // 
            this.lstBillProducts.FormattingEnabled = true;
            this.lstBillProducts.ItemHeight = 16;
            this.lstBillProducts.Location = new System.Drawing.Point(331, 183);
            this.lstBillProducts.Margin = new System.Windows.Forms.Padding(4);
            this.lstBillProducts.Location = new System.Drawing.Point(259, 155);
            this.lstBillProducts.Name = "lstBillProducts";
            this.lstBillProducts.Size = new System.Drawing.Size(597, 276);
            this.lstBillProducts.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(399, 522);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Location = new System.Drawing.Point(321, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "TOPLAM :";
            // 
            // lblBillTotalAmount
            // 
            this.lblBillTotalAmount.AutoSize = true;
            this.lblBillTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillTotalAmount.Location = new System.Drawing.Point(524, 522);
            this.lblBillTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBillTotalAmount.Location = new System.Drawing.Point(415, 398);
            this.lblBillTotalAmount.Name = "lblBillTotalAmount";
            this.lblBillTotalAmount.Size = new System.Drawing.Size(70, 25);
            this.lblBillTotalAmount.Size = new System.Drawing.Size(19, 20);
            this.lblBillTotalAmount.TabIndex = 13;
            this.lblBillTotalAmount.Text = "0";
            // 
            // cmbBills
            // 
            this.cmbBills.FormattingEnabled = true;
            this.cmbBills.Location = new System.Drawing.Point(13, 134);
            this.cmbBills.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBills.Name = "cmbBills";
            this.cmbBills.Size = new System.Drawing.Size(288, 24);
            this.cmbBills.TabIndex = 14;
            this.cmbBills.SelectedIndexChanged += new System.EventHandler(this.cmbBills_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(118, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fişler";
            // 
            // btnGetBill
            // 
            this.btnGetBill.Location = new System.Drawing.Point(13, 183);
            this.btnGetBill.Name = "btnGetBill";
            this.btnGetBill.Size = new System.Drawing.Size(288, 45);
            this.btnGetBill.TabIndex = 16;
            this.btnGetBill.Text = "Fişi Getir";
            this.btnGetBill.UseVisualStyleBackColor = true;
            this.btnGetBill.Click += new System.EventHandler(this.btnGetBill_Click);
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 569);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}