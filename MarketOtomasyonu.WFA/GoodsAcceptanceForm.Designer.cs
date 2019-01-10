namespace MarketOtomasyonu.WFA
{
    partial class GoodsAcceptanceForm
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
            this.dtGoodAcceptance = new System.Windows.Forms.DateTimePicker();
            this.lblGoodsAcceptanceList = new System.Windows.Forms.Label();
            this.lstGoodAcceptance = new System.Windows.Forms.ListBox();
            this.lblGoodAcceptanceTitle = new System.Windows.Forms.Label();
            this.btnOrderSave = new System.Windows.Forms.Button();
            this.lblGoodAcceptanceBarcode = new System.Windows.Forms.Label();
            this.cmbOrderProduct = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtGoodAcceptance
            // 
            this.dtGoodAcceptance.Location = new System.Drawing.Point(614, 12);
            this.dtGoodAcceptance.Name = "dtGoodAcceptance";
            this.dtGoodAcceptance.Size = new System.Drawing.Size(156, 20);
            this.dtGoodAcceptance.TabIndex = 21;
            // 
            // lblGoodsAcceptanceList
            // 
            this.lblGoodsAcceptanceList.AutoSize = true;
            this.lblGoodsAcceptanceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGoodsAcceptanceList.Location = new System.Drawing.Point(581, 117);
            this.lblGoodsAcceptanceList.Name = "lblGoodsAcceptanceList";
            this.lblGoodsAcceptanceList.Size = new System.Drawing.Size(174, 20);
            this.lblGoodsAcceptanceList.TabIndex = 18;
            this.lblGoodsAcceptanceList.Text = "Gelen Sipariş Listesi";
            // 
            // lstGoodAcceptance
            // 
            this.lstGoodAcceptance.FormattingEnabled = true;
            this.lstGoodAcceptance.Location = new System.Drawing.Point(395, 149);
            this.lstGoodAcceptance.Name = "lstGoodAcceptance";
            this.lstGoodAcceptance.Size = new System.Drawing.Size(375, 238);
            this.lstGoodAcceptance.TabIndex = 17;
            // 
            // lblGoodAcceptanceTitle
            // 
            this.lblGoodAcceptanceTitle.AutoSize = true;
            this.lblGoodAcceptanceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGoodAcceptanceTitle.Location = new System.Drawing.Point(248, 12);
            this.lblGoodAcceptanceTitle.Name = "lblGoodAcceptanceTitle";
            this.lblGoodAcceptanceTitle.Size = new System.Drawing.Size(229, 55);
            this.lblGoodAcceptanceTitle.TabIndex = 14;
            this.lblGoodAcceptanceTitle.Text = "Mal Kayıt";
            // 
            // btnOrderSave
            // 
            this.btnOrderSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrderSave.Location = new System.Drawing.Point(6, 268);
            this.btnOrderSave.Name = "btnOrderSave";
            this.btnOrderSave.Size = new System.Drawing.Size(349, 59);
            this.btnOrderSave.TabIndex = 11;
            this.btnOrderSave.Text = "Kaydet";
            this.btnOrderSave.UseVisualStyleBackColor = true;
            this.btnOrderSave.Click += new System.EventHandler(this.btnOrderSave_Click);
            // 
            // lblGoodAcceptanceBarcode
            // 
            this.lblGoodAcceptanceBarcode.AutoSize = true;
            this.lblGoodAcceptanceBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGoodAcceptanceBarcode.Location = new System.Drawing.Point(7, 201);
            this.lblGoodAcceptanceBarcode.Name = "lblGoodAcceptanceBarcode";
            this.lblGoodAcceptanceBarcode.Size = new System.Drawing.Size(161, 20);
            this.lblGoodAcceptanceBarcode.TabIndex = 23;
            this.lblGoodAcceptanceBarcode.Text = "Barkod Numarası : ";
            // 
            // cmbOrderProduct
            // 
            this.cmbOrderProduct.FormattingEnabled = true;
            this.cmbOrderProduct.Location = new System.Drawing.Point(183, 203);
            this.cmbOrderProduct.Name = "cmbOrderProduct";
            this.cmbOrderProduct.Size = new System.Drawing.Size(172, 21);
            this.cmbOrderProduct.TabIndex = 24;
            this.cmbOrderProduct.SelectedIndexChanged += new System.EventHandler(this.cmbOrderProduct_SelectedIndexChanged);
            // 
            // GoodsAcceptanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbOrderProduct);
            this.Controls.Add(this.lblGoodAcceptanceBarcode);
            this.Controls.Add(this.dtGoodAcceptance);
            this.Controls.Add(this.lblGoodsAcceptanceList);
            this.Controls.Add(this.lstGoodAcceptance);
            this.Controls.Add(this.lblGoodAcceptanceTitle);
            this.Controls.Add(this.btnOrderSave);
            this.Name = "GoodsAcceptanceForm";
            this.Text = "GoodsAcceptanceForm";
            this.Load += new System.EventHandler(this.GoodsAcceptanceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtGoodAcceptance;
        private System.Windows.Forms.Label lblGoodsAcceptanceList;
        private System.Windows.Forms.ListBox lstGoodAcceptance;
        private System.Windows.Forms.Label lblGoodAcceptanceTitle;
        private System.Windows.Forms.Button btnOrderSave;
        private System.Windows.Forms.Label lblGoodAcceptanceBarcode;
        private System.Windows.Forms.ComboBox cmbOrderProduct;
    }
}