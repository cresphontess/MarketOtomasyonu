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
                products.AddRange(new ProductRepo().GetAll(x=>x.ProductStock>0)
                    .OrderBy(x => x.ProductName)
                    .Select(x => new ProductViewModel()
                    {

                        ProductId = x.ProductId,
                        ProductName = x.ProductName,
                        CategoryId = x.CategoryId,
                        ProductBarcode = x.ProductBarcode,
                        ProductPurchasingUnitPrice = x.ProductPurchasingPrice,
                        ProductSellingPrice = x.ProductSellingPrice,
                        ProductStock = x.ProductStock,
                       
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

            var control = false;

            foreach (var item in products)
            {
                foreach (var item1 in lstProduct.Items)
                {

                    if ((cmbProductBarcode.SelectedItem as ProductViewModel).ProductId == (item1 as SepetViewModel).ProductId)
                    {
                        control = true;
                        break;
                    }
                }

                if (item.ProductId == (cmbProductBarcode.SelectedItem as ProductViewModel).ProductId)
                {
                    if (control == false)
                    {
                        lstProduct.Items.Add(item);
                        sepet.Add(item);

                        total += item.ProductSellingPrice;

                    }
                    else
                    {
                        MessageBox.Show("Bu ürün daha önce sepete eklenmiştir.");
                    }


                    lblTotalAmountText.Text = total.ToString();

                    control = false;
                    break;
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
               
                foreach (var item in sepet)
                {
                    item.PaymentType = i;
                    double poset = Convert.ToDouble(nudPochetteQuantity.Value) * 0.25;
                    var tutar1 = Convert.ToString(Convert.ToDecimal(lblTotalAmountText.Text));
                    if (rbSaleCreditCard.Checked == true)
                {
                    
                    txtSaleReceivedAmount.Text = Convert.ToString(Convert.ToDecimal(lblTotalAmountText.Text) + Convert.ToDecimal(poset));  
                    item.GivenAmount = (Convert.ToDecimal(lblTotalAmountText.Text)+ Convert.ToDecimal(poset));
                    item.GivenAmount = 0;
                    lblTotal.Text =  $"{tutar1:c2}+{poset:c2}";
                    }
                else
                {
                        item.GivenAmount = (Convert.ToDecimal(lblTotalAmountText.Text) + Convert.ToDecimal(poset));
                        item.ReceivedAmount = Convert.ToDecimal(txtSaleReceivedAmount.Text);        
                        lblSaleRemainAmountText.Text = (Convert.ToDecimal(txtSaleReceivedAmount.Text) - ((Convert.ToDecimal(lblTotalAmountText.Text) + Convert.ToDecimal(poset)))).ToString();
                        lblTotal.Text = $"{tutar1:c2}+{poset:c2}";
                    }
                    item.SaleId = sale.SaleId;
                    item.SaleDateTime = dtSale.Value;
                }



                var orderBusiness = new SaleBusines();
                var dbSale = new SaleDetailRepo();

                var cartModel = new CartViewModel()
                {
                    CartModel = sepet,

                };

                orderBusiness.MakeOrder(cartModel);
                
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ProductRepo db = new ProductRepo();

            foreach (var item in db.GetAll())
            {

                foreach (var item1 in lstProduct.Items)
                {
                    if (item.ProductId == (item1 as SepetViewModel).ProductId)
                    {
                        item.ProductStock = item.ProductStock - (item1 as SepetViewModel).Quantity;
                    }
                }
            }

            db.Update();
        }

        

     
        
        private SepetViewModel seciliSepet;

        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProduct.SelectedItem == null) return;
            seciliSepet = lstProduct.SelectedItem as SepetViewModel;
            nmQuantity.Value = seciliSepet.Quantity;
            
            ProductRepo db = new ProductRepo();

            foreach (var item in db.GetAll())
            {

                if (item.ProductId == (seciliSepet).ProductId)
                {
                    cmbProductBarcode.Text = (item.ProductBarcode) + " - " + item.ProductName;

                }

            }
        }

        private void rbSaleCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSaleCreditCard.Checked == true)
            {
                double poset = Convert.ToDouble(nudPochetteQuantity.Value) * 0.25;
                txtSaleReceivedAmount.Text = Convert.ToString(Convert.ToDecimal(lblTotalAmountText.Text) + Convert.ToDecimal(poset));
                lblSaleRemainAmountText.Text = "0";
            }
            else
            {
                // lblSaleRemainAmountText.Text = (Convert.ToDecimal(txtSaleReceivedAmount.Text) - Convert.ToDecimal(lblTotalAmountText.Text)).ToString();
            }
        }

        private void btnSaleUpdate_Click_1(object sender, EventArgs e)
        {
            seciliSepet = lstProduct.SelectedItem as SepetViewModel;
            foreach (var item in sepet)
            {
                if (seciliSepet.ProductId == item.ProductId)
                {

                    item.Quantity = Convert.ToInt32(nmQuantity.Value);
                    break;
                }
            }
            seciliSepet = null;
            lstProduct.Items.Clear();

            foreach (var item in sepet)
            {
                lstProduct.Items.Add(item);
            }
            var tutar = sepet.Sum(x => x.ProductSellingPrice * x.Quantity * Convert.ToDecimal(1 - x.Discount));
            lblTotalAmountText.Text = $" {tutar:c2}";
        }

        private void btnSaleDelete_Click_1(object sender, EventArgs e)
        {
            ProductRepo db = new ProductRepo();

            if (lstProduct.SelectedItem == null) return;

            var seciliSepet1 = lstProduct.SelectedItem as SepetViewModel;


            sepet.Remove(seciliSepet1);
            lstProduct.Items.Clear();


            lstProduct.Items.Clear();
            foreach (var item in sepet)
            {
                lstProduct.Items.Add(item);
            }


            var tutar = sepet.Sum(x => x.ProductSellingPrice * x.Quantity * Convert.ToDecimal(1 - x.Discount));
            lblTotalAmountText.Text = $" {tutar:c2}";
        }
    }
}
    

