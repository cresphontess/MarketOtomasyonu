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
            
        }
    }
}
