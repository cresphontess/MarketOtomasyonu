using MarketOtomasyonu.BLL.Repository;
using MarketOtomasyonu.Models.Entities;
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
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }

        private void BillForm_Load(object sender, EventArgs e)
        {

            SaleRepo db = new SaleRepo();

            var sales = db.GetAll();

            foreach (var item in sales)
            {
                cmbBills.Items.Add(item);
            }


            
           
       
        }

        private void cmbBills_SelectedIndexChanged(object sender, EventArgs e)
        {

            SaleRepo saleRepo = new SaleRepo();
            SaleDetailRepo db = new SaleDetailRepo();

            var secilenSatis = cmbBills.SelectedItem as Sale;

            foreach (var item in saleRepo.GetAll())
            {
                if(item.SaleId == secilenSatis.SaleId)
                {

                    lblBillNo.Text = item.SaleId.ToString();

                    foreach (var item1 in item.SaleDetails.ToArray())
                    {
                        if(item1.SaleId == item.SaleId)
                        {
                            lblBillDate.Text = item1.SaleDateTime.ToString();
                            lstBillProducts.Items.Add(item1);
                            lblBillTotalAmount.Text = (item1.ProductSellingPrice + Convert.ToDecimal(lblBillTotalAmount.Text)).ToString();

                        }   

                    }
  
                }
            }

           
            

        }
    }
}
