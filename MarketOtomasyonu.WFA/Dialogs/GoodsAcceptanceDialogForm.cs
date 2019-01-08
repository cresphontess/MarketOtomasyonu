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

namespace MarketOtomasyonu.WFA.Dialogs
{
    public partial class GoodsAcceptanceDialogForm : Form
    {
        public GoodsAcceptanceDialogForm()
        {
            InitializeComponent();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            new CategoryRepo().Insert(new Category()
            {
                CategoryName = txtCategory.Text
               
            });
            KategorileriGetir();
        }
        private void KategorileriGetir()
        {
            cmbCategory.DataSource = new CategoryRepo().GetAll();
            cmbCategory.DisplayMember = "CategoryName";
        }
        private void btnProductAdd_Click(object sender, EventArgs e)
        {
           
            try
            {
                using (var productRepo = new ProductRepo())
                {
                    productRepo.Insert(new Product()
                    {
                        CategoryId = (cmbCategory.SelectedItem as Category).CategoryId,
                         ProductName = txtProductName.Text,
                          ProductBarcode = txtProductBarcode.Text,
                           ProductPurchasingPrice=0,
                            ProductSellingPrice=0,
                             ProductStock=0
                               
                        
                    });
                }

                MessageBox.Show("Urun ekleme islemi basarili");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GoodsAcceptanceDialogForm_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem == null) return;
            Category cat = cmbCategory.SelectedItem as Category;
        }

       
    }
}
