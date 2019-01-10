using MarketOtomasyonu.BLL.Repository;
using MarketOtomasyonu.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu.WFA.Helpers
{
    public static class ReadOnly
    {

        
        public static void DoReadOnly(Form form)
        {
            ProductRepo db = new ProductRepo();

            foreach (Control control in form.Controls)
            {
                if (control is TextBox txt)
                    txt.ReadOnly = true;
                else if (control is NumericUpDown nm)
                    nm.Enabled = false;
                else if (control is ComboBox cmb) { 

                    foreach (var item in db.GetAll())
                    {
                        if ((cmb.SelectedItem.GetType() == item.GetType()))
                        {
                            cmb.Enabled = false;
                            break;
                        }

                    }
                }


            }
        }

        public static void UndoReadOnly(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox txt)
                    txt.ReadOnly = false;
                else if (control is NumericUpDown nm)
                    nm.Enabled = true ;
                else if (control is ComboBox cmb)
                    cmb.Enabled = true;


            }
        }
    }
}
