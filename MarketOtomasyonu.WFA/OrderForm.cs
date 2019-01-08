using MarketOtomasyonu.BLL.Repository;
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
    }
}
