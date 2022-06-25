using BookStoreApplication.HelperClasses;
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
    public partial class FormAdding : Form
    {
        public FormAdding()
        {
            InitializeComponent();
        }

        public int IdEditBook = -1;

        private void FormAdding_Load(object sender, EventArgs e)
        {
            SetChildFormDesign.LoadTheme(this);

            LoadComboBox_Author();
            LoadComboBox_Genre();
            LoadComboBox_Publisher();

            LoadDataGridView_Authors();
            LoadDataGridView_Publishers();
            LoadDataGridView_Genres();

            if (IdEditBook != -1) FillBoxesForEditBook();
        }

        public void LoadComboBox_Author(int selected = -1)
        {
            List<Author> items = new List<Author> { new Author()
                { ID = 0, FullName = "[Select a Author]" } };
            using (BookStoreDB db = new BookStoreDB())
            {
                items.AddRange(db.Author.ToList());
            }
            comboBox_Author.DataSource = items;
            comboBox_Author.ValueMember = "ID";
            comboBox_Author.DisplayMember = "FullName";
            if (selected != -1) comboBox_Author.SelectedValue = selected;
        }

        public void LoadComboBox_Publisher(int selected = -1)
        {
            List<Publisher> items = new List<Publisher> { new Publisher()
                { ID = 0, Name = "[Select a Publisher]" } };
            using (BookStoreDB db = new BookStoreDB())
            {
                items.AddRange(db.Publisher.ToList());
            }
            comboBox_Publisher.DataSource = items;
            comboBox_Publisher.ValueMember = "ID";
            comboBox_Publisher.DisplayMember = "Name";
            if (selected != -1) comboBox_Publisher.SelectedValue = selected;
        }

        public void LoadComboBox_Genre(int selected = -1)
        {
            List<Genre> items = new List<Genre> { new Genre()
                { ID = 0, Name = "[Select a Genre]" } };
            using (BookStoreDB db = new BookStoreDB())
            {
                items.AddRange(db.Genre.ToList());
            }
            comboBox_Genre.DataSource = items;
            comboBox_Genre.ValueMember = "ID";
            comboBox_Genre.DisplayMember = "Name";
            if (selected != -1) comboBox_Genre.SelectedValue = selected;
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
                if (IdEditBook == -1) db.Book.Add(book);
                else
                {
                    book.ID = IdEditBook;
                    db.Entry(book).State = System.Data.Entity.EntityState.Modified;
                    message = $"Book '{book.Title}' was edited successfully!";
                }
                db.SaveChanges();
            }
            MessageBox.Show(message, "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (IdEditBook == -1)
            {
                ClearFields.Clear(groupBox_Books);
                numericUpDown_Year.Value = DateTime.Now.Year;
            }
            else
            {
                CheckBasketAfterActions.Check(IdEditBook, true);
                this.Close();
                (System.Windows.Forms.Application.OpenForms["FormMainMenu"]
                     as FormMainMenu).GoToFormProducts();
            }
        }

        private bool IsEmptyFieldsInBookGroupBox()
        {
            string warning = "";
            if (textBox_Title.Text.Trim() == "") warning = "Enter a book Title!";
            else if (comboBox_Author.SelectedIndex == 0) warning = "Select a book Author!";
            else if (comboBox_Publisher.SelectedIndex == 0) warning = "Select a book Publisher!";
            else if (comboBox_Genre.SelectedIndex == 0) warning = "Select a book Genre!";
            else if (textBox_Price.Text.Trim() == "") warning = "Enter a book Price!";

            if (warning != "")
            {
                MessageBox.Show(warning, "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void FillBoxesForEditBook()
        {
            using (BookStoreDB db = new BookStoreDB())
            {
                Book book = db.Book.SingleOrDefault(x => x.ID == IdEditBook);
                textBox_Title.Text = book.Title;
                comboBox_Author.SelectedValue = book.AuthorID;
                comboBox_Publisher.SelectedValue = book.PublisherID;
                numericUpDown_Year.Value = book.YearOfIssue;
                numericUpDown_NumberOfPages.Value = book.NumberOfPages;
                comboBox_Genre.SelectedValue = book.GenreID;
                numericUpDown_QuantityInStock.Value = book.QuantityInStock;
                textBox_Price.Text = book.Price.ToString();

                Author author = db.Author.SingleOrDefault(x => x.ID == book.AuthorID);
                textBox_AuthorName.Text = author.FullName;
                IdEditAuthor = author.ID;

                Publisher publisher = db.Publisher.SingleOrDefault(x => x.ID == book.PublisherID);
                textBox_PublisherName.Text = publisher.Name;
                textBox_Office.Text = publisher.OfficeAddress;
                textBox_PhoneNumber.Text = publisher.PhoneNumber;
                IdEditPublisher = publisher.ID;

                Genre genre = db.Genre.SingleOrDefault(x => x.ID == book.GenreID);
                textBox_GenreName.Text = genre.Name;
                IdEditGenre = genre.ID;
            }
            dataGridView_Author.DataSource = null;
            dataGridView_Publisher.DataSource = null;
            dataGridView_Genre.DataSource = null;

            StartAuthorEditing();
            StartPublisherEditing();
            StartGenreEditing();

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
            IdEditBook = -1;
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

            string message = $"Author '{author.FullName}' already exists!";
            using (BookStoreDB db = new BookStoreDB())
            {

                if (IdEditAuthor == -1)
                {
                    if (!db.Author.Any(au => au.FullName == author.FullName))
                    {
                        db.Author.Add(author);
                        message = $"Author '{author.FullName}' was added successfully!";
                    }
                }
                else
                {
                    author.ID = IdEditAuthor;
                    db.Entry(author).State = System.Data.Entity.EntityState.Modified;
                    message = $"Author '{author.FullName}' was edited successfully!";
                }
                db.SaveChanges();
            }
            LoadComboBox_Author(IdEditAuthor);
            if (IdEditAuthor == -1) ClearFields.Clear(groupBox_Authors);
            else FinishAuthorEditing();
            LoadDataGridView_Authors();
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
            StartAuthorEditing();
        }
        private void button_CancelAuthor_Click(object sender, EventArgs e)
        {
            FinishAuthorEditing();
        }

        private void StartAuthorEditing()
        {
            textBox_SearchAuthor.Enabled = false;
            button_AddAuthor.Size = new Size(205, 65);
            button_CancelAuthor.Visible = true;
            button_AddAuthor.Text = "Edit";
        }

        private void FinishAuthorEditing()
        {
            ClearFields.Clear(groupBox_Authors);
            button_AddAuthor.Size = new Size(329, 65);
            button_AddAuthor.Text = "Add";
            button_CancelAuthor.Visible = false;
            IdEditAuthor = -1;
            textBox_SearchAuthor.Enabled = true;
            if (dataGridView_Author.DataSource == null) LoadDataGridView_Authors();

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
                ContextMenu contextMenu = ContextMenuGenerator
                    .GenerateContextMenu(dataGridView_Author, e, options);
                contextMenu.MenuItems[0].Click += new System.EventHandler(this.EditAuthor);
            }
        }


        private void textBox_SearchAuthor_KeyUp(object sender, KeyEventArgs e)
        {
            using (BookStoreDB db = new BookStoreDB())
            {
                if (textBox_SearchAuthor.Text.Trim().Length == 0) LoadDataGridView_Authors();
                else dataGridView_Author.DataSource = db.Author
                        .Where(x => x.FullName.Contains(textBox_SearchAuthor.Text.Trim())).ToList();
            }
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
            else
            {
                var regex = @"^[\+][0-9]{6,12}";
                var match = Regex.Match(textBox_PhoneNumber.Text.Trim(), regex);
                if (!match.Success) warning = "Phone number must start with + and have at least 6 digits!";
            }

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

            string message = $"Publisher '{publisher.Name}' was added successfully!";
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
                    message = $"Publisher '{publisher.Name}' was edited successfully!";
                }
                db.SaveChanges();
            }
            LoadComboBox_Publisher(IdEditPublisher);
            if (IdEditPublisher == -1) ClearFields.Clear(groupBox_Publishers);
            else FinishPublisherEditing();
            LoadDataGridView_Publishers();
            MessageBox.Show(message, "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            StartPublisherEditing();
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
            FinishPublisherEditing();
        }

        private void StartPublisherEditing()
        {
            button_AddPublisher.Size = new Size(169, 65);
            button_CancelPublisher.Visible = true;
            button_AddPublisher.Text = "Edit";
            textBox_SearchPublisher.Enabled = false;
        }

        private void FinishPublisherEditing()
        {
            ClearFields.Clear(groupBox_Publishers);
            button_AddPublisher.Size = new Size(329, 65);
            button_AddPublisher.Text = "Add";
            button_CancelPublisher.Visible = false;
            IdEditPublisher = -1;
            textBox_SearchPublisher.Enabled = true;
            if (dataGridView_Publisher.DataSource == null) LoadDataGridView_Publishers();

        }

        private void textBox_SearchPublisher_KeyUp(object sender, KeyEventArgs e)
        {
            using (BookStoreDB db = new BookStoreDB())
            {
                if (textBox_SearchPublisher.Text.Trim().Length == 0) LoadDataGridView_Publishers();
                else dataGridView_Publisher.DataSource = db.Publisher
                        .Where(x => x.Name.Contains(textBox_SearchPublisher.Text.Trim())).ToList();
            }
        }

        int IdEditGenre = -1;
        private void LoadDataGridView_Genres()
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

            string message = $"Genre '{genre.Name}' already exists!";
            using (BookStoreDB db = new BookStoreDB())
            {

                if (IdEditGenre == -1)
                {
                    if (!db.Genre.Any(au => au.Name == genre.Name))
                    {
                        db.Genre.Add(genre);
                        message = $"Genre '{genre.Name}' was added successfully!";
                    }
                }
                else
                {
                    genre.ID = IdEditGenre;
                    db.Entry(genre).State = System.Data.Entity.EntityState.Modified;
                    message = $"Genre '{genre.Name}' was edited successfully!";
                }
                db.SaveChanges();
            }
            LoadComboBox_Genre(IdEditGenre);
            if (IdEditGenre == -1) ClearFields.Clear(groupBox_Genres);
            else FinishGenreEditing();
            LoadDataGridView_Genres();
            ClearFields.Clear(groupBox_Genres);
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
            StartGenreEditing();
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
            FinishGenreEditing();
        }

        private void StartGenreEditing()
        {
            button_AddGenre.Size = new Size(205, 65);
            button_CancelGenre.Visible = true;
            button_AddGenre.Text = "Edit";
            textBox_SearchGenre.Enabled = false;
        }

        private void FinishGenreEditing()
        {
            ClearFields.Clear(groupBox_Genres);
            button_AddGenre.Size = new Size(329, 65);
            button_AddGenre.Text = "Add";
            button_CancelGenre.Visible = false;
            IdEditGenre = -1;
            textBox_SearchGenre.Enabled = true;
            if (dataGridView_Genre.DataSource == null) LoadDataGridView_Genres();
        }

        private void textBox_SearchGenre_KeyUp(object sender, KeyEventArgs e)
        {
            using (BookStoreDB db = new BookStoreDB())
            {
                if (textBox_SearchGenre.Text.Trim().Length == 0) LoadDataGridView_Genres();
                else dataGridView_Genre.DataSource = db.Genre
                        .Where(x => x.Name.StartsWith(textBox_SearchGenre.Text.Trim())).ToList();
            }
        }
    }
}
