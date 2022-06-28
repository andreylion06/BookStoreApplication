using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApplication
{
    public class SetChildFormDesign
    {
        public static void LoadTheme(Control control)
        {
            foreach (Control cntrls in control.Controls)
            {
                if (cntrls.GetType() == typeof(Button))
                {
                    Button btn = (Button)cntrls;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                else if (cntrls.GetType() == typeof(Label))
                {
                    Label label = (Label)cntrls;
                    label.ForeColor = ThemeColor.SecondaryColor;
                }
                else if (cntrls.GetType() == typeof(TextBox))
                {
                    TextBox txt = (TextBox)cntrls;
                    txt.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.95);
                    
                }
                else if (cntrls.GetType() == typeof(NumericUpDown))
                {
                    NumericUpDown numeric = (NumericUpDown)cntrls;
                    numeric.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.95);

                }
                else if (cntrls.GetType() == typeof(DataGridView))
                {
                    DataGridView dataGridView = (DataGridView)cntrls;
                    dataGridView.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
                    dataGridView.DefaultCellStyle.SelectionBackColor =
                        ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.5);
                    dataGridView.RowHeadersDefaultCellStyle.SelectionBackColor =
                        ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.3);
                    dataGridView.EnableHeadersVisualStyles = false;
                }
                else if (cntrls.GetType() == typeof(GroupBox))
                {
                    GroupBox groupBox = (GroupBox)cntrls;
                    groupBox.ForeColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.5);
                    LoadTheme(groupBox);
                }
                else if (cntrls.GetType() == typeof(Panel))
                {
                    Panel panel = (Panel)cntrls;
                    LoadTheme(panel);
                }
            }
        }

        public static void SetLastDataGridRowColor(DataGridView dataGrid)
        {
            dataGrid.Rows[dataGrid.Rows.Count - 1].DefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.9);
        }

    }
}
