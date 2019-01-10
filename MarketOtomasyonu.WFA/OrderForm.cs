using MarketOtomasyonu.BLL.Repository;
using MarketOtomasyonu.Models.Entities;
using MarketOtomasyonu.WFA.Dialogs;
using MarketOtomasyonu.WFA.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace MarketOtomasyonu.WFA
{
    public partial class OrderForm : Form
    {
       
        public OrderForm()
        {
            InitializeComponent();


        }

        int i = 1;

        private void btnBarcodeControl_Click(object sender, EventArgs e)
        {

             CategoryInsertingDialogForm CategoryInsertingDialogForm = new CategoryInsertingDialogForm();
             CategoryInsertingDialogForm.Show();

        }

        private void txtOrderBarcode_TextChanged(object sender, EventArgs e)
        {
            if(txtPackageBarcode.TextLength != 0)
            {
                btnNewProductAdd.Enabled = true;

            }
            else
            {
                btnNewProductAdd.Enabled = false;
            }
        }

        private void btnOrderSave_Click(object sender, EventArgs e)
        {
            PackageRepo db = new PackageRepo();
           
            try
            {
                Package package = new Package();


                package.PackageName = txtPackageName.Text;
                package.ProductId = (cmbPackageProduct.SelectedItem as Product).ProductId;
                package.OrderId = (cmbOrderName.SelectedItem as Order).OrderId;
                package.PackagePurchasingPrice = Convert.ToDecimal(txtOrderPackagePrice.Text);
                package.PackageProductQuantity = Convert.ToInt32(nmOrderQuantity.Value);
                package.PackageBarcode = txtPackageBarcode.Text;
                
                 

                db.Insert(package);

                PaketleriGetir();

                SiparisFiyatHesapla();

            }
            catch (Exception)
            {

                throw;
            }

            FormHelper.FormuTemizle(this);

        }

        private void SiparisFiyatHesapla()
        {
            PackageRepo db = new PackageRepo();

            decimal total = 0;

            foreach (var item in db.GetAll())
            {
                total += item.PackagePurchasingPrice;
            }

            lblOrderPriceText.Text = total.ToString();
        }

        private void PaketleriGetir()
        {
            
            lstOrder.DataSource = new PackageRepo().GetAll(x=>x.OrderId == (cmbOrderName.SelectedItem as Order).OrderId);
            lstOrder.DisplayMember = "PackageName";
            
        }

        private void UrunleriGetir()
        {
            cmbPackageProduct.DataSource = new ProductRepo().GetAll();
            cmbPackageProduct.DisplayMember = "ProductName";
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {

            FormHelper.FormuTemizle(this);
            UrunleriGetir();
            SiparisFiyatHesapla();
            cmbPackageProduct.SelectedIndex = -1;


        }

        private void cmbOrderProduct_DropDown(object sender, EventArgs e)
        {
            UrunleriGetir();
        }

        private void nmOrderQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (cmbPackageProduct.SelectedItem == null) return;
            

            txtOrderPackagePrice.Text = "0";
            txtOrderPackagePrice.Text = ((cmbPackageProduct.SelectedItem as Product).ProductPurchasingPrice * nmOrderQuantity.Value).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHelper.FormuTemizle(this);

            ReadOnly.UndoReadOnly(this);

            txtPackageBarcode.Visible = true;
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
            pbPackageBarcode.Image = barkod.CreateBitmap();
            txtPackageBarcode.Text = barkod.ToString();
            this.ActiveControl = txtPackageBarcode;
            txtPackageBarcode.Focus();
            txtPackageBarcode.Select(0, 0);
            txtPackageBarcode.SelectionStart = txtPackageBarcode.MaxLength;

            cmbPackageProduct.SelectedIndex = -1;
        }

        private string UrunKodu()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(50001, 99999);
            return sayi.ToString();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            
            OrderRepo db = new OrderRepo();
            Order order = new Order()
            {
                OrderName = "Sipariş" + i,
                OrderDateTime = dtOrder.Value
                
            };
            i++;

            db.Insert(order);

            cmbOrderName.DataSource = db.GetAll();

        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

            var seciliPaket = lstOrder.SelectedItem as Package;

            txtPackageBarcode.Text = seciliPaket.PackageBarcode.ToString();
            txtPackageName.Text = seciliPaket.PackageName.ToString();
            cmbPackageProduct.Text = seciliPaket.Product.ToString();
            nmOrderQuantity.Value = seciliPaket.PackageProductQuantity;
            txtOrderPackagePrice.Text = (seciliPaket.Product.ProductPurchasingPrice * seciliPaket.PackageProductQuantity).ToString();
        }

        private void cmbOrderName_DropDown(object sender, EventArgs e)
        {
            OrderRepo db = new OrderRepo();


            cmbOrderName.DataSource = db.GetAll();
            cmbOrderName.DisplayMember = "OrderName";
        }

        private void cmbOrderName_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            PaketleriGetir();
        }
    }
    
 }   

