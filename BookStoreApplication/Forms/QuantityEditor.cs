using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApplication.Forms
{
    public partial class QuantityEditor : Form
    {
        public int indexOfItem;
        public QuantityEditor(int index)
        {
            indexOfItem = index;
            this.CenterToScreen();
            InitializeComponent();
        }

        private void QuantityEditor_Load(object sender, EventArgs e)
        {
            using (BookStoreDB db = new BookStoreDB())
            {
                var basket = db.Basket.SingleOrDefault(x => x.ID == indexOfItem);
                numericUpDown_Quantity.Value = basket.Count;
                int inStock = db.Book.SingleOrDefault(x => x.ID == basket.BookID).QuantityInStock;
                numericUpDown_Quantity.Maximum = inStock;
                label_Maximum.Text = $"({inStock} in stock)";
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            using (BookStoreDB db = new BookStoreDB())
            {
                var basket = db.Basket.SingleOrDefault(x => x.ID == indexOfItem);
                basket.Count = (int)numericUpDown_Quantity.Value;
                db.Entry(basket).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            this.Close();

        }
    }
}
