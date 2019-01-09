using MarketOtomasyonu.BLL.Repository;
using MarketOtomasyonu.Models.Entities;
using MarketOtomasyonu.WFA.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

             CategoryInsertingDialogForm CategoryInsertingDialogForm = new CategoryInsertingDialogForm();

             CategoryInsertingDialogForm.Show();

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
    }
}
