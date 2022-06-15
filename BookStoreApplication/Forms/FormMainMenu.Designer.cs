using System.Drawing;

namespace BookStoreApplication
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button_Settings = new System.Windows.Forms.Button();
            this.button_Archive = new System.Windows.Forms.Button();
            this.button_AddingInfo = new System.Windows.Forms.Button();
            this.button_Basket = new System.Windows.Forms.Button();
            this.button_Products = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label_ByMe = new System.Windows.Forms.Label();
            this.panel_TitleBar = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.panel_Desktop = new System.Windows.Forms.Panel();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel_TitleBar.SuspendLayout();
            this.panel_Desktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.button_Settings);
            this.panelMenu.Controls.Add(this.button_Archive);
            this.panelMenu.Controls.Add(this.button_AddingInfo);
            this.panelMenu.Controls.Add(this.button_Basket);
            this.panelMenu.Controls.Add(this.button_Products);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 556);
            this.panelMenu.TabIndex = 0;
            // 
            // button_Settings
            // 
            this.button_Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Settings.Enabled = false;
            this.button_Settings.FlatAppearance.BorderSize = 0;
            this.button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Settings.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_Settings.Location = new System.Drawing.Point(0, 320);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Size = new System.Drawing.Size(220, 60);
            this.button_Settings.TabIndex = 5;
            this.button_Settings.Text = "Admin Settings";
            this.button_Settings.UseVisualStyleBackColor = true;
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // button_Archive
            // 
            this.button_Archive.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Archive.Enabled = false;
            this.button_Archive.FlatAppearance.BorderSize = 0;
            this.button_Archive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Archive.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_Archive.Location = new System.Drawing.Point(0, 260);
            this.button_Archive.Name = "button_Archive";
            this.button_Archive.Size = new System.Drawing.Size(220, 60);
            this.button_Archive.TabIndex = 4;
            this.button_Archive.Text = "Archive";
            this.button_Archive.UseVisualStyleBackColor = true;
            this.button_Archive.Click += new System.EventHandler(this.button_Archive_Click);
            // 
            // button_AddingInfo
            // 
            this.button_AddingInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_AddingInfo.Enabled = false;
            this.button_AddingInfo.FlatAppearance.BorderSize = 0;
            this.button_AddingInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddingInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_AddingInfo.Location = new System.Drawing.Point(0, 200);
            this.button_AddingInfo.Name = "button_AddingInfo";
            this.button_AddingInfo.Size = new System.Drawing.Size(220, 60);
            this.button_AddingInfo.TabIndex = 3;
            this.button_AddingInfo.Text = "Adding Info";
            this.button_AddingInfo.UseVisualStyleBackColor = true;
            this.button_AddingInfo.Click += new System.EventHandler(this.button_AddingInfo_Click);
            // 
            // button_Basket
            // 
            this.button_Basket.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Basket.Enabled = false;
            this.button_Basket.FlatAppearance.BorderSize = 0;
            this.button_Basket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Basket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Basket.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_Basket.Location = new System.Drawing.Point(0, 140);
            this.button_Basket.Name = "button_Basket";
            this.button_Basket.Size = new System.Drawing.Size(220, 60);
            this.button_Basket.TabIndex = 2;
            this.button_Basket.Text = "Basket";
            this.button_Basket.UseVisualStyleBackColor = true;
            this.button_Basket.Click += new System.EventHandler(this.button_Basket_Click);
            // 
            // button_Products
            // 
            this.button_Products.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Products.Enabled = false;
            this.button_Products.FlatAppearance.BorderSize = 0;
            this.button_Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Products.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_Products.Location = new System.Drawing.Point(0, 80);
            this.button_Products.Name = "button_Products";
            this.button_Products.Size = new System.Drawing.Size(220, 60);
            this.button_Products.TabIndex = 1;
            this.button_Products.Text = "Products";
            this.button_Products.UseVisualStyleBackColor = true;
            this.button_Products.Click += new System.EventHandler(this.button_Products_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label_ByMe);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label_ByMe
            // 
            this.label_ByMe.AutoSize = true;
            this.label_ByMe.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ByMe.ForeColor = System.Drawing.Color.LightGray;
            this.label_ByMe.Location = new System.Drawing.Point(35, 35);
            this.label_ByMe.Name = "label_ByMe";
            this.label_ByMe.Size = new System.Drawing.Size(144, 16);
            this.label_ByMe.TabIndex = 0;
            this.label_ByMe.Text = "by Andrii Sakhno 2022";
            // 
            // panel_TitleBar
            // 
            this.panel_TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel_TitleBar.Controls.Add(this.button_Close);
            this.panel_TitleBar.Controls.Add(this.label_Title);
            this.panel_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TitleBar.Location = new System.Drawing.Point(220, 0);
            this.panel_TitleBar.Name = "panel_TitleBar";
            this.panel_TitleBar.Size = new System.Drawing.Size(847, 80);
            this.panel_TitleBar.TabIndex = 0;
            // 
            // button_Close
            // 
            this.button_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Close.BackgroundImage")));
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(214)))), ((int)(((byte)(195)))));
            this.button_Close.Location = new System.Drawing.Point(25, 12);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(60, 60);
            this.button_Close.TabIndex = 0;
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(113, 28);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(84, 27);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "HOME";
            // 
            // panel_Desktop
            // 
            this.panel_Desktop.BackColor = System.Drawing.Color.White;
            this.panel_Desktop.Controls.Add(this.progressBar);
            this.panel_Desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Desktop.Location = new System.Drawing.Point(220, 80);
            this.panel_Desktop.Name = "panel_Desktop";
            this.panel_Desktop.Size = new System.Drawing.Size(847, 476);
            this.panel_Desktop.TabIndex = 1;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar.Location = new System.Drawing.Point(390, 226);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(40, 14);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 0;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 556);
            this.Controls.Add(this.panel_Desktop);
            this.Controls.Add(this.panel_TitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel_TitleBar.ResumeLayout(false);
            this.panel_TitleBar.PerformLayout();
            this.panel_Desktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button button_Settings;
        private System.Windows.Forms.Button button_Archive;
        public System.Windows.Forms.Button button_AddingInfo;
        private System.Windows.Forms.Button button_Basket;
        private System.Windows.Forms.Button button_Products;
        private System.Windows.Forms.Label label_ByMe;
        private System.Windows.Forms.Panel panel_TitleBar;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Panel panel_Desktop;
        private System.Windows.Forms.Button button_Close;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

