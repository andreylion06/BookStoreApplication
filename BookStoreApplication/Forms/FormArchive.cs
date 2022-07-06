using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApplication.Forms
{
    public partial class FormArchive : Form
    {
        public FormArchive()
        {
            InitializeComponent();
        }

        private void FormArchive_Load(object sender, EventArgs e)
        {
            SetChildFormDesign.LoadTheme(this);
            CreateDataGridViewColumns();
            using (BookStoreDB db = new BookStoreDB())
            {
                dateTimePicker_From.Value = db.Sales.Min(x => x.DateOfSale).Date;
            }
        }

        public void CreateDataGridViewColumns()
        {
            dataGridView_Archive.DataSource = null;
            DataGridViewTextBoxColumn Information = new DataGridViewTextBoxColumn();
            Information.Name = "Information";
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
            DataGridViewTextBoxColumn Price = new DataGridViewTextBoxColumn();
            Price.Name = "Price";
            DataGridViewTextBoxColumn Quantity = new DataGridViewTextBoxColumn();
            Quantity.Name = "Quantity";


            dataGridView_Archive.Columns.AddRange(Information, Id, Title, Author,
                Publisher, YearOfIssue, Price, Quantity);
            DisableSortingInDataGridView();
        }

        private void DisableSortingInDataGridView()
        {
            foreach (DataGridViewColumn column in dataGridView_Archive.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public void LoadDataGridViewArchive(DateTime from)
        {
            dataGridView_Archive.Rows.Clear();
            //MessageBox.Show(from.ToString());
            using (BookStoreDB db = new BookStoreDB())
            {
                var sales = db.Sales.Where(x => x.DateOfSale >= from).ToList();
                if (sales.Count == 0) return;

                DateTime date = sales[0].DateOfSale;
                dataGridView_Archive.Rows.Add("\t" + date.ToString("dd.MM.yyyy hh:mm:ss"));
                SetChildFormDesign.SetLastDataGridRowColor(dataGridView_Archive);
                double total = 0;
                foreach (var sale in sales)
                {
                    if (date != sale.DateOfSale)
                    {
                        date = sale.DateOfSale;
                        dataGridView_Archive.Rows.Add($"Total: {total} hrn");
                        total = 0;
                        dataGridView_Archive.Rows.Add("");
                        dataGridView_Archive.Rows.Add("\t" + date.ToString("dd.MM.yyyy hh:mm:ss"));
                        SetChildFormDesign.SetLastDataGridRowColor(dataGridView_Archive);
                    }
                    var book = db.Book.SingleOrDefault(x => x.ID == sale.BookID);
                    var author = db.Author.SingleOrDefault(x => x.ID == book.AuthorID);
                    var publisher = db.Publisher.SingleOrDefault(x => x.ID == book.PublisherID);
                    total += book.Price * sale.Count;
                    dataGridView_Archive.Rows.Add("", sale.ID, book.Title, author.FullName, publisher.Name,
                        book.YearOfIssue, book.Price.ToString() + " hrn", sale.Count);
                }
                dataGridView_Archive.Rows.Add($"Total: {total} hrn");
            }
            dataGridView_Archive.ClearSelection();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadDataGridViewArchive(dateTimePicker_From.Value);
        }
    }
}
