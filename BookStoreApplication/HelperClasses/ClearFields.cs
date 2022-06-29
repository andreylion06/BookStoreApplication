using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApplication
{
    public class ClearFields
    {
        public static void Clear(Control control)
        {
            foreach (Control cntrls in control.Controls)
            {
                if (cntrls.GetType() == typeof(TextBox))
                {
                    cntrls.Text = null;
                }
                else if (cntrls.GetType() == typeof(NumericUpDown))
                {
                    NumericUpDown numericUpDown = (NumericUpDown)cntrls;
                    numericUpDown.Value = 0;
                }
                else if (cntrls.GetType() == typeof(ComboBox))
                {
                    ComboBox cmb = (ComboBox)cntrls;
                    cmb.SelectedIndex = 0;
                }
            }
        }
    }
}
