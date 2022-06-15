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

namespace BookStoreApplication.Forms
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }
        private void FormProducts_Load(object sender, EventArgs e)
        {
            LoadDataGridViewBooks();
            SetChildFormDesign.LoadTheme(this);
            SetChildFormDesign.LoadTheme(groupBox_Basket);
        }

        public void LoadDataGridViewBooks()
        {
            using (BookStoreDB db = new BookStoreDB())
            {
                var source = db.Book
                    .Include(authors => authors.Author)
                    .Include(publishers => publishers.Publisher)
                    .Include(genres => genres.Genre)
                    .ToList();

                dataGridView_Products.DataSource = source;
                SetDataGridViewBooksColumns();
            }
        }

        private void SetDataGridViewBooksColumns()
        {
            dataGridView_Products.Columns["AuthorID"].Visible = false;
            dataGridView_Products.Columns["PublisherID"].Visible = false;
            dataGridView_Products.Columns["GenreID"].Visible = false;
            dataGridView_Products.ClearSelection();
        }

        private void dataGridView_Products_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dataGridView_Products.HitTest(e.X, e.Y).RowIndex;
            dataGridView_Products.Rows[currentMouseOverRow].Selected = true;
            if (e.Button == MouseButtons.Right)
            {
                List<string> options = new List<string>()
                {
                    "Edit selected item",
                    "Delete selected item",
                    "Add new item"
                };
                ContextMenu contextMenu = ContextMenuGenerator.GenerateContextMenu(dataGridView_Products, e, options);
                contextMenu.MenuItems[0].Click += new System.EventHandler(this.EditItem);
                contextMenu.MenuItems[1].Click += new System.EventHandler(this.DeleteItem);
                contextMenu.MenuItems[2].Click += new System.EventHandler(this.AddItem);
            }
            else if (e.Button == MouseButtons.Left)
            {
                int productId = (int)dataGridView_Products.Rows[currentMouseOverRow].Cells[0].Value;
                using (BookStoreDB db = new BookStoreDB())
                {
                    Book book = db.Book.SingleOrDefault(x => x.ID == productId);
                    Author author = db.Author.SingleOrDefault(x => x.ID == book.AuthorID);
                    numericUpDown_ProductToBasket.Maximum = book.QuantityInStock;
                    textBox_ProductToBasket.Text = $"{book.Title}, {author.FullName}, {book.YearOfIssue}";
                }
                groupBox_Basket.Visible = true;
            }
        }

        public void EditItem(object sender, System.EventArgs e)
        {

            (System.Windows.Forms.Application.OpenForms["FormMainMenu"]
                as FormMainMenu).GoToFormAddingFromContext((int)dataGridView_Products.SelectedRows[0].Cells[0].Value);
        }
        public void DeleteItem(object sender, System.EventArgs e)
        {
            int index = (int)dataGridView_Products.SelectedRows[0].Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to delete this data?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (BookStoreDB db = new BookStoreDB())
                {
                    db.Book.RemoveRange(db.Book.Where(x => x.ID == index));
                    db.SaveChanges();
                    LoadDataGridViewBooks();
                }
            }
        }

        public void AddItem(object sender, System.EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["FormMainMenu"] as FormMainMenu).GoToFormAddingFromContext();
        }

        public void AddToBasket(object sender, System.EventArgs e)
        {

        }

        private void textBox_Search_KeyUp(object sender, KeyEventArgs e)
        {
            using (BookStoreDB db = new BookStoreDB())
            {
                if (textBox_Search.Text.Trim().Length == 0) LoadDataGridViewBooks();
                else
                {
                    var res = db.Book
                        .Where(x => x.Title.StartsWith(textBox_Search.Text.Trim()))
                        .Include(authors => authors.Author)
                        .Include(publishers => publishers.Publisher)
                        .Include(genres => genres.Genre)
                        .ToList();
                    dataGridView_Products.DataSource = res;
                    SetDataGridViewBooksColumns();
                }
            }
        }

        private void dataGridView_Products_DoubleClick(object sender, EventArgs e)
        {
            dataGridView_Products.Rows[dataGridView_Products.SelectedCells[0]
                .RowIndex].Selected = true;
            EditItem(sender, null);
        }

        private void button_AddToBasket_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView_Products.SelectedCells[0].RowIndex;
            int productId = (int)dataGridView_Products.Rows[selectedRowIndex].Cells[0].Value;
            using (BookStoreDB db = new BookStoreDB())
            {
                Basket basket = db.Basket.SingleOrDefault(x => x.BookID == productId);
                if (basket == null)
                {
                    basket = new Basket()
                    {
                        BookID = productId,
                        Count = (int)numericUpDown_ProductToBasket.Value   
                    };
                    db.Basket.Add(basket);
                }
                else
                {
                    basket.Count += (int)numericUpDown_ProductToBasket.Value;
                    db.Entry(basket).State = System.Data.Entity.EntityState.Modified;
                }
                Book book = db.Book.SingleOrDefault(x => x.ID == productId);
                book.QuantityInStock -= (int)numericUpDown_ProductToBasket.Value;
                db.Entry(book).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                LoadDataGridViewBooks();
                //dataGridView_Products.Rows[selectedRowIndex].Selected = true;
                ClearFields.Clear(groupBox_Basket);
            }
        }
    }
}