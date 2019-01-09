using MarketOtomasyonu.BLL.Repository;
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
            var orders = new List<OrderViewModel>();
            try
            {
                orders.AddRange(new PackageRepo().GetAll()
                    .OrderBy(x => x.PackageName)
                    .Select(x => new OrderViewModel()
                    {
                        PackageName=x.PackageName,
                         PackageBarcode=x.PackageBarcode
                    }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmbOrderProduct.DataSource = orders;
        }
    }
}
