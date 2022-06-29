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
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }
        private void FormProducts_Load(object sender, EventArgs e)
        {
            CreateDataGridViewColumns();
            LoadDataGridViewBooks();
            SetChildFormDesign.LoadTheme(this);
            label_InBasket.Text = "";
        }

        public void CreateDataGridViewColumns()
        {
            dataGridView_Products.DataSource = null;
            DataGridViewTextBoxColumn Id = new DataGridViewTextBoxColumn();
            Id.Name = "ID";
            DataGridViewTextBoxColumn Title = new DataGridViewTextBoxColumn();
            Title.Name = "Title";
            DataGridViewTextBoxColumn Author = new DataGridViewTextBoxColumn();
            Author.Name = "Author";
            DataGridViewTextBoxColumn Publisher = new DataGridViewTextBoxColumn();
            Publisher.Name = "Publisher";
            DataGridViewTextBoxColumn YearOfIssue = new DataGridViewTextBoxColumn();
            YearOfIssue.Name = "Year of issue";
            DataGridViewTextBoxColumn NumberOfPages = new DataGridViewTextBoxColumn();
            NumberOfPages.Name = "Number of pages";
            DataGridViewTextBoxColumn Genre = new DataGridViewTextBoxColumn();
            Genre.Name = "Genre";
            DataGridViewTextBoxColumn QuantityInStock = new DataGridViewTextBoxColumn();
            QuantityInStock.Name = "Quantity in stock";
            DataGridViewTextBoxColumn Price = new DataGridViewTextBoxColumn();
            Price.Name = "Price";
            dataGridView_Products.Columns.AddRange(Id, Title, Author, Publisher, YearOfIssue,
                NumberOfPages, Genre, QuantityInStock, Price);
        }

        public void LoadDataGridViewBooks(string search = null, bool all = false)
        {
            dataGridView_Products.Rows.Clear();
            using (BookStoreDB db = new BookStoreDB())
            {
                var books = db.Book.ToList();
                if (books.Count == 0) return;
                foreach (var book in books)
                {
                    if ((book.QuantityInStock == 0 && all == false)
                        || (search != null && !book.Title.Contains(search))) continue;
                    var author = db.Author.SingleOrDefault(x => x.ID == book.AuthorID);
                    var publisher = db.Publisher.SingleOrDefault(x => x.ID == book.PublisherID);
                    var genre = db.Genre.SingleOrDefault(x => x.ID == book.GenreID);
                    dataGridView_Products.Rows.Add(book.ID, book.Title, author.FullName,
                        publisher.Name, book.YearOfIssue, book.NumberOfPages, genre.Name,
                        book.QuantityInStock, book.Price.ToString() + " hrn");
                    if (book.QuantityInStock == 0)
                        dataGridView_Products.Rows[dataGridView_Products.Rows.Count - 1]
                            .DefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.9);
                }
            }
            dataGridView_Products.ClearSelection();
        }

        private void dataGridView_Products_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView_Products.ClearSelection();
            int currentMouseOverRow = dataGridView_Products.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow == -1) return;
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
                numericUpDown_Quantity.Enabled = true;
                using (BookStoreDB db = new BookStoreDB())
                {
                    Book book = db.Book.SingleOrDefault(x => x.ID == productId);
                    Author author = db.Author.SingleOrDefault(x => x.ID == book.AuthorID);
                    textBox_Title.Text = book.Title;
                    textBox_AuthorName.Text = author.FullName;
                    textBox_Price.Text = book.Price + " hrn";

                    Basket basket = db.Basket.SingleOrDefault(x => x.BookID == book.ID);
                    int quantityInBasket = 0;
                    if (basket != null)
                    {
                        label_InBasket.Text = $"({basket.Count} in basket)";
                        quantityInBasket = basket.Count;
                    }
                    else label_InBasket.Text = "";
                    numericUpDown_Quantity.Maximum = book.QuantityInStock - quantityInBasket;
                }
                groupBox_Basket.Visible = true;
                if (label_Total.Text == "00000") SetLabelTotal();
            }
        }

        public void EditItem(object sender, System.EventArgs e)
        {

            (System.Windows.Forms.Application.OpenForms["FormMainMenu"]
                as FormMainMenu).GoToFormAddingFromContext((int)dataGridView_Products.SelectedRows[0].Cells[0].Value);
        }

        public void DeleteItem(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this data?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = (int)dataGridView_Products.SelectedRows[0].Cells[0].Value;
                using (BookStoreDB db = new BookStoreDB())
                {
                    db.Book.RemoveRange(db.Book.Where(x => x.ID == index));
                    db.SaveChanges();
                }
                CheckBasketAfterActions.Check(index);
                LoadDataGridViewBooks();
            }
        }

        public void AddItem(object sender, System.EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["FormMainMenu"] as FormMainMenu).GoToFormAddingFromContext();
        }

        private void textBox_Search_KeyUp(object sender, KeyEventArgs e)
        {
            LoadDataGridViewBooks(textBox_Search.Text.Trim());
            if (textBox_Title.Text.Length != 0) ClearFields.Clear(groupBox_Basket);
        }

        private void dataGridView_Products_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_Products.CurrentRow == null) return;
            dataGridView_Products.Rows[dataGridView_Products.SelectedCells[0]
                .RowIndex].Selected = true;
            EditItem(sender, null);
        }

        private void button_AddToBasket_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView_Products.SelectedCells[0].RowIndex;
            int productId = (int)dataGridView_Products.Rows[selectedRowIndex].Cells[0].Value;
            if (numericUpDown_Quantity.Value == 0)
            {
                MessageBox.Show("You have selected 0 items.", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (BookStoreDB db = new BookStoreDB())
            {
                Basket basket = db.Basket.SingleOrDefault(x => x.BookID == productId);
                if (basket == null)
                {
                    basket = new Basket()
                    {
                        BookID = productId,
                        Count = (int)numericUpDown_Quantity.Value
                    };
                    db.Basket.Add(basket);
                }
                else
                {
                    basket.Count += (int)numericUpDown_Quantity.Value;
                    db.Entry(basket).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
            }
            LoadDataGridViewBooks();
            ClearFields.Clear(groupBox_AddingInBasket);
            numericUpDown_Quantity.Enabled = false;
            label_InBasket.Text = "";
            SetLabelTotal();
        }

        private void SetLabelTotal()
        {
            label_Total.Text = CountTotal.Total().ToString();
        }

        private void checkBox_All_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_All.Checked) LoadDataGridViewBooks(null, true);
            else LoadDataGridViewBooks(null, false);
        }
    }
}