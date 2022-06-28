using System;

namespace BookStoreApplication.Forms
{
    partial class FormAdding
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdding));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_hrn2 = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_Author = new System.Windows.Forms.Label();
            this.comboBox_Genre = new System.Windows.Forms.ComboBox();
            this.numericUpDown_QuantityInStock = new System.Windows.Forms.NumericUpDown();
            this.label_Publisher = new System.Windows.Forms.Label();
            this.label_QuantityInStock = new System.Windows.Forms.Label();
            this.label_Genre = new System.Windows.Forms.Label();
            this.numericUpDown_NumberOfPages = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Year = new System.Windows.Forms.NumericUpDown();
            this.label_NumberOfPages = new System.Windows.Forms.Label();
            this.comboBox_Author = new System.Windows.Forms.ComboBox();
            this.label_YearOfIssue = new System.Windows.Forms.Label();
            this.comboBox_Publisher = new System.Windows.Forms.ComboBox();
            this.groupBox_Books = new System.Windows.Forms.GroupBox();
            this.button_CancelBook = new System.Windows.Forms.Button();
            this.button_AddBook = new System.Windows.Forms.Button();
            this.groupBox_Authors = new System.Windows.Forms.GroupBox();
            this.button_SearchAuthor = new System.Windows.Forms.Button();
            this.textBox_SearchAuthor = new System.Windows.Forms.TextBox();
            this.button_CancelAuthor = new System.Windows.Forms.Button();
            this.button_AddAuthor = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_AuthorName = new System.Windows.Forms.TextBox();
            this.dataGridView_Author = new System.Windows.Forms.DataGridView();
            this.groupBox_Publishers = new System.Windows.Forms.GroupBox();
            this.button_SearchPublisher = new System.Windows.Forms.Button();
            this.button_CancelPublisher = new System.Windows.Forms.Button();
            this.label_PhoneNumber = new System.Windows.Forms.Label();
            this.textBox_SearchPublisher = new System.Windows.Forms.TextBox();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label_Office = new System.Windows.Forms.Label();
            this.textBox_Office = new System.Windows.Forms.TextBox();
            this.button_AddPublisher = new System.Windows.Forms.Button();
            this.label_PublisherName = new System.Windows.Forms.Label();
            this.textBox_PublisherName = new System.Windows.Forms.TextBox();
            this.dataGridView_Publisher = new System.Windows.Forms.DataGridView();
            this.groupBox_Genres = new System.Windows.Forms.GroupBox();
            this.button_SearchGenre = new System.Windows.Forms.Button();
            this.button_CancelGenre = new System.Windows.Forms.Button();
            this.textBox_SearchGenre = new System.Windows.Forms.TextBox();
            this.button_AddGenre = new System.Windows.Forms.Button();
            this.label_GenreName = new System.Windows.Forms.Label();
            this.textBox_GenreName = new System.Windows.Forms.TextBox();
            this.dataGridView_Genre = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_QuantityInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberOfPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Year)).BeginInit();
            this.groupBox_Books.SuspendLayout();
            this.groupBox_Authors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Author)).BeginInit();
            this.groupBox_Publishers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Publisher)).BeginInit();
            this.groupBox_Genres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Genre)).BeginInit();
            this.SuspendLayout();
            // 
            // label_hrn2
            // 
            this.label_hrn2.AutoSize = true;
            this.label_hrn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_hrn2.Location = new System.Drawing.Point(805, 356);
            this.label_hrn2.Name = "label_hrn2";
            this.label_hrn2.Size = new System.Drawing.Size(43, 24);
            this.label_hrn2.TabIndex = 76;
            this.label_hrn2.Text = "hrn.";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Title.Location = new System.Drawing.Point(9, 21);
            this.label_Title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(50, 24);
            this.label_Title.TabIndex = 60;
            this.label_Title.Text = "Title:";
            // 
            // textBox_Price
            // 
            this.textBox_Price.BackColor = System.Drawing.Color.White;
            this.textBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Price.Location = new System.Drawing.Point(513, 331);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(290, 49);
            this.textBox_Price.TabIndex = 68;
            this.textBox_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Price_KeyPress);
            // 
            // textBox_Title
            // 
            this.textBox_Title.BackColor = System.Drawing.Color.White;
            this.textBox_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Title.Location = new System.Drawing.Point(18, 55);
            this.textBox_Title.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(462, 49);
            this.textBox_Title.TabIndex = 61;
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Price.Location = new System.Drawing.Point(507, 300);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(58, 24);
            this.label_Price.TabIndex = 74;
            this.label_Price.Text = "Price:";
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Author.Location = new System.Drawing.Point(9, 110);
            this.label_Author.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(71, 24);
            this.label_Author.TabIndex = 62;
            this.label_Author.Text = "Author:";
            // 
            // comboBox_Genre
            // 
            this.comboBox_Genre.BackColor = System.Drawing.Color.White;
            this.comboBox_Genre.DropDownHeight = 170;
            this.comboBox_Genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Genre.FormattingEnabled = true;
            this.comboBox_Genre.IntegralHeight = false;
            this.comboBox_Genre.ItemHeight = 42;
            this.comboBox_Genre.Location = new System.Drawing.Point(18, 331);
            this.comboBox_Genre.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_Genre.MaxDropDownItems = 5;
            this.comboBox_Genre.Name = "comboBox_Genre";
            this.comboBox_Genre.Size = new System.Drawing.Size(462, 50);
            this.comboBox_Genre.TabIndex = 64;
            // 
            // numericUpDown_QuantityInStock
            // 
            this.numericUpDown_QuantityInStock.BackColor = System.Drawing.Color.White;
            this.numericUpDown_QuantityInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_QuantityInStock.Location = new System.Drawing.Point(513, 235);
            this.numericUpDown_QuantityInStock.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDown_QuantityInStock.Name = "numericUpDown_QuantityInStock";
            this.numericUpDown_QuantityInStock.Size = new System.Drawing.Size(290, 49);
            this.numericUpDown_QuantityInStock.TabIndex = 67;
            this.numericUpDown_QuantityInStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_Publisher
            // 
            this.label_Publisher.AutoSize = true;
            this.label_Publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Publisher.Location = new System.Drawing.Point(9, 206);
            this.label_Publisher.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Publisher.Name = "label_Publisher";
            this.label_Publisher.Size = new System.Drawing.Size(94, 24);
            this.label_Publisher.TabIndex = 63;
            this.label_Publisher.Text = "Publisher:";
            // 
            // label_QuantityInStock
            // 
            this.label_QuantityInStock.AutoSize = true;
            this.label_QuantityInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_QuantityInStock.Location = new System.Drawing.Point(509, 205);
            this.label_QuantityInStock.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_QuantityInStock.Name = "label_QuantityInStock";
            this.label_QuantityInStock.Size = new System.Drawing.Size(151, 24);
            this.label_QuantityInStock.TabIndex = 72;
            this.label_QuantityInStock.Text = "Quantity in stock:";
            // 
            // label_Genre
            // 
            this.label_Genre.AutoSize = true;
            this.label_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Genre.Location = new System.Drawing.Point(9, 301);
            this.label_Genre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Genre.Name = "label_Genre";
            this.label_Genre.Size = new System.Drawing.Size(68, 24);
            this.label_Genre.TabIndex = 70;
            this.label_Genre.Text = "Genre:";
            // 
            // numericUpDown_NumberOfPages
            // 
            this.numericUpDown_NumberOfPages.BackColor = System.Drawing.Color.White;
            this.numericUpDown_NumberOfPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_NumberOfPages.Location = new System.Drawing.Point(513, 140);
            this.numericUpDown_NumberOfPages.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDown_NumberOfPages.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_NumberOfPages.Name = "numericUpDown_NumberOfPages";
            this.numericUpDown_NumberOfPages.Size = new System.Drawing.Size(290, 49);
            this.numericUpDown_NumberOfPages.TabIndex = 66;
            this.numericUpDown_NumberOfPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_Year
            // 
            this.numericUpDown_Year.BackColor = System.Drawing.Color.White;
            this.numericUpDown_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_Year.Location = new System.Drawing.Point(513, 53);
            this.numericUpDown_Year.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDown_Year.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDown_Year.Name = "numericUpDown_Year";
            this.numericUpDown_Year.Size = new System.Drawing.Size(167, 49);
            this.numericUpDown_Year.TabIndex = 65;
            this.numericUpDown_Year.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // label_NumberOfPages
            // 
            this.label_NumberOfPages.AutoSize = true;
            this.label_NumberOfPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NumberOfPages.Location = new System.Drawing.Point(507, 109);
            this.label_NumberOfPages.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_NumberOfPages.Name = "label_NumberOfPages";
            this.label_NumberOfPages.Size = new System.Drawing.Size(161, 24);
            this.label_NumberOfPages.TabIndex = 65;
            this.label_NumberOfPages.Text = "Number of pages:";
            // 
            // comboBox_Author
            // 
            this.comboBox_Author.BackColor = System.Drawing.Color.White;
            this.comboBox_Author.DropDownHeight = 170;
            this.comboBox_Author.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Author.FormattingEnabled = true;
            this.comboBox_Author.IntegralHeight = false;
            this.comboBox_Author.ItemHeight = 42;
            this.comboBox_Author.Location = new System.Drawing.Point(16, 140);
            this.comboBox_Author.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_Author.MaxDropDownItems = 5;
            this.comboBox_Author.Name = "comboBox_Author";
            this.comboBox_Author.Size = new System.Drawing.Size(464, 50);
            this.comboBox_Author.TabIndex = 62;
            // 
            // label_YearOfIssue
            // 
            this.label_YearOfIssue.AutoSize = true;
            this.label_YearOfIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_YearOfIssue.Location = new System.Drawing.Point(509, 20);
            this.label_YearOfIssue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_YearOfIssue.Name = "label_YearOfIssue";
            this.label_YearOfIssue.Size = new System.Drawing.Size(123, 24);
            this.label_YearOfIssue.TabIndex = 66;
            this.label_YearOfIssue.Text = "Year of issue:";
            // 
            // comboBox_Publisher
            // 
            this.comboBox_Publisher.BackColor = System.Drawing.Color.White;
            this.comboBox_Publisher.DropDownHeight = 170;
            this.comboBox_Publisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Publisher.FormattingEnabled = true;
            this.comboBox_Publisher.IntegralHeight = false;
            this.comboBox_Publisher.ItemHeight = 42;
            this.comboBox_Publisher.Location = new System.Drawing.Point(16, 236);
            this.comboBox_Publisher.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_Publisher.MaxDropDownItems = 5;
            this.comboBox_Publisher.Name = "comboBox_Publisher";
            this.comboBox_Publisher.Size = new System.Drawing.Size(464, 50);
            this.comboBox_Publisher.TabIndex = 63;
            // 
            // groupBox_Books
            // 
            this.groupBox_Books.Controls.Add(this.button_CancelBook);
            this.groupBox_Books.Controls.Add(this.label_Title);
            this.groupBox_Books.Controls.Add(this.button_AddBook);
            this.groupBox_Books.Controls.Add(this.label_hrn2);
            this.groupBox_Books.Controls.Add(this.comboBox_Publisher);
            this.groupBox_Books.Controls.Add(this.label_YearOfIssue);
            this.groupBox_Books.Controls.Add(this.textBox_Price);
            this.groupBox_Books.Controls.Add(this.comboBox_Author);
            this.groupBox_Books.Controls.Add(this.textBox_Title);
            this.groupBox_Books.Controls.Add(this.label_NumberOfPages);
            this.groupBox_Books.Controls.Add(this.label_Price);
            this.groupBox_Books.Controls.Add(this.numericUpDown_Year);
            this.groupBox_Books.Controls.Add(this.label_Author);
            this.groupBox_Books.Controls.Add(this.numericUpDown_NumberOfPages);
            this.groupBox_Books.Controls.Add(this.comboBox_Genre);
            this.groupBox_Books.Controls.Add(this.label_Genre);
            this.groupBox_Books.Controls.Add(this.numericUpDown_QuantityInStock);
            this.groupBox_Books.Controls.Add(this.label_QuantityInStock);
            this.groupBox_Books.Controls.Add(this.label_Publisher);
            this.groupBox_Books.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Books.Name = "groupBox_Books";
            this.groupBox_Books.Size = new System.Drawing.Size(862, 483);
            this.groupBox_Books.TabIndex = 60;
            this.groupBox_Books.TabStop = false;
            // 
            // button_CancelBook
            // 
            this.button_CancelBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CancelBook.Location = new System.Drawing.Point(730, 404);
            this.button_CancelBook.Name = "button_CancelBook";
            this.button_CancelBook.Size = new System.Drawing.Size(118, 65);
            this.button_CancelBook.TabIndex = 77;
            this.button_CancelBook.Text = "Cancel Editing";
            this.button_CancelBook.UseVisualStyleBackColor = true;
            this.button_CancelBook.Visible = false;
            this.button_CancelBook.Click += new System.EventHandler(this.button_CancelBook_Click);
            // 
            // button_AddBook
            // 
            this.button_AddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddBook.Location = new System.Drawing.Point(13, 404);
            this.button_AddBook.Name = "button_AddBook";
            this.button_AddBook.Size = new System.Drawing.Size(835, 65);
            this.button_AddBook.TabIndex = 69;
            this.button_AddBook.Text = "Add";
            this.button_AddBook.UseVisualStyleBackColor = true;
            this.button_AddBook.Click += new System.EventHandler(this.button_AddBook_Click);
            // 
            // groupBox_Authors
            // 
            this.groupBox_Authors.Controls.Add(this.button_SearchAuthor);
            this.groupBox_Authors.Controls.Add(this.textBox_SearchAuthor);
            this.groupBox_Authors.Controls.Add(this.button_CancelAuthor);
            this.groupBox_Authors.Controls.Add(this.button_AddAuthor);
            this.groupBox_Authors.Controls.Add(this.label_Name);
            this.groupBox_Authors.Controls.Add(this.textBox_AuthorName);
            this.groupBox_Authors.Controls.Add(this.dataGridView_Author);
            this.groupBox_Authors.Location = new System.Drawing.Point(900, 12);
            this.groupBox_Authors.Name = "groupBox_Authors";
            this.groupBox_Authors.Size = new System.Drawing.Size(780, 483);
            this.groupBox_Authors.TabIndex = 70;
            this.groupBox_Authors.TabStop = false;
            // 
            // button_SearchAuthor
            // 
            this.button_SearchAuthor.BackColor = System.Drawing.SystemColors.Control;
            this.button_SearchAuthor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_SearchAuthor.BackgroundImage")));
            this.button_SearchAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_SearchAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SearchAuthor.Location = new System.Drawing.Point(358, 31);
            this.button_SearchAuthor.Name = "button_SearchAuthor";
            this.button_SearchAuthor.Size = new System.Drawing.Size(44, 40);
            this.button_SearchAuthor.TabIndex = 80;
            this.button_SearchAuthor.UseVisualStyleBackColor = false;
            // 
            // textBox_SearchAuthor
            // 
            this.textBox_SearchAuthor.BackColor = System.Drawing.Color.White;
            this.textBox_SearchAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SearchAuthor.Location = new System.Drawing.Point(32, 31);
            this.textBox_SearchAuthor.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_SearchAuthor.Name = "textBox_SearchAuthor";
            this.textBox_SearchAuthor.Size = new System.Drawing.Size(326, 40);
            this.textBox_SearchAuthor.TabIndex = 79;
            this.textBox_SearchAuthor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_SearchAuthor_KeyUp);
            // 
            // button_CancelAuthor
            // 
            this.button_CancelAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CancelAuthor.Location = new System.Drawing.Point(637, 182);
            this.button_CancelAuthor.Name = "button_CancelAuthor";
            this.button_CancelAuthor.Size = new System.Drawing.Size(118, 65);
            this.button_CancelAuthor.TabIndex = 78;
            this.button_CancelAuthor.Text = "Cancel Editing";
            this.button_CancelAuthor.UseVisualStyleBackColor = true;
            this.button_CancelAuthor.Visible = false;
            this.button_CancelAuthor.Click += new System.EventHandler(this.button_CancelAuthor_Click);
            // 
            // button_AddAuthor
            // 
            this.button_AddAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddAuthor.Location = new System.Drawing.Point(426, 182);
            this.button_AddAuthor.Name = "button_AddAuthor";
            this.button_AddAuthor.Size = new System.Drawing.Size(329, 65);
            this.button_AddAuthor.TabIndex = 73;
            this.button_AddAuthor.Text = "Add";
            this.button_AddAuthor.UseVisualStyleBackColor = true;
            this.button_AddAuthor.Click += new System.EventHandler(this.button_AddAuthor_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name.Location = new System.Drawing.Point(422, 80);
            this.label_Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(144, 24);
            this.label_Name.TabIndex = 62;
            this.label_Name.Text = "Name of author:";
            // 
            // textBox_AuthorName
            // 
            this.textBox_AuthorName.BackColor = System.Drawing.Color.White;
            this.textBox_AuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_AuthorName.Location = new System.Drawing.Point(426, 111);
            this.textBox_AuthorName.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_AuthorName.Name = "textBox_AuthorName";
            this.textBox_AuthorName.Size = new System.Drawing.Size(329, 49);
            this.textBox_AuthorName.TabIndex = 72;
            this.textBox_AuthorName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_AuthorName_KeyPress);
            // 
            // dataGridView_Author
            // 
            this.dataGridView_Author.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Author.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Author.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Author.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Author.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Author.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Author.Location = new System.Drawing.Point(32, 80);
            this.dataGridView_Author.Name = "dataGridView_Author";
            this.dataGridView_Author.ReadOnly = true;
            this.dataGridView_Author.RowTemplate.Height = 40;
            this.dataGridView_Author.Size = new System.Drawing.Size(370, 389);
            this.dataGridView_Author.TabIndex = 71;
            this.dataGridView_Author.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Authors_MouseClick);
            // 
            // groupBox_Publishers
            // 
            this.groupBox_Publishers.Controls.Add(this.button_SearchPublisher);
            this.groupBox_Publishers.Controls.Add(this.button_CancelPublisher);
            this.groupBox_Publishers.Controls.Add(this.label_PhoneNumber);
            this.groupBox_Publishers.Controls.Add(this.textBox_SearchPublisher);
            this.groupBox_Publishers.Controls.Add(this.textBox_PhoneNumber);
            this.groupBox_Publishers.Controls.Add(this.label_Office);
            this.groupBox_Publishers.Controls.Add(this.textBox_Office);
            this.groupBox_Publishers.Controls.Add(this.button_AddPublisher);
            this.groupBox_Publishers.Controls.Add(this.label_PublisherName);
            this.groupBox_Publishers.Controls.Add(this.textBox_PublisherName);
            this.groupBox_Publishers.Controls.Add(this.dataGridView_Publisher);
            this.groupBox_Publishers.Location = new System.Drawing.Point(12, 514);
            this.groupBox_Publishers.Name = "groupBox_Publishers";
            this.groupBox_Publishers.Size = new System.Drawing.Size(862, 410);
            this.groupBox_Publishers.TabIndex = 74;
            this.groupBox_Publishers.TabStop = false;
            // 
            // button_SearchPublisher
            // 
            this.button_SearchPublisher.BackColor = System.Drawing.SystemColors.Control;
            this.button_SearchPublisher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_SearchPublisher.BackgroundImage")));
            this.button_SearchPublisher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_SearchPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SearchPublisher.Location = new System.Drawing.Point(487, 25);
            this.button_SearchPublisher.Name = "button_SearchPublisher";
            this.button_SearchPublisher.Size = new System.Drawing.Size(44, 40);
            this.button_SearchPublisher.TabIndex = 82;
            this.button_SearchPublisher.UseVisualStyleBackColor = false;
            // 
            // button_CancelPublisher
            // 
            this.button_CancelPublisher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CancelPublisher.Location = new System.Drawing.Point(727, 328);
            this.button_CancelPublisher.Name = "button_CancelPublisher";
            this.button_CancelPublisher.Size = new System.Drawing.Size(118, 65);
            this.button_CancelPublisher.TabIndex = 79;
            this.button_CancelPublisher.Text = "Cancel Editing";
            this.button_CancelPublisher.UseVisualStyleBackColor = true;
            this.button_CancelPublisher.Visible = false;
            this.button_CancelPublisher.Click += new System.EventHandler(this.button_CancelPublisher_Click);
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PhoneNumber.Location = new System.Drawing.Point(555, 243);
            this.label_PhoneNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(142, 24);
            this.label_PhoneNumber.TabIndex = 80;
            this.label_PhoneNumber.Text = "Phone number:";
            // 
            // textBox_SearchPublisher
            // 
            this.textBox_SearchPublisher.BackColor = System.Drawing.Color.White;
            this.textBox_SearchPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SearchPublisher.Location = new System.Drawing.Point(13, 25);
            this.textBox_SearchPublisher.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_SearchPublisher.Name = "textBox_SearchPublisher";
            this.textBox_SearchPublisher.Size = new System.Drawing.Size(474, 40);
            this.textBox_SearchPublisher.TabIndex = 81;
            this.textBox_SearchPublisher.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_SearchPublisher_KeyUp);
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.BackColor = System.Drawing.Color.White;
            this.textBox_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(555, 273);
            this.textBox_PhoneNumber.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(293, 49);
            this.textBox_PhoneNumber.TabIndex = 78;
            // 
            // label_Office
            // 
            this.label_Office.AutoSize = true;
            this.label_Office.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Office.Location = new System.Drawing.Point(555, 162);
            this.label_Office.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Office.Name = "label_Office";
            this.label_Office.Size = new System.Drawing.Size(135, 24);
            this.label_Office.TabIndex = 78;
            this.label_Office.Text = "Office address:";
            // 
            // textBox_Office
            // 
            this.textBox_Office.BackColor = System.Drawing.Color.White;
            this.textBox_Office.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Office.Location = new System.Drawing.Point(555, 192);
            this.textBox_Office.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_Office.Name = "textBox_Office";
            this.textBox_Office.Size = new System.Drawing.Size(293, 49);
            this.textBox_Office.TabIndex = 77;
            // 
            // button_AddPublisher
            // 
            this.button_AddPublisher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddPublisher.Location = new System.Drawing.Point(552, 328);
            this.button_AddPublisher.Name = "button_AddPublisher";
            this.button_AddPublisher.Size = new System.Drawing.Size(293, 65);
            this.button_AddPublisher.TabIndex = 79;
            this.button_AddPublisher.Text = "Add";
            this.button_AddPublisher.UseVisualStyleBackColor = true;
            this.button_AddPublisher.Click += new System.EventHandler(this.button_AddPublisher_Click);
            // 
            // label_PublisherName
            // 
            this.label_PublisherName.AutoSize = true;
            this.label_PublisherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PublisherName.Location = new System.Drawing.Point(551, 74);
            this.label_PublisherName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_PublisherName.Name = "label_PublisherName";
            this.label_PublisherName.Size = new System.Drawing.Size(169, 24);
            this.label_PublisherName.TabIndex = 62;
            this.label_PublisherName.Text = "Name of publisher:";
            // 
            // textBox_PublisherName
            // 
            this.textBox_PublisherName.BackColor = System.Drawing.Color.White;
            this.textBox_PublisherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_PublisherName.Location = new System.Drawing.Point(551, 104);
            this.textBox_PublisherName.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_PublisherName.Name = "textBox_PublisherName";
            this.textBox_PublisherName.Size = new System.Drawing.Size(293, 49);
            this.textBox_PublisherName.TabIndex = 76;
            // 
            // dataGridView_Publisher
            // 
            this.dataGridView_Publisher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Publisher.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Publisher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Publisher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Publisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Publisher.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Publisher.Location = new System.Drawing.Point(13, 74);
            this.dataGridView_Publisher.MultiSelect = false;
            this.dataGridView_Publisher.Name = "dataGridView_Publisher";
            this.dataGridView_Publisher.ReadOnly = true;
            this.dataGridView_Publisher.RowTemplate.Height = 40;
            this.dataGridView_Publisher.Size = new System.Drawing.Size(518, 319);
            this.dataGridView_Publisher.TabIndex = 75;
            this.dataGridView_Publisher.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Publisher_MouseClick);
            // 
            // groupBox_Genres
            // 
            this.groupBox_Genres.Controls.Add(this.button_SearchGenre);
            this.groupBox_Genres.Controls.Add(this.button_CancelGenre);
            this.groupBox_Genres.Controls.Add(this.textBox_SearchGenre);
            this.groupBox_Genres.Controls.Add(this.button_AddGenre);
            this.groupBox_Genres.Controls.Add(this.label_GenreName);
            this.groupBox_Genres.Controls.Add(this.textBox_GenreName);
            this.groupBox_Genres.Controls.Add(this.dataGridView_Genre);
            this.groupBox_Genres.Location = new System.Drawing.Point(900, 514);
            this.groupBox_Genres.Name = "groupBox_Genres";
            this.groupBox_Genres.Size = new System.Drawing.Size(780, 410);
            this.groupBox_Genres.TabIndex = 74;
            this.groupBox_Genres.TabStop = false;
            // 
            // button_SearchGenre
            // 
            this.button_SearchGenre.BackColor = System.Drawing.SystemColors.Control;
            this.button_SearchGenre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_SearchGenre.BackgroundImage")));
            this.button_SearchGenre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_SearchGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SearchGenre.Location = new System.Drawing.Point(358, 31);
            this.button_SearchGenre.Name = "button_SearchGenre";
            this.button_SearchGenre.Size = new System.Drawing.Size(44, 40);
            this.button_SearchGenre.TabIndex = 82;
            this.button_SearchGenre.UseVisualStyleBackColor = false;
            // 
            // button_CancelGenre
            // 
            this.button_CancelGenre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CancelGenre.Location = new System.Drawing.Point(637, 182);
            this.button_CancelGenre.Name = "button_CancelGenre";
            this.button_CancelGenre.Size = new System.Drawing.Size(118, 65);
            this.button_CancelGenre.TabIndex = 81;
            this.button_CancelGenre.Text = "Cancel Editing";
            this.button_CancelGenre.UseVisualStyleBackColor = true;
            this.button_CancelGenre.Visible = false;
            this.button_CancelGenre.Click += new System.EventHandler(this.button_CancelGenre_Click);
            // 
            // textBox_SearchGenre
            // 
            this.textBox_SearchGenre.BackColor = System.Drawing.Color.White;
            this.textBox_SearchGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SearchGenre.Location = new System.Drawing.Point(32, 31);
            this.textBox_SearchGenre.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_SearchGenre.Name = "textBox_SearchGenre";
            this.textBox_SearchGenre.Size = new System.Drawing.Size(326, 40);
            this.textBox_SearchGenre.TabIndex = 81;
            this.textBox_SearchGenre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_SearchGenre_KeyUp);
            // 
            // button_AddGenre
            // 
            this.button_AddGenre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddGenre.Location = new System.Drawing.Point(426, 182);
            this.button_AddGenre.Name = "button_AddGenre";
            this.button_AddGenre.Size = new System.Drawing.Size(329, 65);
            this.button_AddGenre.TabIndex = 73;
            this.button_AddGenre.Text = "Add";
            this.button_AddGenre.UseVisualStyleBackColor = true;
            this.button_AddGenre.Click += new System.EventHandler(this.button_AddGenre_Click);
            // 
            // label_GenreName
            // 
            this.label_GenreName.AutoSize = true;
            this.label_GenreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_GenreName.Location = new System.Drawing.Point(422, 80);
            this.label_GenreName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_GenreName.Name = "label_GenreName";
            this.label_GenreName.Size = new System.Drawing.Size(141, 24);
            this.label_GenreName.TabIndex = 62;
            this.label_GenreName.Text = "Name of genre:";
            // 
            // textBox_GenreName
            // 
            this.textBox_GenreName.BackColor = System.Drawing.Color.White;
            this.textBox_GenreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_GenreName.Location = new System.Drawing.Point(426, 111);
            this.textBox_GenreName.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_GenreName.Name = "textBox_GenreName";
            this.textBox_GenreName.Size = new System.Drawing.Size(329, 49);
            this.textBox_GenreName.TabIndex = 72;
            this.textBox_GenreName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_GenreName_KeyPress);
            // 
            // dataGridView_Genre
            // 
            this.dataGridView_Genre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Genre.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Genre.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Genre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Genre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Genre.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_Genre.Location = new System.Drawing.Point(32, 80);
            this.dataGridView_Genre.MultiSelect = false;
            this.dataGridView_Genre.Name = "dataGridView_Genre";
            this.dataGridView_Genre.ReadOnly = true;
            this.dataGridView_Genre.RowTemplate.Height = 40;
            this.dataGridView_Genre.Size = new System.Drawing.Size(370, 313);
            this.dataGridView_Genre.TabIndex = 71;
            this.dataGridView_Genre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Genre_MouseClick);
            // 
            // FormAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1757, 936);
            this.Controls.Add(this.groupBox_Genres);
            this.Controls.Add(this.groupBox_Publishers);
            this.Controls.Add(this.groupBox_Authors);
            this.Controls.Add(this.groupBox_Books);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormAdding";
            this.Text = "FormAdding";
            this.Load += new System.EventHandler(this.FormAdding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_QuantityInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberOfPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Year)).EndInit();
            this.groupBox_Books.ResumeLayout(false);
            this.groupBox_Books.PerformLayout();
            this.groupBox_Authors.ResumeLayout(false);
            this.groupBox_Authors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Author)).EndInit();
            this.groupBox_Publishers.ResumeLayout(false);
            this.groupBox_Publishers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Publisher)).EndInit();
            this.groupBox_Genres.ResumeLayout(false);
            this.groupBox_Genres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Genre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_hrn2;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.ComboBox comboBox_Genre;
        private System.Windows.Forms.NumericUpDown numericUpDown_QuantityInStock;
        private System.Windows.Forms.Label label_Publisher;
        private System.Windows.Forms.Label label_QuantityInStock;
        private System.Windows.Forms.Label label_Genre;
        private System.Windows.Forms.NumericUpDown numericUpDown_NumberOfPages;
        private System.Windows.Forms.NumericUpDown numericUpDown_Year;
        private System.Windows.Forms.Label label_NumberOfPages;
        private System.Windows.Forms.ComboBox comboBox_Author;
        private System.Windows.Forms.Label label_YearOfIssue;
        private System.Windows.Forms.ComboBox comboBox_Publisher;
        private System.Windows.Forms.GroupBox groupBox_Books;
        private System.Windows.Forms.GroupBox groupBox_Authors;
        private System.Windows.Forms.DataGridView dataGridView_Author;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_AuthorName;
        private System.Windows.Forms.Button button_AddAuthor;
        private System.Windows.Forms.GroupBox groupBox_Publishers;
        private System.Windows.Forms.Button button_AddPublisher;
        private System.Windows.Forms.Label label_PublisherName;
        private System.Windows.Forms.TextBox textBox_PublisherName;
        private System.Windows.Forms.DataGridView dataGridView_Publisher;
        private System.Windows.Forms.Label label_PhoneNumber;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.Label label_Office;
        private System.Windows.Forms.TextBox textBox_Office;
        private System.Windows.Forms.GroupBox groupBox_Genres;
        private System.Windows.Forms.Button button_AddGenre;
        private System.Windows.Forms.Label label_GenreName;
        private System.Windows.Forms.TextBox textBox_GenreName;
        private System.Windows.Forms.DataGridView dataGridView_Genre;
        private System.Windows.Forms.Button button_CancelBook;
        private System.Windows.Forms.Button button_AddBook;
        private System.Windows.Forms.Button button_CancelAuthor;
        private System.Windows.Forms.Button button_CancelPublisher;
        private System.Windows.Forms.Button button_CancelGenre;
        private System.Windows.Forms.TextBox textBox_SearchAuthor;
        private System.Windows.Forms.Button button_SearchAuthor;
        private System.Windows.Forms.Button button_SearchPublisher;
        private System.Windows.Forms.TextBox textBox_SearchPublisher;
        private System.Windows.Forms.Button button_SearchGenre;
        private System.Windows.Forms.TextBox textBox_SearchGenre;
    }
}