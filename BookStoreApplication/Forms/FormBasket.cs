using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using Models;
using MainForm.Models;
using BookStoreApplication.HelperClasses;

namespace BookStoreApplication.Forms
{
    public partial class FormBasket : Form
    {
        public FormBasket()
        {
            InitializeComponent();
        }

        private void FormBasket_Load(object sender, EventArgs e)
        {
            LoadDataGridViewBasket();
            LoadBasketTextBox();
            SetLabelTotal();
            SetChildFormDesign.LoadTheme(this);
        }

        public void LoadDataGridViewBasket()
        {
            DataGridViewTextBoxColumn IdBasket = new DataGridViewTextBoxColumn();
            IdBasket.Name = "ID basket";
            DataGridViewTextBoxColumn Id = new DataGridViewTextBoxColumn();
            Id.Name = "ID";
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.Width = 200;
            DataGridViewTextBoxColumn Title = new DataGridViewTextBoxColumn();
            Title.Name = "Title";
            DataGridViewTextBoxColumn Author = new DataGridViewTextBoxColumn();
            Author.Name = "Author";
            DataGridViewTextBoxColumn Year = new DataGridViewTextBoxColumn();
            Year.Name = "Year";
            DataGridViewTextBoxColumn Count = new DataGridViewTextBoxColumn();
            Count.Name = "Count";
            DataGridViewTextBoxColumn Price = new DataGridViewTextBoxColumn();
            Price.Name = "Price";
            dataGridView_Basket.Columns.AddRange(IdBasket, Id, Title, Author, Year, Count, Price);
            dataGridView_Basket.Columns["ID basket"].Visible = false;
            using (BookStoreDB db = new BookStoreDB())
            {
                var basket = db.Basket.ToList();
                foreach (var item in basket)
                {
                    var book = db.Book.SingleOrDefault(x => x.ID == item.BookID);
                    var author = db.Author.SingleOrDefault(x => x.ID == book.AuthorID);
                    dataGridView_Basket.Rows.Add(item.ID, book.ID, book.Title, author.FullName, book.YearOfIssue, item.Count, book.Price.ToString() + " hrn");
                }
            }
            dataGridView_Basket.Sort(this.dataGridView_Basket.Columns["ID"], ListSortDirection.Ascending);
        }

        public void LoadBasketTextBox()
        {
            //string text = "";
            //using (BookStoreDB db = new BookStoreDB())
            //{
            //    var basket = db.Basket.ToList();
            //    foreach (var item in basket)
            //    {
            //        var book = db.Book.SingleOrDefault(x => x.ID == item.BookID);
            //        var author = db.Author.SingleOrDefault(x => x.ID == book.AuthorID);
            //        text += $"{book.Title}  , {author.FullName}  , {book.YearOfIssue}  , {book.Price}hrn   x{item.Count}   =   {book.Price * item.Count}hrn" + Environment.NewLine;
            //    }
            //}
            //textBox_Basket.Text = text;
        }

            private void dataGridView_Basket_DoubleClick(object sender, EventArgs e)
        {
            dataGridView_Basket.Rows[dataGridView_Basket.SelectedCells[0]
                .RowIndex].Selected = true;


        }

        private void dataGridView_Basket_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dataGridView_Basket.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow == -1) return;
            dataGridView_Basket.Rows[currentMouseOverRow].Selected = true;
            if (e.Button == MouseButtons.Right)
            {
                List<string> options = new List<string>()
                {
                    "Edit item quantity",
                    "Remove item from basket",
                };
                ContextMenu contextMenu = ContextMenuGenerator.GenerateContextMenu(dataGridView_Basket, e, options);
                contextMenu.MenuItems[0].Click += new System.EventHandler(this.EditQuantity);
                contextMenu.MenuItems[1].Click += new System.EventHandler(this.RemoveItem);
            }
        }

        private void EditQuantity(object sender, System.EventArgs e)
        {
            int index = (int)dataGridView_Basket.SelectedRows[0].Cells[0].Value;
            QuantityEditor editor = new QuantityEditor(index);
            editor.ShowDialog();
            using (BookStoreDB db = new BookStoreDB())
            {
                int count = db.Basket.SingleOrDefault(x => x.ID == index).Count;
                if (count == 0) DeleteSelectedItem();
                else dataGridView_Basket.SelectedRows[0].Cells[4].Value = count;
            }
            SetLabelTotal();
        }

        private void RemoveItem(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this item from basket?", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteSelectedItem();
            }
        }

        private void DeleteSelectedItem()
        {
            int index = (int)dataGridView_Basket.SelectedRows[0].Cells[0].Value;
            using (BookStoreDB db = new BookStoreDB())
            {
                db.Basket.RemoveRange(db.Basket.Where(x => x.ID == index));
                db.SaveChanges();
            }
            dataGridView_Basket.Rows.RemoveAt(dataGridView_Basket.SelectedRows[0].Index);
            SetLabelTotal();
        }

        private void SetLabelTotal()
        {
            label_Total.Text = CountTotal.Total().ToString();
        }

        private void button_Sell_Click(object sender, EventArgs e)
        {
            using (BookStoreDB db = new BookStoreDB())
            {
                DateTime now = DateTime.Now;
                var basket = db.Basket.ToList();
                foreach (var item in basket)
                {
                    Sales sale = new Sales()
                    {
                        BookID = item.BookID,
                        DateOfSale = now
                    };
                    db.Sales.Add(sale);
                }
                db.Database.ExecuteSqlCommand("TRUNCATE TABLE [Baskets]");
                db.SaveChanges();
            }
        }
    }
}
