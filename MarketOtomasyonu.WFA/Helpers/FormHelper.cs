using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu.WFA.Helpers
{
     public static class FormHelper
    {

        public static void FormuTemizle(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;
                else if (control is DateTimePicker dtp)
                    dtp.Value = DateTime.Now;
               else if (control is NumericUpDown nm)
                    nm.Value = 0;
               



            }
        }

    }
}
