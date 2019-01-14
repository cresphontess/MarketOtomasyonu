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
            bool varMi = false;

            PackageRepo db = new PackageRepo();
            OrderRepo dbOrder = new OrderRepo();
           
            try
            {
                Package package = new Package();


                package.PackageName = txtPackageName.Text;
                package.ProductId = (cmbPackageProduct.SelectedItem as Product).ProductId;
                package.OrderId = (cmbOrderName.SelectedItem as Order).OrderId;
                package.PackagePurchasingPrice = Convert.ToDecimal(txtOrderPackagePrice.Text);
                package.PackageProductQuantity = Convert.ToInt32(nmOrderQuantity.Value);
                package.PackageBarcode = txtPackageBarcode.Text;


                foreach (var item in lstOrder.Items)
                {
                    if (package.PackageBarcode == (item as Package).PackageBarcode || package.PackageName == (item as Package).PackageName)
                    {
                        varMi = true;
                        break;
                    }

                }
                 
                if(varMi == false)
                {
                    db.Insert(package);
                    MessageBox.Show("Sipariş sepetine yeni ürün eklenmiştir.");
                }
                else
                {
                    MessageBox.Show("Seçili olan siparişte bu ürün zaten mevcuttur.");
                }
                
                dbOrder.Update();

                PaketleriGetir();

                SiparisFiyatHesapla();

            }
            catch (Exception)
            {

                throw;
            }

            dbOrder.Update();
            db.Update();

        }

        private void SiparisFiyatHesapla()
        {

            if (cmbOrderName.SelectedIndex == -1) return;

            PackageRepo db = new PackageRepo();
            OrderRepo dbOrder = new OrderRepo();
            
            

            foreach (var item1 in dbOrder.GetAll())
            {
                decimal total = 0;

                if (cmbOrderName.SelectedItem.ToString() == item1.OrderName.ToString())
                {
                    foreach (var item in db.GetAll())
                    {
                        if(item.OrderId == (cmbOrderName.SelectedItem as Order).OrderId)
                             total += item.PackagePurchasingPrice;
                    }

                    lblOrderPriceText.Text = total.ToString();
                    break;
                }
               
                
            }

            

         
        }

        private void PaketleriGetir()
        {
            lstOrder.Items.Clear();
            lstOrder.Items.AddRange(new PackageRepo().GetAll(x=>x.OrderId == (cmbOrderName.SelectedItem as Order).OrderId).ToArray());
            lstOrder.DisplayMember = "PackageName";
            
        }

        private void UrunleriGetir()
        {
            cmbPackageProduct.DataSource = new ProductRepo().GetAll();
            cmbPackageProduct.DisplayMember = "ProductName";
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {

            
            UrunleriGetir();

            OrderRepo db = new OrderRepo();

            cmbOrderName.DataSource = db.GetAll();
            cmbOrderName.DisplayMember = "OrderName";


            cmbPackageProduct.SelectedIndex = -1;
            cmbOrderName.SelectedIndex = -1;
            lstOrder.SelectedIndex = -1;

            FormHelper.FormuTemizle(this);
            lstOrder.Items.Clear();
            lblOrderPriceText.Text = "0";
                


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
            bool varMi = false;

            OrderRepo db = new OrderRepo();

            foreach (var item in db.GetAll())
            {
                if(item.OrderName.ToLower() == txtOrderName.Text.ToLower())
                {
                    varMi = true;
                    break;
                }
            }


            if (varMi == false)
            {
                Order order = new Order()
                {

                    OrderName = txtOrderName.Text,

                };

                db.Insert(order);
                MessageBox.Show("Yeni Sipariş Eklendi");

            }
            else
            {
                MessageBox.Show("Bu isimde başka bir siparişiniz zaten mevcuttur.");
            }


            cmbOrderName.DataSource = db.GetAll();

            FormHelper.FormuTemizle(this);
            cmbPackageProduct.SelectedIndex = -1;

            cmbOrderName.SelectedIndex = cmbOrderName.Items.Count - 1;

        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOrder.SelectedIndex == -1) return;
            FormControlleriDoldur();
            SiparisFiyatHesapla();
        }

        private void FormControlleriDoldur()
        {

            PackageRepo db = new PackageRepo();

            var seciliPaket = lstOrder.SelectedItem as Package;

            foreach (var item in db.GetAll())
            {
                if (item.ProductId == seciliPaket.ProductId)
                {
                    seciliPaket.Product = item.Product;
                    break;
                }
            }

            txtPackageBarcode.Text = seciliPaket.PackageBarcode.ToString();
            txtPackageName.Text = seciliPaket.PackageName.ToString();
            cmbPackageProduct.SelectedIndex = -1;
            cmbPackageProduct.Text = seciliPaket.Product.ProductName.ToString();
            nmOrderQuantity.Value = seciliPaket.PackageProductQuantity;
            txtOrderPackagePrice.Text = (seciliPaket.Product.ProductPurchasingPrice * seciliPaket.PackageProductQuantity).ToString();


        }

        private void cmbOrderName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrderName.SelectedIndex == -1) return;
            
            PaketleriGetir();
            SiparisFiyatHesapla();
            FormHelper.FormuTemizle(this);
            cmbPackageProduct.SelectedIndex = -1;
 }

       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            PackageRepo db = new PackageRepo();

            if (lstOrder.SelectedIndex == -1) return;
            var seciliPaketSil = lstOrder.SelectedItem as Package;

            foreach (var item in db.GetAll())
            {
                if (item.OrderId == seciliPaketSil.OrderId)
                {
                    db.Delete(seciliPaketSil);
                    break;
                }
            }

            lstOrder.Items.Clear();
            lstOrder.Items.AddRange(db.GetAll(x => x.OrderId == (cmbOrderName.SelectedItem as Order).OrderId).ToArray());

            FormHelper.FormuTemizle(this);
            cmbPackageProduct.SelectedIndex = -1;
            SiparisFiyatHesapla();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedIndex == -1) return;

            PackageRepo packagedb = new PackageRepo();
            ProductRepo productdb = new ProductRepo();

            var seciliPaketGuncelle = lstOrder.SelectedItem as Package;

            foreach (var item in packagedb.GetAll())
            {
                if (item.ProductId == seciliPaketGuncelle.ProductId)
                {
                    foreach (var item2 in productdb.GetAll())
                    {
                        if (item2.ProductId == seciliPaketGuncelle.ProductId)
                        {

                            item2.ProductStock = Convert.ToInt32(nmOrderQuantity.Value);
                            item2.ProductSellingPrice = (item2.ProductPurchasingPrice * (1 + 0.18m));
                            
                        }
                    }

                    break;
                }
            }
            seciliPaketGuncelle.PackageName = txtPackageName.Text;
            seciliPaketGuncelle.ProductId = (cmbPackageProduct.SelectedItem as Product).ProductId;
            seciliPaketGuncelle.OrderId = (cmbOrderName.SelectedItem as Order).OrderId;
            seciliPaketGuncelle.PackagePurchasingPrice = Convert.ToDecimal(txtOrderPackagePrice.Text);
            seciliPaketGuncelle.PackageProductQuantity = Convert.ToInt32(nmOrderQuantity.Value);
            seciliPaketGuncelle.PackageBarcode = txtPackageBarcode.Text;


            SiparisFiyatHesapla();
            packagedb.Update();
            productdb.Update();

            PaketleriGetir();

            MessageBox.Show($"Güncelleme başarılı");

            



        }

        private void cmbOrderName_DropDown(object sender, EventArgs e)
        {
            SiparisFiyatHesapla();
        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            OrderRepo db = new OrderRepo();
            if (cmbOrderName.SelectedIndex == -1) return;
            var seciliOrder = cmbOrderName.SelectedItem as Order;
            foreach (var item in db.GetAll())
            {
                if (item.OrderId == seciliOrder.OrderId)
                {
                    db.Delete(seciliOrder);
                    cmbOrderName.Text = "";
                    break;
                }
            }

            cmbOrderName.DataSource = db.GetAll();
            lstOrder.Items.Clear();
            lstOrder.Items.AddRange(new PackageRepo().GetAll(x => x.OrderId == (cmbOrderName.SelectedItem as Order).OrderId).ToArray());
            SiparisFiyatHesapla();

            if(cmbOrderName.Items.Count == 0)
            {
                lblOrderPriceText.Text = "0";
            }
        }
    }

  
    }
    
    
 

