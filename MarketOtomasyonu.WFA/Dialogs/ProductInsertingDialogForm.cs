using MarketOtomasyonu.BLL.Repository;
using MarketOtomasyonu.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu.WFA.Dialogs
{
    public partial class ProductInsertingDialogForm : Form
    {
        public ProductInsertingDialogForm()
        {
            InitializeComponent();
        }

        
        private void KategorileriGetir()
        {
            cmbCategory.DataSource = new CategoryRepo().GetAll();
            cmbCategory.DisplayMember = "CategoryName";
        }
        private void btnProductAdd_Click(object sender, EventArgs e)
        {
           
            try
            {
                using (var productRepo = new ProductRepo())
                {
                    productRepo.Insert(new Product()
                    {
                        CategoryId = (cmbCategory.SelectedItem as Category).CategoryId,
                         ProductName = txtProductName.Text,
                          ProductBarcode = txtProductBarcode.Text,
                           ProductPurchasingPrice= Convert.ToDecimal(txtProductPurchasingPrice.Text),
                            ProductSellingPrice=0,
                             ProductStock=0
                               
                        
                    });
                }

                MessageBox.Show("Urun ekleme islemi basarili");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GoodsAcceptanceDialogForm_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem == null) return;
            Category cat = cmbCategory.SelectedItem as Category;
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            txtProductBarcode.Visible = true;
            PrintDocument doc = new PrintDocument();
            MarketOtomasyonu.WFA.Barcode.Ean13 barkod = new MarketOtomasyonu.WFA.Barcode.Ean13();

            barkod.Height = 20f;
            barkod.Width = 50f;
            barkod.FontSize = 12f;
            //bu kod barkodun ilk 2 hanesi -ülke kodu
            barkod.CountryCode = "90";
            //Bu kod üretici-imalatçı numarası -bu kısımın legal illegal gibi durumları da var
            barkod.ManufacturerCode = "95525";
            //Bu kod ürün kodu
            barkod.ProductCode = UrunKodu();
            //Bu kısım boş geçilsede birşey değişmiyor EAN-13 te zaten 12 veri okuyorsunuz ,bu sayı  barkodun sonunda oluyor. kontrol kodu
            barkod.ChecksumDigit = "0";
            pbBarcode.Image = barkod.CreateBitmap();
            txtProductBarcode.Text = barkod.ToString();
            this.ActiveControl = txtProductBarcode;
            txtProductBarcode.Focus();
            txtProductBarcode.Select(0, 0);
            txtProductBarcode.SelectionStart = txtProductBarcode.MaxLength;
        }

        private string UrunKodu()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(10000, 50000);
            return sayi.ToString();
        }

        private void txtProductBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                MessageBox.Show("Barkod okundu");
            }
        }
    }
}

