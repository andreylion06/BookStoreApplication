using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApplication
{
    public class ContextMenuGenerator
    {
        public static ContextMenu GenerateContextMenu(DataGridView dataGrid, MouseEventArgs e, List<string> options)
        {
            int currentMouseOverRow = dataGrid.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow != -1)
            {
                dataGrid.ClearSelection();
                dataGrid.Rows[currentMouseOverRow].Selected = true;

                ContextMenu m = new ContextMenu();
                foreach(string option in options) m.MenuItems.Add(new MenuItem(option));
                m.Show(dataGrid, new Point(e.X, e.Y));
                return m;
            }
            return null;
        }
    }
}
