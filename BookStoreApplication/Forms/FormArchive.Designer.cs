namespace BookStoreApplication.Forms
{
    partial class FormArchive
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel = new System.Windows.Forms.Panel();
            this.label_From = new System.Windows.Forms.Label();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_Archive = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Archive)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label_From);
            this.panel.Controls.Add(this.dateTimePicker_From);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 55);
            this.panel.TabIndex = 0;
            // 
            // label_From
            // 
            this.label_From.AutoSize = true;
            this.label_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_From.Location = new System.Drawing.Point(12, 9);
            this.label_From.Name = "label_From";
            this.label_From.Size = new System.Drawing.Size(33, 13);
            this.label_From.TabIndex = 9;
            this.label_From.Text = "From:";
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Location = new System.Drawing.Point(34, 25);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker_From.TabIndex = 0;
            this.dateTimePicker_From.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dataGridView_Archive
            // 
            this.dataGridView_Archive.AllowUserToAddRows = false;
            this.dataGridView_Archive.AllowUserToDeleteRows = false;
            this.dataGridView_Archive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Archive.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Archive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Archive.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Archive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Archive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Archive.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Archive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Archive.Location = new System.Drawing.Point(0, 55);
            this.dataGridView_Archive.Name = "dataGridView_Archive";
            this.dataGridView_Archive.ReadOnly = true;
            this.dataGridView_Archive.RowTemplate.Height = 40;
            this.dataGridView_Archive.Size = new System.Drawing.Size(800, 395);
            this.dataGridView_Archive.TabIndex = 19;
            // 
            // FormArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_Archive);
            this.Controls.Add(this.panel);
            this.Name = "FormArchive";
            this.Text = "FormArchive";
            this.Load += new System.EventHandler(this.FormArchive_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Archive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dataGridView_Archive;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.Label label_From;
    }
}