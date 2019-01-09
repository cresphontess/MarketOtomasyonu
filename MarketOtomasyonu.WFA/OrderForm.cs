using MarketOtomasyonu.BLL.Repository;
using MarketOtomasyonu.Models.Entities;
using MarketOtomasyonu.WFA.Dialogs;
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
            PackageRepo db = new PackageRepo();
            var koliler = db.GetAll();

            bool control = false;


            if (koliler.Count != 0)
            {

                foreach (var item in koliler)
                {
                    if (txtOrderBarcode.Text == item.PackageBarcode.ToString())
                    {
                        control = true;
                        break;
                    }
                   
                }

                if(control == false)
                {
                    GoodsAcceptanceDialogForm goodsAcceptanceDialogForm = new GoodsAcceptanceDialogForm();
                    goodsAcceptanceDialogForm.Show();
                }
                else
                {
                    MessageBox.Show($"{txtOrderBarcode} numaralı paketiniz mevcuttur.");
                }
            }
            else
            {
                GoodsAcceptanceDialogForm goodsAcceptanceDialogForm = new GoodsAcceptanceDialogForm();
                goodsAcceptanceDialogForm.Show();
            }
        }

        private void txtOrderBarcode_TextChanged(object sender, EventArgs e)
        {
            if(txtOrderBarcode.TextLength != 0)
            {
                btnBarcodeControl.Enabled = true;

            }
            else
            {
                btnBarcodeControl.Enabled = false;
            }
        }

        private void btnOrderSave_Click(object sender, EventArgs e)
        {
            PackageRepo db = new PackageRepo();
            OrderDetailRepo dbOrderDetail = new OrderDetailRepo();
            OrderDetail orderDetail = new OrderDetail();
           

            try
            {
                Package package = new Package();


                package.PackageName = txtPackageName.Text;
                package.ProductId = (cmbOrderProduct.SelectedItem as Product).ProductId;
                package.PackagePurchasingPrice = Convert.ToDecimal(txtOrderPackagePrice.Text);
                package.PackageProductQuantity = Convert.ToInt32(nmOrderQuantity.Value);
                package.PackageBarcode = txtOrderBarcode.Text;
                

                db.Insert(package);
                orderDetail.PackageId = package.PackageId;
                dbOrderDetail.Insert(orderDetail);

                var packages = db.GetAll();

                lstOrder.DataSource = packages;
                lstOrder.DisplayMember = "PackageName";
            }
            catch (Exception)
            {

                throw;
            }



        }
        private void UrunleriGetir()
        {
            cmbOrderProduct.DataSource = new ProductRepo().GetAll();
            cmbOrderProduct.DisplayMember = "ProductName";
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            UrunleriGetir();
        }

        private void cmbOrderProduct_DropDown(object sender, EventArgs e)
        {
            UrunleriGetir();
        }

        private void nmOrderQuantity_ValueChanged(object sender, EventArgs e)
        {
            txtOrderPackagePrice.Text = "0";
            txtOrderPackagePrice.Text = ((cmbOrderProduct.SelectedItem as Product).ProductPurchasingPrice * nmOrderQuantity.Value).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOrderBarcode.Visible = true;
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
            txtOrderBarcode.Text = barkod.ToString();
            this.ActiveControl = txtOrderBarcode;
            txtOrderBarcode.Focus();
            txtOrderBarcode.Select(0, 0);
            txtOrderBarcode.SelectionStart = txtOrderBarcode.MaxLength;
        }

        private string UrunKodu()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(50001, 99999);
            return sayi.ToString();
        }
    }
    }

