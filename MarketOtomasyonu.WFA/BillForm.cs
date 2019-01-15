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

                 }).ToList();

            //var fisler = new SaleDetailRepo().GetAll();

            //var fis = from f in fisler
            //                                                group new
            //                  {
            //                      f


            //                  } by new
            //                  {
            //                   f.SaleId

            //                  }
            //            into gp
            //                  orderby gp.Key.SaleId ascending
            //                  select new
            //                  {
            //                      SaleId = gp.Key.SaleId,


            //                  };
            //cmbBills.DataSource = fis.ToList();
        }

        private void btnGetBill_Click(object sender, EventArgs e)
        {
            if (cmbBills.SelectedItem == null)
            {
                return;
            }

            var seciliFis = (cmbBills.SelectedItem as BillCmbViewModel);

            lstBillProducts.DataSource = new SaleDetailRepo().GetAll(x => x.SaleId == seciliFis.SaleId)
                .Select(x => new BillViewModel()
                {
                    SaleId = x.SaleId,
                    PaymentType = x.PaymentType,
                    GivenAmount = x.GivenAmount,
                    ProductId = x.ProductId,
                    ProductName = x.Product.ProductName,
                    ProductSellingPrice = x.ProductSellingPrice,
                    Quantity = x.Quantity,
                    ReceivedAmount = x.ReceivedAmount,
                    SaleDateTime = x.SaleDateTime
                }).ToList();

            lblBillDate.Text = Convert.ToString(seciliFis.SaleDateTime);
            lblBillNo.Text = Convert.ToString(seciliFis.SaleId);

            var fisler = new SaleDetailRepo().GetAll();
            decimal toplam = 0, alinan = 0, kdv = 0;

            foreach (var item in fisler)
            {
                if (item.SaleId == seciliFis.SaleId)
                {
                    toplam += item.ProductSellingPrice;
                    alinan += (item.Product.ProductPurchasingPrice) * item.Quantity;
                }
            }
            kdv = toplam - alinan;
            lblBillTotalAmount.Text = Convert.ToString(toplam);
            lblBillTotalKDV.Text = Convert.ToString(kdv);

        }

        private void btnGetProducts_Click(object sender, EventArgs e)
        {
            var urun = new ProductRepo().GetAll();

           
            var urunler = urun
                          .Select(x => new ProductStockViewModel
                          {
                              ProductId = x.ProductId,
                              ProductName = x.ProductName,
                              CategoryId = x.CategoryId,
                              ProductBarcode = x.ProductBarcode,
                              ProductPurchasingUnitPrice = x.ProductPurchasingPrice,
                              ProductSellingPrice = x.ProductSellingPrice,
                              ProductStock = x.ProductStock
                          }).ToList();

           lstReport.DataSource = urunler;


        }

        private void btnGetCategories_Click(object sender, EventArgs e)
        {

            var urun = new ProductRepo().GetAll();
            var kategori = new CategoryRepo().GetAll();
            var kategoriler = from p in urun
                              join k in kategori on p.CategoryId equals k.CategoryId

                              group new
                              {
                                  p,
                                  k


                              } by new
                              {
                                  k.CategoryName

                              }
                         into gp
                              orderby gp.Key.CategoryName ascending
                              select new
                              {
                                  CategoryName = gp.Key.CategoryName,

                                  Total = gp.Sum(x => x.p.ProductStock)
                              };

            lstReport.DataSource = kategoriler.ToList();
        }

        private void btnGetSaleCard_Click(object sender, EventArgs e)
        {
            var satis = new SaleDetailRepo().GetAll();
            var satis1 = new SaleDetailRepo().GetAll(x => x.PaymentType == 1);
            var satislar = from s in satis
                           where s.PaymentType == 1
                           group new
                           {
                               s


                           } by new
                           {
                               s.SaleId

                           }
                          into gp
                           orderby gp.Key.SaleId ascending
                           select new
                           {
                               SaleId = gp.Key.SaleId,

                               Total = gp.Sum(x => x.s.Product.ProductSellingPrice * x.s.Quantity)
                           };
            decimal sum = 0;
            foreach (var item in satis1)
            {
                sum += (item.ProductSellingPrice);
            }
            lblSum.Text = Convert.ToString(sum);
            lstReport.DataSource = satislar.ToList();
        }

        private void btnGetCash_Click(object sender, EventArgs e)
        {
            var satis = new SaleDetailRepo().GetAll();
            var satis1 = new SaleDetailRepo().GetAll(x => x.PaymentType == 0);
            var satislar = from s in satis
                           where s.PaymentType == 0
                           group new
                           {
                               s


                           } by new
                           {
                               s.SaleId

                           }
                          into gp
                           orderby gp.Key.SaleId ascending
                           select new
                           {
                               SaleId = gp.Key.SaleId,

                               Total = gp.Sum(x => x.s.Product.ProductSellingPrice * x.s.Quantity)
                           };
            decimal sum = 0;
            foreach (var item in satis1)
            {
                sum += (item.ProductSellingPrice);
            }
            lblSum.Text = Convert.ToString(sum);
            lstReport.DataSource = satislar.ToList();
        }

        private void btnGetDaySale_Click(object sender, EventArgs e)
        {
            var satis = new SaleDetailRepo().GetAll();

            var satislar2 = from s in satis
                            where s.SaleDateTime.Day == dtpDate.Value.Day && s.SaleDateTime.Year == dtpDate.Value.Year && s.SaleDateTime.Month == dtpDate.Value.Month

                            select new
                            {

                                s.SaleId,
                                s.GivenAmount,
                                s.ReceivedAmount,
                                s.SaleDateTime,

                            };
            lstReport.DataSource = satislar2.ToList();
        }

        private void btnGetMonth_Click(object sender, EventArgs e)
        {
            var satis = new SaleDetailRepo().GetAll();
            DateTime BirAyOncesi = dtpDate.Value.AddMonths(-1);
            DateTime girilenTarih = dtpDate.Value;
            var satislar2 = from s in satis
                            where s.SaleDateTime < girilenTarih && s.SaleDateTime > BirAyOncesi

                            select new
                            {

                                s.SaleId,
                                s.GivenAmount,
                                s.ReceivedAmount,
                                s.SaleDateTime,

                            };
            lstReport.DataSource = satislar2.ToList();
        }
    }
}
