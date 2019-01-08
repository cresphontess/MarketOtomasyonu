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
            PackageRepo db= new PackageRepo();
            var koliler = db.GetAll();


            if (koliler.Count != 0)
            {

                foreach (var item in koliler)
                {
                    if (txtOrderBarcode.Text != item.PackageBarcode.ToString())
                    {
                        GoodsAcceptanceDialogForm goodsAcceptanceDialogForm = new GoodsAcceptanceDialogForm();
                        goodsAcceptanceDialogForm.Show();
                    }
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

            

            Package package = new Package();

            package.PackageName = txtPackageName.Text;
            package.ProductId= (cmbOrderProduct.SelectedItem as Product).ProductId;
            package.PackagePurchasingPrice = Convert.ToInt32(txtOrderPackagePrice.Text);
            package.PackageProductQuantity = Convert.ToInt32(nmOrderQuantity.Value);

            db.Insert(package);

            var koliler = db.GetAll();

            lstOrder.DataSource = koliler;



        }
    }
}
