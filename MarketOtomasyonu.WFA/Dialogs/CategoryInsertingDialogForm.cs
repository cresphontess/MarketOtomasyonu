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
    public partial class CategoryInsertingDialogForm : Form
    {
        public CategoryInsertingDialogForm()
        {
            InitializeComponent();
        }

        private void btnCategoryCancel_Click(object sender, EventArgs e)
        {
            CategoryInsertingDialogForm categoryInsertingDialogForm = new CategoryInsertingDialogForm();

            categoryInsertingDialogForm.Dispose();

            ProductInsertingDialogForm ProductInsertingDialogForm = new ProductInsertingDialogForm();

            ProductInsertingDialogForm.Show();

        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {

            try
            {
                CategoryRepo db = new CategoryRepo();
                Category category = new Category();

                category.CategoryName = txtCategory.Text;

                db.Insert(category);

                MessageBox.Show($"{category.CategoryName} Kategorisi Eklendi");

                System.Threading.Thread.Sleep(1000);

                CategoryInsertingDialogForm categoryInsertingDialogForm = new CategoryInsertingDialogForm();

                categoryInsertingDialogForm.Dispose();

                ProductInsertingDialogForm ProductInsertingDialogForm = new ProductInsertingDialogForm();

                ProductInsertingDialogForm.Show();
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
