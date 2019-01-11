using MarketOtomasyonu.BLL.BLL;
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
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
        }
        private List<SepetViewModel> sepet = new List<SepetViewModel>();
        private void SaleForm_Load(object sender, EventArgs e)
        {
            var products = new List<ProductViewModel>();
            try
            {
                products.AddRange(new ProductRepo().GetAll()
                    .OrderBy(x => x.ProductName)
                    .Select(x => new ProductViewModel()
                    {

                         ProductId=x.ProductId,
                          ProductName=x.ProductName,
                           CategoryId=x.CategoryId,
                            ProductBarcode=x.ProductBarcode ,
                             ProductPurchasingPrice=x.ProductPurchasingPrice ,
                              ProductSellingPrice=x.ProductSellingPrice ,
                               ProductStock = x.ProductStock 

                    }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmbProductBarcode.DataSource = products;
        }

        private void btnSaleProductPass_Click(object sender, EventArgs e)
        {
            var products = new List<SepetViewModel>();
            try
            {
                products.AddRange(new ProductRepo().GetAll()
                    .OrderBy(x => x.ProductName)
                    .Select(x => new SepetViewModel()
                    {
                        ProductId = x.ProductId,
                        ProductName = x.ProductName,

                    }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (var item in products)
            {
                if(item.ProductId == (cmbProductBarcode.SelectedItem as ProductViewModel).ProductId)
                {
                    lstProduct.Items.Add(item);
                }
            }

        }
       

       

        private void btnSaleBill_Click(object sender, EventArgs e)
        {
            var sale = new Sale()
            {

            };
            new SaleRepo().Insert(sale);



            //if (!sepet.Any())
            //{
            //    MessageBox.Show("Lutfen sepete urun ekleyiniz");
            //    return;
            //}

            try
            {
                List<RadioButton> radioButtons = new List<RadioButton>();
                radioButtons.Add(rbSaleCash);
                radioButtons.Add(rbSaleCreditCard);

                RadioButton seciliButton;
                int i = 0;

                foreach (var item in radioButtons)
                {
                    if (item.Checked == true)
                    {
                        seciliButton = item;

                        if (seciliButton.Text == "Nakit")
                            i = 0;
                        else
                            i = 1;
                        break;
                    }

                
                }
                var orderBusiness = new SaleBusines();
                var dbSale = new SaleDetailRepo();
                var cartModel = new CartViewModel()
                {
                    CartModel = sepet,
                    
                };
                SaleDetail siparis = new SaleDetail ();
                siparis.SaleId = sale.SaleId;
                siparis.ProductId = (cmbProductBarcode.SelectedItem as ProductViewModel).ProductId;
                siparis.Quantity = (int)nmQuantity.Value;
                siparis.GivenAmount = 5;
                siparis.PaymentType = i;
                siparis.ReceivedAmount = Convert.ToDecimal(txtSaleGivenAmount.Text);
                siparis.SaleAmount = 5;
                dbSale.Insert(siparis);

                var sipNo = orderBusiness.MakeOrder(cartModel);
                
                sepet = new List<SepetViewModel>();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
