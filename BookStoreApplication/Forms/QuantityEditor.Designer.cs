namespace BookStoreApplication.Forms
{
    partial class QuantityEditor
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
            this.groupBox_ChangeQuantity = new System.Windows.Forms.GroupBox();
            this.numericUpDown_Quantity = new System.Windows.Forms.NumericUpDown();
            this.button_Save = new System.Windows.Forms.Button();
            this.label_Maximum = new System.Windows.Forms.Label();
            this.groupBox_ChangeQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_ChangeQuantity
            // 
            this.groupBox_ChangeQuantity.Controls.Add(this.label_Maximum);
            this.groupBox_ChangeQuantity.Controls.Add(this.numericUpDown_Quantity);
            this.groupBox_ChangeQuantity.Location = new System.Drawing.Point(13, 13);
            this.groupBox_ChangeQuantity.Name = "groupBox_ChangeQuantity";
            this.groupBox_ChangeQuantity.Size = new System.Drawing.Size(258, 94);
            this.groupBox_ChangeQuantity.TabIndex = 0;
            this.groupBox_ChangeQuantity.TabStop = false;
            this.groupBox_ChangeQuantity.Text = "Change quantity of items";
            // 
            // numericUpDown_Quantity
            // 
            this.numericUpDown_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_Quantity.Location = new System.Drawing.Point(61, 38);
            this.numericUpDown_Quantity.MaximumSize = new System.Drawing.Size(120, 0);
            this.numericUpDown_Quantity.Name = "numericUpDown_Quantity";
            this.numericUpDown_Quantity.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown_Quantity.TabIndex = 0;
            // 
            // button_Save
            // 
            this.button_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Save.Location = new System.Drawing.Point(13, 114);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(258, 51);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label_Maximum
            // 
            this.label_Maximum.AutoSize = true;
            this.label_Maximum.Location = new System.Drawing.Point(142, 70);
            this.label_Maximum.Name = "label_Maximum";
            this.label_Maximum.Size = new System.Drawing.Size(58, 13);
            this.label_Maximum.TabIndex = 1;
            this.label_Maximum.Text = "(x in stock)";
            // 
            // QuantityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.groupBox_ChangeQuantity);
            this.MaximumSize = new System.Drawing.Size(300, 210);
            this.MinimumSize = new System.Drawing.Size(300, 210);
            this.Name = "QuantityEditor";
            this.Text = "QuantityEditor";
            this.Load += new System.EventHandler(this.QuantityEditor_Load);
            this.groupBox_ChangeQuantity.ResumeLayout(false);
            this.groupBox_ChangeQuantity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_ChangeQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDown_Quantity;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label_Maximum;
    }
}