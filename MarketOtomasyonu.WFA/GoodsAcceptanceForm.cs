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
    public partial class GoodsAcceptanceForm : Form
    {
        public GoodsAcceptanceForm()
        {
            InitializeComponent();
        }

        private void GoodsAcceptanceForm_Load(object sender, EventArgs e)
        {

            OrderRepo db = new OrderRepo();

            var cmbOrders = db.GetAll();

            cmbGoodsAcceptanceOrders.DataSource = cmbOrders.ToArray();

        }

        private void cmbOrderProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
        private void btnOrderSave_Click(object sender, EventArgs e)
        {

            bool control = false;

            var products = new List<PackageViewModel>();
            Package package = new Package();
         var seciliPaket=((cmbOrderProduct.SelectedItem as OrderViewModel).PackageId);

            try
            {
                products.AddRange(new PackageRepo().GetAll()
                    .OrderBy(x => x.PackageName)    
                    .Where(x=>x.PackageId==seciliPaket)
                    .Select(x => new PackageViewModel()
                    {
                         
                        PackageName = x.PackageName,
                        PackageBarcode = x.PackageBarcode,
                         PackageProductQuantity=x.PackageProductQuantity

                    }));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (var item in products)
            {
                lstGoodAcceptance.Items.Add(item);
            }


            var orders = new List<OrderViewModel>();
            try
            {
                orders.AddRange(new PackageRepo().GetAll()
                    .OrderBy(x => x.PackageName)
                    .Select(x => new OrderViewModel()
                    {

                        PackageName = x.PackageName,
                        PackageBarcode = x.PackageBarcode,
                        PackageId = x.PackageId

                    }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            PackageRepo pr = new PackageRepo();
            ProductRepo prodb = new ProductRepo();
            var seciliPaket1 = cmbOrderProduct.SelectedItem as OrderViewModel;

            foreach (var item in pr.GetAll())
            {

                if (seciliPaket1.ProductId == item.Product.ProductId)
                {

                    foreach (var item2 in prodb.GetAll())
                    {
                        if (item2.ProductId == seciliPaket1.ProductId)
                        {
                            item2.ProductStock += seciliPaket1.PackageProductQuantity;
                            item2.ProductSellingPrice = (item2.ProductPurchasingPrice * (1 + 0.18m));
                        }
                    }

                }

                
            }

            pr.Update();
            prodb.Update();


            cmbOrderProduct.DataSource = new List<Package>();
          
            PackageRepo db = new PackageRepo();



            var orders1 = db.GetAll(x => x.OrderId == (cmbGoodsAcceptanceOrders.SelectedItem as Order).OrderId);

            foreach (var item in orders)
            {
                foreach (var item1 in orders1)
                {

                    if (item.PackageId == seciliPaket && item.PackageId == item1.PackageId)
                    {

                        orders.Remove(item);
                        db.Delete(item1);
                        control = true;
                        break;
                    }
                }
                
                if(control == true)
                {
                    break;
                }
            }

            control = false;
            db.Update();
            cmbOrderProduct.DataSource = orders;


            cmbOrderProduct.SelectedIndex = -1;


        }

        private void cmbGoodsAcceptanceOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
  
            var orders = new List<OrderViewModel>();
            try
            {
                orders.AddRange(new PackageRepo().GetAll(x => x.OrderId == (cmbGoodsAcceptanceOrders.SelectedItem as Order).OrderId)
                    .OrderBy(x => x.PackageName)
                    .Select(x => new OrderViewModel()
                    {

                        PackageName = x.PackageName,
                        PackageBarcode = x.PackageBarcode,
                        PackageId = x.PackageId,
                        ProductId = x.Product.ProductId,
                        ProductStock = x.Product.ProductStock,
                        PackageProductQuantity = x.PackageProductQuantity



                    }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmbOrderProduct.DataSource = orders;


        }

        private void cmbGoodsAcceptanceOrders_DropDown(object sender, EventArgs e)
        {
            
        }
    }
}
