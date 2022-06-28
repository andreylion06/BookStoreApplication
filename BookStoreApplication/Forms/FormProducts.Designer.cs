namespace BookStoreApplication.Forms
{
    partial class FormProducts
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label_All = new System.Windows.Forms.Label();
            this.checkBox_All = new System.Windows.Forms.CheckBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.groupBox_Basket = new System.Windows.Forms.GroupBox();
            this.groupBox_Total = new System.Windows.Forms.GroupBox();
            this.label_Total = new System.Windows.Forms.Label();
            this.label_hrn = new System.Windows.Forms.Label();
            this.groupBox_AddingInBasket = new System.Windows.Forms.GroupBox();
            this.label_InBasket = new System.Windows.Forms.Label();
            this.label_Quantity = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.numericUpDown_Quantity = new System.Windows.Forms.NumericUpDown();
            this.button_AddToBasket = new System.Windows.Forms.Button();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label_AuthorName = new System.Windows.Forms.Label();
            this.textBox_AuthorName = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.dataGridView_Products = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            this.groupBox_Basket.SuspendLayout();
            this.groupBox_Total.SuspendLayout();
            this.groupBox_AddingInBasket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Search.Location = new System.Drawing.Point(12, 24);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(1019, 47);
            this.textBox_Search.TabIndex = 10;
            this.textBox_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Search_KeyUp);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label_All);
            this.panel.Controls.Add(this.checkBox_All);
            this.panel.Controls.Add(this.button_Search);
            this.panel.Controls.Add(this.textBox_Search);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1115, 100);
            this.panel.TabIndex = 11;
            // 
            // label_All
            // 
            this.label_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_All.AutoSize = true;
            this.label_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_All.Location = new System.Drawing.Point(1055, 73);
            this.label_All.Name = "label_All";
            this.label_All.Size = new System.Drawing.Size(22, 18);
            this.label_All.TabIndex = 84;
            this.label_All.Text = "all";
            // 
            // checkBox_All
            // 
            this.checkBox_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_All.AutoSize = true;
            this.checkBox_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_All.Location = new System.Drawing.Point(1040, 77);
            this.checkBox_All.Name = "checkBox_All";
            this.checkBox_All.Size = new System.Drawing.Size(15, 14);
            this.checkBox_All.TabIndex = 83;
            this.checkBox_All.UseVisualStyleBackColor = true;
            this.checkBox_All.CheckedChanged += new System.EventHandler(this.checkBox_All_CheckedChanged);
            // 
            // button_Search
            // 
            this.button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Search.BackColor = System.Drawing.SystemColors.Control;
            this.button_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Search.BackgroundImage")));
            this.button_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Location = new System.Drawing.Point(1030, 24);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(49, 47);
            this.button_Search.TabIndex = 81;
            this.button_Search.UseVisualStyleBackColor = false;
            // 
            // groupBox_Basket
            // 
            this.groupBox_Basket.Controls.Add(this.groupBox_Total);
            this.groupBox_Basket.Controls.Add(this.groupBox_AddingInBasket);
            this.groupBox_Basket.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_Basket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Basket.Location = new System.Drawing.Point(0, 412);
            this.groupBox_Basket.Name = "groupBox_Basket";
            this.groupBox_Basket.Size = new System.Drawing.Size(1115, 194);
            this.groupBox_Basket.TabIndex = 2;
            this.groupBox_Basket.TabStop = false;
            this.groupBox_Basket.Visible = false;
            // 
            // groupBox_Total
            // 
            this.groupBox_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Total.Controls.Add(this.label_Total);
            this.groupBox_Total.Controls.Add(this.label_hrn);
            this.groupBox_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Total.Location = new System.Drawing.Point(859, 19);
            this.groupBox_Total.Name = "groupBox_Total";
            this.groupBox_Total.Size = new System.Drawing.Size(220, 145);
            this.groupBox_Total.TabIndex = 6;
            this.groupBox_Total.TabStop = false;
            this.groupBox_Total.Text = "Total";
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Total.Location = new System.Drawing.Point(27, 55);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(123, 42);
            this.label_Total.TabIndex = 78;
            this.label_Total.Text = "00000";
            // 
            // label_hrn
            // 
            this.label_hrn.AutoSize = true;
            this.label_hrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_hrn.Location = new System.Drawing.Point(156, 79);
            this.label_hrn.Name = "label_hrn";
            this.label_hrn.Size = new System.Drawing.Size(43, 24);
            this.label_hrn.TabIndex = 77;
            this.label_hrn.Text = "hrn.";
            // 
            // groupBox_AddingInBasket
            // 
            this.groupBox_AddingInBasket.Controls.Add(this.label_InBasket);
            this.groupBox_AddingInBasket.Controls.Add(this.label_Quantity);
            this.groupBox_AddingInBasket.Controls.Add(this.label_Price);
            this.groupBox_AddingInBasket.Controls.Add(this.numericUpDown_Quantity);
            this.groupBox_AddingInBasket.Controls.Add(this.button_AddToBasket);
            this.groupBox_AddingInBasket.Controls.Add(this.textBox_Price);
            this.groupBox_AddingInBasket.Controls.Add(this.label_AuthorName);
            this.groupBox_AddingInBasket.Controls.Add(this.textBox_AuthorName);
            this.groupBox_AddingInBasket.Controls.Add(this.label_Title);
            this.groupBox_AddingInBasket.Controls.Add(this.textBox_Title);
            this.groupBox_AddingInBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_AddingInBasket.Location = new System.Drawing.Point(37, 19);
            this.groupBox_AddingInBasket.Name = "groupBox_AddingInBasket";
            this.groupBox_AddingInBasket.Size = new System.Drawing.Size(575, 163);
            this.groupBox_AddingInBasket.TabIndex = 5;
            this.groupBox_AddingInBasket.TabStop = false;
            this.groupBox_AddingInBasket.Text = "Adding to basket";
            // 
            // label_InBasket
            // 
            this.label_InBasket.AutoSize = true;
            this.label_InBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_InBasket.Location = new System.Drawing.Point(343, 134);
            this.label_InBasket.Name = "label_InBasket";
            this.label_InBasket.Size = new System.Drawing.Size(64, 13);
            this.label_InBasket.TabIndex = 10;
            this.label_InBasket.Text = "(x in basket)";
            // 
            // label_Quantity
            // 
            this.label_Quantity.AutoSize = true;
            this.label_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Quantity.Location = new System.Drawing.Point(239, 79);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(49, 13);
            this.label_Quantity.TabIndex = 9;
            this.label_Quantity.Text = "Quantity:";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Price.Location = new System.Drawing.Point(239, 26);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(34, 13);
            this.label_Price.TabIndex = 8;
            this.label_Price.Text = "Price:";
            // 
            // numericUpDown_Quantity
            // 
            this.numericUpDown_Quantity.Enabled = false;
            this.numericUpDown_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_Quantity.Location = new System.Drawing.Point(253, 93);
            this.numericUpDown_Quantity.Name = "numericUpDown_Quantity";
            this.numericUpDown_Quantity.Size = new System.Drawing.Size(128, 38);
            this.numericUpDown_Quantity.TabIndex = 1;
            // 
            // button_AddToBasket
            // 
            this.button_AddToBasket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddToBasket.Location = new System.Drawing.Point(397, 38);
            this.button_AddToBasket.Name = "button_AddToBasket";
            this.button_AddToBasket.Size = new System.Drawing.Size(164, 92);
            this.button_AddToBasket.TabIndex = 3;
            this.button_AddToBasket.Text = "Add To Basket";
            this.button_AddToBasket.UseVisualStyleBackColor = true;
            this.button_AddToBasket.Click += new System.EventHandler(this.button_AddToBasket_Click);
            // 
            // textBox_Price
            // 
            this.textBox_Price.Enabled = false;
            this.textBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Price.Location = new System.Drawing.Point(253, 42);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(128, 35);
            this.textBox_Price.TabIndex = 7;
            // 
            // label_AuthorName
            // 
            this.label_AuthorName.AutoSize = true;
            this.label_AuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_AuthorName.Location = new System.Drawing.Point(7, 79);
            this.label_AuthorName.Name = "label_AuthorName";
            this.label_AuthorName.Size = new System.Drawing.Size(70, 13);
            this.label_AuthorName.TabIndex = 6;
            this.label_AuthorName.Text = "Author name:";
            // 
            // textBox_AuthorName
            // 
            this.textBox_AuthorName.Enabled = false;
            this.textBox_AuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_AuthorName.Location = new System.Drawing.Point(21, 95);
            this.textBox_AuthorName.Name = "textBox_AuthorName";
            this.textBox_AuthorName.Size = new System.Drawing.Size(215, 35);
            this.textBox_AuthorName.TabIndex = 5;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Title.Location = new System.Drawing.Point(7, 26);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(30, 13);
            this.label_Title.TabIndex = 4;
            this.label_Title.Text = "Title:";
            // 
            // textBox_Title
            // 
            this.textBox_Title.Enabled = false;
            this.textBox_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Title.Location = new System.Drawing.Point(21, 42);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(215, 35);
            this.textBox_Title.TabIndex = 2;
            // 
            // dataGridView_Products
            // 
            this.dataGridView_Products.AllowUserToAddRows = false;
            this.dataGridView_Products.AllowUserToDeleteRows = false;
            this.dataGridView_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Products.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Products.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView_Products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Products.Location = new System.Drawing.Point(0, 100);
            this.dataGridView_Products.MultiSelect = false;
            this.dataGridView_Products.Name = "dataGridView_Products";
            this.dataGridView_Products.ReadOnly = true;
            this.dataGridView_Products.RowTemplate.Height = 40;
            this.dataGridView_Products.Size = new System.Drawing.Size(1115, 312);
            this.dataGridView_Products.TabIndex = 17;
            this.dataGridView_Products.DoubleClick += new System.EventHandler(this.dataGridView_Products_DoubleClick);
            this.dataGridView_Products.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Products_MouseClick);
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 606);
            this.Controls.Add(this.dataGridView_Products);
            this.Controls.Add(this.groupBox_Basket);
            this.Controls.Add(this.panel);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "FormProducts";
            this.Text = "FormProducts";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.groupBox_Basket.ResumeLayout(false);
            this.groupBox_Total.ResumeLayout(false);
            this.groupBox_Total.PerformLayout();
            this.groupBox_AddingInBasket.ResumeLayout(false);
            this.groupBox_AddingInBasket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBox_Basket;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.NumericUpDown numericUpDown_Quantity;
        private System.Windows.Forms.Button button_AddToBasket;
        private System.Windows.Forms.GroupBox groupBox_AddingInBasket;
        private System.Windows.Forms.GroupBox groupBox_Total;
        private System.Windows.Forms.Label label_hrn;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Quantity;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label_AuthorName;
        private System.Windows.Forms.TextBox textBox_AuthorName;
        private System.Windows.Forms.Label label_InBasket;
        private System.Windows.Forms.DataGridView dataGridView_Products;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.CheckBox checkBox_All;
        private System.Windows.Forms.Label label_All;
    }
}