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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox_Basket = new System.Windows.Forms.GroupBox();
            this.dataGridView_Products = new System.Windows.Forms.DataGridView();
            this.numericUpDown_ProductToBasket = new System.Windows.Forms.NumericUpDown();
            this.textBox_ProductToBasket = new System.Windows.Forms.TextBox();
            this.button_AddToBasket = new System.Windows.Forms.Button();
            this.label_Total = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox_Basket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ProductToBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 23);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 23);
            this.panel2.TabIndex = 10;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Search.Location = new System.Drawing.Point(0, 23);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(1115, 47);
            this.textBox_Search.TabIndex = 10;
            this.textBox_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Search_KeyUp);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1115, 23);
            this.panel3.TabIndex = 11;
            // 
            // groupBox_Basket
            // 
            this.groupBox_Basket.Controls.Add(this.label_Total);
            this.groupBox_Basket.Controls.Add(this.button_AddToBasket);
            this.groupBox_Basket.Controls.Add(this.textBox_ProductToBasket);
            this.groupBox_Basket.Controls.Add(this.numericUpDown_ProductToBasket);
            this.groupBox_Basket.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_Basket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Basket.Location = new System.Drawing.Point(0, 412);
            this.groupBox_Basket.Name = "groupBox_Basket";
            this.groupBox_Basket.Size = new System.Drawing.Size(1115, 194);
            this.groupBox_Basket.TabIndex = 2;
            this.groupBox_Basket.TabStop = false;
            this.groupBox_Basket.Text = "Basket";
            this.groupBox_Basket.Visible = false;
            // 
            // dataGridView_Products
            // 
            this.dataGridView_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Products.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Products.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Products.Location = new System.Drawing.Point(0, 93);
            this.dataGridView_Products.MultiSelect = false;
            this.dataGridView_Products.Name = "dataGridView_Products";
            this.dataGridView_Products.ReadOnly = true;
            this.dataGridView_Products.RowTemplate.Height = 40;
            this.dataGridView_Products.Size = new System.Drawing.Size(1115, 319);
            this.dataGridView_Products.TabIndex = 16;
            this.dataGridView_Products.DoubleClick += new System.EventHandler(this.dataGridView_Products_DoubleClick);
            this.dataGridView_Products.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Products_MouseClick);
            // 
            // numericUpDown_ProductToBasket
            // 
            this.numericUpDown_ProductToBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.numericUpDown_ProductToBasket.Location = new System.Drawing.Point(147, 105);
            this.numericUpDown_ProductToBasket.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ProductToBasket.Name = "numericUpDown_ProductToBasket";
            this.numericUpDown_ProductToBasket.Size = new System.Drawing.Size(120, 49);
            this.numericUpDown_ProductToBasket.TabIndex = 1;
            this.numericUpDown_ProductToBasket.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox_ProductToBasket
            // 
            this.textBox_ProductToBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ProductToBasket.Location = new System.Drawing.Point(147, 54);
            this.textBox_ProductToBasket.Name = "textBox_ProductToBasket";
            this.textBox_ProductToBasket.ReadOnly = true;
            this.textBox_ProductToBasket.Size = new System.Drawing.Size(384, 35);
            this.textBox_ProductToBasket.TabIndex = 2;
            // 
            // button_AddToBasket
            // 
            this.button_AddToBasket.Location = new System.Drawing.Point(285, 105);
            this.button_AddToBasket.Name = "button_AddToBasket";
            this.button_AddToBasket.Size = new System.Drawing.Size(246, 49);
            this.button_AddToBasket.TabIndex = 3;
            this.button_AddToBasket.Text = "Add To Basket";
            this.button_AddToBasket.UseVisualStyleBackColor = true;
            this.button_AddToBasket.Click += new System.EventHandler(this.button_AddToBasket_Click);
            // 
            // label_Total
            // 
            this.label_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Total.Location = new System.Drawing.Point(687, 70);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(143, 55);
            this.label_Total.TabIndex = 4;
            this.label_Total.Text = "Total:";
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 606);
            this.Controls.Add(this.dataGridView_Products);
            this.Controls.Add(this.groupBox_Basket);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.panel1);
            this.Name = "FormProducts";
            this.Text = "FormProducts";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox_Basket.ResumeLayout(false);
            this.groupBox_Basket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ProductToBasket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox_Basket;
        private System.Windows.Forms.DataGridView dataGridView_Products;
        private System.Windows.Forms.TextBox textBox_ProductToBasket;
        private System.Windows.Forms.NumericUpDown numericUpDown_ProductToBasket;
        private System.Windows.Forms.Button button_AddToBasket;
        private System.Windows.Forms.Label label_Total;
    }
}