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
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //searching
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    public partial class FormAdding : Form
    {
        public FormAdding()
        {
            InitializeComponent();
        }

        public int IdEdit = -1;

        private void FormAdding_Load(object sender, EventArgs e)
        {
            SetChildFormDesign.LoadTheme(this);
            LoadComboboxes();
            LoadDataGridView_Authors();
            LoadDataGridView_Publishers();
            LoadDataGridView_Genre();
            if (IdEdit != -1) FillBoxesForEdit();
        }

        private void LoadComboboxes()
        {
            LoadComboBox_Author();
            LoadComboBox_Genre();
            LoadComboBox_Publisher();
        }

        public void LoadComboBox_Author()
        {
            using (BookStoreDB db = new BookStoreDB())
            {
                comboBox_Author.DataSource =
                    (from au in db.Author select new { au.ID, au.FullName }).ToList();
                comboBox_Author.ValueMember = "ID";
                comboBox_Author.DisplayMember = "FullName";
            }
        }

        public void LoadComboBox_Publisher()
        {
            using (BookStoreDB db = new BookStoreDB())
            {
                comboBox_Publisher.DataSource =
                    (from pub in db.Publisher select new { pub.ID, pub.Name }).ToList();
                comboBox_Publisher.ValueMember = "ID";
                comboBox_Publisher.DisplayMember = "Name";
            }
        }

        public void LoadComboBox_Genre()
        {
            using (BookStoreDB db = new BookStoreDB())
            {
                comboBox_Genre.DataSource =
                (from gen in db.Genre select new { gen.ID, gen.Name }).ToList();
                comboBox_Genre.ValueMember = "ID";
                comboBox_Genre.DisplayMember = "Name";
            }
        }

        private void textBox_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.KeyChar == '.')
                e.Handled = textBox_Price.Text.Length == 0 || textBox_Price.Text.Contains(".");
        }

        private void button_AddBook_Click(object sender, EventArgs e)
        {
            if (IsEmptyFieldsInBookGroupBox()) return;
            Book book = new Book()
            {
                Title = textBox_Title.Text.Trim(),
                AuthorID = (int)comboBox_Author.SelectedValue,
                PublisherID = (int)comboBox_Publisher.SelectedValue,
                YearOfIssue = (int)numericUpDown_Year.Value,
                NumberOfPages = (int)numericUpDown_NumberOfPages.Value,
                GenreID = (int)comboBox_Genre.SelectedValue,
                QuantityInStock = (int)numericUpDown_QuantityInStock.Value,
                Price = Double.Parse(textBox_Price.Text.Trim())
            };
            string message = $"Book '{book.Title}' was added successfully!";
            using (BookStoreDB db = new BookStoreDB())
            {
                if (IdEdit == -1) db.Book.Add(book);
                else
                {
                    book.ID = IdEdit;
                    db.Entry(book).State = System.Data.Entity.EntityState.Modified;
                    message = $"Book '{book.Title}' was edited successfully!";
                }
                db.SaveChanges();
            }
            MessageBox.Show(message, "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (IdEdit == -1)
            {
                ClearFields.Clear(groupBox_Books);
                numericUpDown_Year.Value = DateTime.Now.Year;
            }
            else
            {
                this.Close();
                (System.Windows.Forms.Application.OpenForms["FormMainMenu"]
                     as FormMainMenu).GoToFormProducts();
            }
        }

        private bool IsEmptyFieldsInBookGroupBox()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!
            //CHECK COMBOBOXES
            //!!!!!!!!!!!!!!!!!!!!!!!!!!
            string warning = "";
            if (textBox_Title.Text.Trim() == "") warning = "Enter a book Title!";
            else if (comboBox_Author.SelectedItem == null) warning = "Select a book Author!";
            else if (comboBox_Publisher.SelectedItem == null) warning = "Select a book Publisher!";
            else if (comboBox_Genre.SelectedItem == null) warning = "Select a book Genre!";
            else if (textBox_Price.Text.Trim() == "") warning = "Enter a book Price!";

            if (warning != "")
            {
                MessageBox.Show(warning, "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void FillBoxesForEdit()
        {
            using (BookStoreDB db = new BookStoreDB())
            {
                Book book = db.Book.SingleOrDefault(x => x.ID == IdEdit);
                textBox_Title.Text = book.Title;
                comboBox_Author.SelectedValue = book.AuthorID;
                comboBox_Publisher.SelectedValue = book.PublisherID;
                numericUpDown_Year.Value = book.YearOfIssue;
                numericUpDown_NumberOfPages.Value = book.NumberOfPages;
                comboBox_Genre.SelectedValue = book.GenreID;
                numericUpDown_QuantityInStock.Value = book.QuantityInStock;
                textBox_Price.Text = book.Price.ToString();

                //Author author = db.Author.SingleOrDefault(x => x.ID == book.AuthorID);
                //textBox_AuthorName.Text = author.FullName;
                //IdEditAuthor = author.ID;

                //Publisher publisher = db.Publisher.SingleOrDefault(x => x.ID == book.PublisherID);
                //textBox_PublisherName.Text = publisher.Name;
                //textBox_Office.Text = publisher.OfficeAddress;
                //textBox_PhoneNumber.Text = publisher.PhoneNumber;
                //IdEditPublisher = publisher.ID;

                //Genre genre = db.Genre.SingleOrDefault(x => x.ID == book.GenreID);
                //textBox_GenreName.Text = genre.Name;
                //IdEditGenre = genre.ID;

            }
            //dataGridView_Author.DataSource = null;
            //dataGridView_Publisher.DataSource = null;
            //dataGridView_Genre.DataSource = null;

            button_AddBook.Size = new Size(711, 65);
            button_AddBook.Text = "Edit";
            button_CancelBook.Visible = true;
        }

        private void button_CancelBook_Click(object sender, EventArgs e)
        {
            ClearFields.Clear(groupBox_Books);
            button_AddBook.Size = new Size(835, 65);
            button_AddBook.Text = "Add";
            button_CancelBook.Visible = false;
            IdEdit = -1;
        }

        int IdEditAuthor = -1;
        private void LoadDataGridView_Authors()
        {
            using (BookStoreDB db = new BookStoreDB())
            {
                dataGridView_Author.DataSource = db.Author.ToList();
            }
        }

        private void AddAuthor()
        {
            if (textBox_AuthorName.Text.Trim() == "")
            {
                MessageBox.Show("Enter author Name!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Author author = new Author() { FullName = textBox_AuthorName.Text.Trim() };

            string message = $"Author '{ author.FullName }' already exists!";
            using (BookStoreDB db = new BookStoreDB())
            {
                if (!db.Author.Any(au => au.FullName == author.FullName))
                {
                    if (IdEditAuthor == -1)
                    {
                        db.Author.Add(author);
                        message = $"Author '{ author.FullName }' was added successfully!";
                    }
                    else
                    {
                        author.ID = IdEditAuthor;
                        db.Entry(author).State = System.Data.Entity.EntityState.Modified;
                        message = $"Author '{author.FullName}' was edited successfully!";
                        button_AddAuthor.Size = new Size(329, 65);
                        button_CancelAuthor.Visible = false;
                        button_AddAuthor.Text = "Add";
                        IdEditAuthor = -1;
                    }
                    db.SaveChanges();
                }
            }
            LoadDataGridView_Authors();
            LoadComboBox_Author();
            ClearFields.Clear(groupBox_Authors);
            MessageBox.Show(message, "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditAuthor(object sender, System.EventArgs e)
        {
            int index = (int)dataGridView_Author.SelectedRows[0].Cells[0].Value;
            using (BookStoreDB db = new BookStoreDB())
            {
                Author author = db.Author.SingleOrDefault(x => x.ID == index);
                textBox_AuthorName.Text = author.FullName;
                IdEditAuthor = author.ID;
            }
            button_AddAuthor.Size = new Size(205, 65);
            button_CancelAuthor.Visible = true;
            button_AddAuthor.Text = "Edit";
        }

        private void button_AddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthor();
        }

        private void textBox_AuthorName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) AddAuthor();
        }

        private void dataGridView_Authors_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                List<string> options = new List<string>() { "Edit selected item" };
                ContextMenu contextMenu = ContextMenuGenerator.GenerateContextMenu(dataGridView_Author, e, options);
                contextMenu.MenuItems[0].Click += new System.EventHandler(this.EditAuthor);
            }
        }

        private void button_CancelAuthor_Click(object sender, EventArgs e)
        {
            ClearFields.Clear(groupBox_Authors);
            button_AddAuthor.Size = new Size(329, 65);
            button_AddAuthor.Text = "Add";
            button_CancelAuthor.Visible = false;
            IdEditAuthor = -1;
            dataGridView_Author.ClearSelection();
        }

        int IdEditPublisher = -1;
        private void LoadDataGridView_Publishers()
        {
            using (BookStoreDB db = new BookStoreDB())
            {
                dataGridView_Publisher.DataSource = db.Publisher.ToList();
            }
        }


        private void AddPublisher()
        {
            string warning = "";
            if (textBox_PublisherName.Text.Trim() == "") warning = "Enter a publisher Name!";
            else if (textBox_Office.Text.Trim() == "") warning = "Enter a publisher Office Address!";
            else if (textBox_PhoneNumber.Text.Trim() == "") warning = "Enter a publisher Phone Number!";

            if (warning != "")
            {
                MessageBox.Show(warning, "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Publisher publisher = new Publisher()
            {
                Name = textBox_PublisherName.Text.Trim(),
                OfficeAddress = textBox_Office.Text.Trim(),
                PhoneNumber = textBox_PhoneNumber.Text.Trim()
            };

            string message = $"Publisher '{ publisher.Name }' was added successfully!";
            using (BookStoreDB db = new BookStoreDB())
            {

                if (IdEditPublisher == -1)
                {
                    db.Publisher.Add(publisher);
                }
                else
                {
                    publisher.ID = IdEditPublisher;
                    db.Entry(publisher).State = System.Data.Entity.EntityState.Modified;
                    message = $"Publisher '{ publisher.Name }' was edited successfully!";
                    button_AddPublisher.Text = "Add";
                    button_AddPublisher.Size = new Size(293, 65);
                    button_CancelPublisher.Visible = false;
                    IdEditPublisher = -1;
                }
                db.SaveChanges();
            }
            LoadDataGridView_Publishers();
            LoadComboBox_Publisher();
            ClearFields.Clear(groupBox_Publishers);
            MessageBox.Show(message, "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //Regex for phone textbox
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        }

        private void EditPublisher(object sender, System.EventArgs e)
        {
            int index = (int)dataGridView_Publisher.SelectedRows[0].Cells[0].Value;
            using (BookStoreDB db = new BookStoreDB())
            {
                Publisher publisher = db.Publisher.SingleOrDefault(x => x.ID == index);
                textBox_PublisherName.Text = publisher.Name;
                textBox_Office.Text = publisher.OfficeAddress;
                textBox_PhoneNumber.Text = publisher.PhoneNumber;
                IdEditPublisher = publisher.ID;
            }
            button_AddPublisher.Size = new Size(169, 65);
            button_CancelPublisher.Visible = true;
            button_AddPublisher.Text = "Edit";
        }

        private void button_AddPublisher_Click(object sender, EventArgs e)
        {
            AddPublisher();
        }

        private void dataGridView_Publisher_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                List<string> options = new List<string>() { "Edit selected item" };
                ContextMenu contextMenu = ContextMenuGenerator.GenerateContextMenu(dataGridView_Publisher, e, options);
                contextMenu.MenuItems[0].Click += new System.EventHandler(this.EditPublisher);
            }
        }

        private void button_CancelPublisher_Click(object sender, EventArgs e)
        {

            ClearFields.Clear(groupBox_Publishers);
            button_AddPublisher.Size = new Size(329, 65);
            button_AddPublisher.Text = "Add";
            button_CancelPublisher.Visible = false;
            IdEditPublisher = -1;
            dataGridView_Publisher.ClearSelection();
        }

        int IdEditGenre = -1;
        private void LoadDataGridView_Genre()
        {
            using (BookStoreDB db = new BookStoreDB())
            {
                dataGridView_Genre.DataSource = db.Genre.ToList();
            }
        }

        private void AddGenre()
        {
            if (textBox_GenreName.Text.Trim() == "")
            {
                MessageBox.Show("Enter genre Name!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Genre genre = new Genre() { Name = textBox_GenreName.Text.Trim() };

            string message = $"Genre '{ genre.Name }' already exists!";
            using (BookStoreDB db = new BookStoreDB())
            {
                if (!db.Genre.Any(au => au.Name == genre.Name))
                {
                    if (IdEditGenre == -1)
                    {
                        db.Genre.Add(genre);
                        message = $"Genre '{ genre.Name }' was added successfully!";
                    }
                    else
                    {
                        genre.ID = IdEditGenre;
                        db.Entry(genre).State = System.Data.Entity.EntityState.Modified;
                        message = $"Genre '{ genre.Name }' was edited successfully!";
                        button_AddGenre.Text = "Add";
                        button_AddGenre.Size = new Size(329, 65);
                        button_CancelGenre.Visible = false;
                        IdEditGenre = -1;
                    }
                    db.SaveChanges();
                }
            }
            LoadDataGridView_Genre();
            LoadComboBox_Genre();
            ClearFields.Clear(groupBox_Genre);
            MessageBox.Show(message, "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditGenre(object sender, System.EventArgs e)
        {
            int index = (int)dataGridView_Genre.SelectedRows[0].Cells[0].Value;
            using (BookStoreDB db = new BookStoreDB())
            {
                Genre genre = db.Genre.SingleOrDefault(x => x.ID == index);
                textBox_GenreName.Text = genre.Name;
                IdEditGenre = genre.ID;
            }
            button_AddGenre.Size = new Size(205, 65);
            button_CancelGenre.Visible = true;
            button_AddGenre.Text = "Edit";
        }

        private void button_AddGenre_Click(object sender, EventArgs e)
        {
            AddGenre();
        }

        private void textBox_GenreName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) AddGenre();
        }

        private void dataGridView_Genre_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                List<string> options = new List<string>() { "Edit selected item" };
                ContextMenu contextMenu = ContextMenuGenerator.GenerateContextMenu(dataGridView_Genre, e, options);
                contextMenu.MenuItems[0].Click += new System.EventHandler(this.EditGenre);
            }
        }

        private void button_CancelGenre_Click(object sender, EventArgs e)
        {
            ClearFields.Clear(groupBox_Genre);
            button_AddGenre.Size = new Size(329, 65);
            button_AddGenre.Text = "Add";
            button_CancelGenre.Visible = false;
            IdEditGenre = -1;
            dataGridView_Genre.ClearSelection();
        }
    }
}
