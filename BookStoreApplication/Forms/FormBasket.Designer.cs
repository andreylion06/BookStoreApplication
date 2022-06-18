namespace BookStoreApplication.Forms
{
    partial class FormBasket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView_Basket = new System.Windows.Forms.DataGridView();
            this.groupBox_Total = new System.Windows.Forms.GroupBox();
            this.label_Total = new System.Windows.Forms.Label();
            this.label_hrn = new System.Windows.Forms.Label();
            this.button_Sell = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Basket)).BeginInit();
            this.groupBox_Total.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.button_Sell);
            this.groupBox.Controls.Add(this.groupBox_Total);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox.Location = new System.Drawing.Point(0, 244);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(800, 206);
            this.groupBox.TabIndex = 18;
            this.groupBox.TabStop = false;
            // 
            // dataGridView_Basket
            // 
            this.dataGridView_Basket.AllowUserToAddRows = false;
            this.dataGridView_Basket.AllowUserToDeleteRows = false;
            this.dataGridView_Basket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Basket.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Basket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Basket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Basket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_Basket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Basket.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_Basket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Basket.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Basket.MultiSelect = false;
            this.dataGridView_Basket.Name = "dataGridView_Basket";
            this.dataGridView_Basket.ReadOnly = true;
            this.dataGridView_Basket.RowTemplate.Height = 40;
            this.dataGridView_Basket.Size = new System.Drawing.Size(800, 244);
            this.dataGridView_Basket.TabIndex = 19;
            this.dataGridView_Basket.DoubleClick += new System.EventHandler(this.dataGridView_Basket_DoubleClick);
            this.dataGridView_Basket.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Basket_MouseClick);
            // 
            // groupBox_Total
            // 
            this.groupBox_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Total.Controls.Add(this.label_Total);
            this.groupBox_Total.Controls.Add(this.label_hrn);
            this.groupBox_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Total.Location = new System.Drawing.Point(541, 35);
            this.groupBox_Total.Name = "groupBox_Total";
            this.groupBox_Total.Size = new System.Drawing.Size(220, 145);
            this.groupBox_Total.TabIndex = 7;
            this.groupBox_Total.TabStop = false;
            this.groupBox_Total.Text = "Total";
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Total.Location = new System.Drawing.Point(13, 52);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(159, 55);
            this.label_Total.TabIndex = 78;
            this.label_Total.Text = "00000";
            // 
            // label_hrn
            // 
            this.label_hrn.AutoSize = true;
            this.label_hrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_hrn.Location = new System.Drawing.Point(171, 83);
            this.label_hrn.Name = "label_hrn";
            this.label_hrn.Size = new System.Drawing.Size(43, 24);
            this.label_hrn.TabIndex = 77;
            this.label_hrn.Text = "hrn.";
            // 
            // button_Sell
            // 
            this.button_Sell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Sell.Location = new System.Drawing.Point(42, 35);
            this.button_Sell.Name = "button_Sell";
            this.button_Sell.Size = new System.Drawing.Size(264, 145);
            this.button_Sell.TabIndex = 8;
            this.button_Sell.Text = "Sell";
            this.button_Sell.UseVisualStyleBackColor = true;
            this.button_Sell.Click += new System.EventHandler(this.button_Sell_Click);
            // 
            // FormBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_Basket);
            this.Controls.Add(this.groupBox);
            this.Name = "FormBasket";
            this.Text = "FormBasket";
            this.Load += new System.EventHandler(this.FormBasket_Load);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Basket)).EndInit();
            this.groupBox_Total.ResumeLayout(false);
            this.groupBox_Total.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView dataGridView_Basket;
        private System.Windows.Forms.GroupBox groupBox_Total;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Label label_hrn;
        private System.Windows.Forms.Button button_Sell;
    }
}