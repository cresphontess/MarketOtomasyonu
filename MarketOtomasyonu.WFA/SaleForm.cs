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
                             ProductPurchasingUnitPrice=x.ProductPurchasingPrice,
                              ProductSellingPrice=x.ProductSellingPrice ,
                               ProductStock = x.ProductStock 

                    }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmbProductBarcode.DataSource = products;

            lblTotalAmountText.Text = "0";
        }

        private void btnSaleProductPass_Click(object sender, EventArgs e)
        {

            decimal total = Convert.ToDecimal(lblTotalAmountText.Text);

            var products = new List<SepetViewModel>();
            try
            {
                products.AddRange(new ProductRepo().GetAll()
                    .OrderBy(x => x.ProductName)
                    .Select(x => new SepetViewModel()
                    {
                        ProductId = x.ProductId,
                        ProductName = x.ProductName,
                        Quantity = Convert.ToInt32(nmQuantity.Value),
                        ProductSellingPrice = nmQuantity.Value * x.ProductSellingPrice

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
                    sepet.Add(item);

                    total += item.ProductSellingPrice;
                }

                lblTotalAmountText.Text = total.ToString();
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

                foreach (var item in sepet)
                {
                    item.PaymentType = i;
                    item.GivenAmount = (Convert.ToDecimal(txtSaleReceivedAmount.Text) - Convert.ToDecimal(lblTotalAmountText.Text)); 
                    item.ReceivedAmount = Convert.ToDecimal(txtSaleReceivedAmount.Text);
                    item.SaleId = sale.SaleId;

            }

                lblSaleRemainAmountText.Text = (Convert.ToDecimal(txtSaleReceivedAmount.Text) - Convert.ToDecimal(lblTotalAmountText.Text)).ToString();

                var orderBusiness = new SaleBusines();
                var dbSale = new SaleDetailRepo();

                var cartModel = new CartViewModel()
                {
                    CartModel = sepet,
                    
                };

                var sipNo = orderBusiness.MakeOrder(cartModel);
                
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSaleGivenAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
