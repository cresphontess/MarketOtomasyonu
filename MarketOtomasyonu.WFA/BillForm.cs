using MarketOtomasyonu.BLL.Repository;
using MarketOtomasyonu.Models.Entities;
using MarketOtomasyonu.Models.ViewModels;
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
            cmbBills.DataSource = new SaleDetailRepo().GetAll()
                 .Select(x => new BillCmbViewModel()
                 {
                     GivenAmount = x.GivenAmount,
                     PaymentType = x.PaymentType,
                     ProductId = x.ProductId,
                     ProductName = x.Product.ProductName,
                     ProductSellingPrice = x.ProductSellingPrice,
                     Quantity = x.Quantity,
                     ReceivedAmount = x.ReceivedAmount,
                     SaleDateTime = x.SaleDateTime,
                     SaleId = x.SaleId

                 }).Distinct().ToList();

          
        }

        private void btnGetBill_Click(object sender, EventArgs e)
        {
            if (cmbBills.SelectedItem==null)
            {
                return;
            }
            var seciliFis = (cmbBills.SelectedItem as BillCmbViewModel);

            lstBillProducts.DataSource = new SaleDetailRepo().GetAll(x=>x.SaleId==seciliFis.SaleId)
                .Select(x => new BillViewModel()
                {
                     SaleId=x.SaleId,
                      PaymentType=x.PaymentType ,
                       GivenAmount=x.GivenAmount ,
                        ProductId=x.ProductId ,
                         ProductName=x.Product.ProductName,
                          ProductSellingPrice=x.ProductSellingPrice,
                           Quantity=x.Quantity ,
                            ReceivedAmount=x.ReceivedAmount ,
                             SaleDateTime =x.SaleDateTime
                }).ToList();

            lblBillDate.Text =Convert.ToString( seciliFis.SaleDateTime);
            lblBillNo.Text = Convert.ToString(seciliFis.SaleId);

            var fisler = new SaleDetailRepo().GetAll();
            decimal toplam = 0,alinan=0,kdv=0;

            foreach (var item in fisler)
            {
                if (item.SaleId==seciliFis.SaleId)
                {
                    toplam += item.ProductSellingPrice;
                    alinan += (item.Product.ProductPurchasingPrice)*item.Quantity;
                }
            }
            kdv = toplam - alinan;
            lblBillTotalAmount.Text = Convert.ToString(toplam);
            lblBillTotalKDV.Text = Convert.ToString(kdv);
            

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
