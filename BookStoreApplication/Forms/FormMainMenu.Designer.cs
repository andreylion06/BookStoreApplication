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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.button_Logout = new System.Windows.Forms.Button();
            this.button_Statistics = new System.Windows.Forms.Button();
            this.button_Archive = new System.Windows.Forms.Button();
            this.button_AddingInfo = new System.Windows.Forms.Button();
            this.button_Basket = new System.Windows.Forms.Button();
            this.button_Products = new System.Windows.Forms.Button();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.label_Time = new System.Windows.Forms.Label();
            this.panel_TitleBar = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.panel_Desktop = new System.Windows.Forms.Panel();
            this.groupBox_Authorization = new System.Windows.Forms.GroupBox();
            this.button_SignIn = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.label_Authorization = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel_Menu.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            this.panel_TitleBar.SuspendLayout();
            this.panel_Desktop.SuspendLayout();
            this.groupBox_Authorization.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_Menu.Controls.Add(this.button_Logout);
            this.panel_Menu.Controls.Add(this.button_Statistics);
            this.panel_Menu.Controls.Add(this.button_Archive);
            this.panel_Menu.Controls.Add(this.button_AddingInfo);
            this.panel_Menu.Controls.Add(this.button_Basket);
            this.panel_Menu.Controls.Add(this.button_Products);
            this.panel_Menu.Controls.Add(this.panel_Logo);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(235, 761);
            this.panel_Menu.TabIndex = 0;
            // 
            // button_Logout
            // 
            this.button_Logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Logout.Enabled = false;
            this.button_Logout.FlatAppearance.BorderSize = 0;
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Logout.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_Logout.Image = ((System.Drawing.Image)(resources.GetObject("button_Logout.Image")));
            this.button_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Logout.Location = new System.Drawing.Point(0, 480);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button_Logout.Size = new System.Drawing.Size(235, 80);
            this.button_Logout.TabIndex = 6;
            this.button_Logout.Text = "      Logout";
            this.button_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Logout.UseVisualStyleBackColor = true;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // button_Statistics
            // 
            this.button_Statistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Statistics.Enabled = false;
            this.button_Statistics.FlatAppearance.BorderSize = 0;
            this.button_Statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Statistics.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_Statistics.Image = ((System.Drawing.Image)(resources.GetObject("button_Statistics.Image")));
            this.button_Statistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Statistics.Location = new System.Drawing.Point(0, 400);
            this.button_Statistics.Name = "button_Statistics";
            this.button_Statistics.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button_Statistics.Size = new System.Drawing.Size(235, 80);
            this.button_Statistics.TabIndex = 5;
            this.button_Statistics.Text = "      Statistics";
            this.button_Statistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Statistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Statistics.UseVisualStyleBackColor = true;
            this.button_Statistics.Click += new System.EventHandler(this.button_Statistics_Click);
            // 
            // button_Archive
            // 
            this.button_Archive.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Archive.Enabled = false;
            this.button_Archive.FlatAppearance.BorderSize = 0;
            this.button_Archive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Archive.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_Archive.Image = ((System.Drawing.Image)(resources.GetObject("button_Archive.Image")));
            this.button_Archive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Archive.Location = new System.Drawing.Point(0, 320);
            this.button_Archive.Name = "button_Archive";
            this.button_Archive.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button_Archive.Size = new System.Drawing.Size(235, 80);
            this.button_Archive.TabIndex = 4;
            this.button_Archive.Text = "      Archive";
            this.button_Archive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Archive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Archive.UseVisualStyleBackColor = true;
            this.button_Archive.Click += new System.EventHandler(this.button_Archive_Click);
            // 
            // button_AddingInfo
            // 
            this.button_AddingInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_AddingInfo.Enabled = false;
            this.button_AddingInfo.FlatAppearance.BorderSize = 0;
            this.button_AddingInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddingInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_AddingInfo.Image = ((System.Drawing.Image)(resources.GetObject("button_AddingInfo.Image")));
            this.button_AddingInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AddingInfo.Location = new System.Drawing.Point(0, 240);
            this.button_AddingInfo.Name = "button_AddingInfo";
            this.button_AddingInfo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button_AddingInfo.Size = new System.Drawing.Size(235, 80);
            this.button_AddingInfo.TabIndex = 3;
            this.button_AddingInfo.Text = "      Adding Info";
            this.button_AddingInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AddingInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_AddingInfo.UseVisualStyleBackColor = true;
            this.button_AddingInfo.Click += new System.EventHandler(this.button_AddingInfo_Click);
            // 
            // button_Basket
            // 
            this.button_Basket.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Basket.Enabled = false;
            this.button_Basket.FlatAppearance.BorderSize = 0;
            this.button_Basket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Basket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Basket.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_Basket.Image = ((System.Drawing.Image)(resources.GetObject("button_Basket.Image")));
            this.button_Basket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Basket.Location = new System.Drawing.Point(0, 160);
            this.button_Basket.Name = "button_Basket";
            this.button_Basket.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button_Basket.Size = new System.Drawing.Size(235, 80);
            this.button_Basket.TabIndex = 2;
            this.button_Basket.Text = "      Basket";
            this.button_Basket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Basket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Basket.UseVisualStyleBackColor = true;
            this.button_Basket.Click += new System.EventHandler(this.button_Basket_Click);
            // 
            // button_Products
            // 
            this.button_Products.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Products.Enabled = false;
            this.button_Products.FlatAppearance.BorderSize = 0;
            this.button_Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Products.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_Products.Image = ((System.Drawing.Image)(resources.GetObject("button_Products.Image")));
            this.button_Products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Products.Location = new System.Drawing.Point(0, 80);
            this.button_Products.Name = "button_Products";
            this.button_Products.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button_Products.Size = new System.Drawing.Size(235, 80);
            this.button_Products.TabIndex = 1;
            this.button_Products.Text = "      Products";
            this.button_Products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Products.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Products.UseVisualStyleBackColor = true;
            this.button_Products.Click += new System.EventHandler(this.button_Products_Click);
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel_Logo.Controls.Add(this.label_Time);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(235, 80);
            this.panel_Logo.TabIndex = 0;
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(96)))));
            this.label_Time.Location = new System.Drawing.Point(77, 25);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(71, 29);
            this.label_Time.TabIndex = 1;
            this.label_Time.Text = "00:00";
            // 
            // panel_TitleBar
            // 
            this.panel_TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel_TitleBar.Controls.Add(this.button_Close);
            this.panel_TitleBar.Controls.Add(this.label_Title);
            this.panel_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TitleBar.Location = new System.Drawing.Point(235, 0);
            this.panel_TitleBar.Name = "panel_TitleBar";
            this.panel_TitleBar.Size = new System.Drawing.Size(899, 80);
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
            this.button_Close.Location = new System.Drawing.Point(26, 22);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(40, 40);
            this.button_Close.TabIndex = 0;
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Visible = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(100, 28);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(84, 27);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "HOME";
            // 
            // panel_Desktop
            // 
            this.panel_Desktop.BackColor = System.Drawing.Color.White;
            this.panel_Desktop.Controls.Add(this.groupBox_Authorization);
            this.panel_Desktop.Controls.Add(this.progressBar);
            this.panel_Desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Desktop.Location = new System.Drawing.Point(235, 80);
            this.panel_Desktop.Name = "panel_Desktop";
            this.panel_Desktop.Size = new System.Drawing.Size(899, 681);
            this.panel_Desktop.TabIndex = 1;
            // 
            // groupBox_Authorization
            // 
            this.groupBox_Authorization.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_Authorization.Controls.Add(this.button_SignIn);
            this.groupBox_Authorization.Controls.Add(this.textBox_Password);
            this.groupBox_Authorization.Controls.Add(this.textBox_Login);
            this.groupBox_Authorization.Controls.Add(this.label_Authorization);
            this.groupBox_Authorization.Location = new System.Drawing.Point(229, 189);
            this.groupBox_Authorization.Name = "groupBox_Authorization";
            this.groupBox_Authorization.Size = new System.Drawing.Size(503, 275);
            this.groupBox_Authorization.TabIndex = 1;
            this.groupBox_Authorization.TabStop = false;
            // 
            // button_SignIn
            // 
            this.button_SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button_SignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SignIn.ForeColor = System.Drawing.Color.White;
            this.button_SignIn.Location = new System.Drawing.Point(146, 211);
            this.button_SignIn.Name = "button_SignIn";
            this.button_SignIn.Size = new System.Drawing.Size(194, 45);
            this.button_SignIn.TabIndex = 3;
            this.button_SignIn.Text = "Sign In";
            this.button_SignIn.UseVisualStyleBackColor = false;
            this.button_SignIn.Click += new System.EventHandler(this.button_SignIn_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.LightGray;
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Password.Location = new System.Drawing.Point(85, 146);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(323, 38);
            this.textBox_Password.TabIndex = 2;
            this.textBox_Password.Text = "Password";
            // 
            // textBox_Login
            // 
            this.textBox_Login.BackColor = System.Drawing.Color.LightGray;
            this.textBox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Login.Location = new System.Drawing.Point(85, 91);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(323, 38);
            this.textBox_Login.TabIndex = 1;
            this.textBox_Login.Text = "Login";
            // 
            // label_Authorization
            // 
            this.label_Authorization.AutoSize = true;
            this.label_Authorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Authorization.Location = new System.Drawing.Point(153, 27);
            this.label_Authorization.Name = "label_Authorization";
            this.label_Authorization.Size = new System.Drawing.Size(173, 31);
            this.label_Authorization.TabIndex = 0;
            this.label_Authorization.Text = "Authorization";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar.Location = new System.Drawing.Point(416, 328);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(40, 14);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 0;
            this.progressBar.Visible = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 761);
            this.Controls.Add(this.panel_Desktop);
            this.Controls.Add(this.panel_TitleBar);
            this.Controls.Add(this.panel_Menu);
            this.MinimumSize = new System.Drawing.Size(1150, 600);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.SizeChanged += new System.EventHandler(this.FormMainMenu_SizeChanged);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            this.panel_Logo.PerformLayout();
            this.panel_TitleBar.ResumeLayout(false);
            this.panel_TitleBar.PerformLayout();
            this.panel_Desktop.ResumeLayout(false);
            this.groupBox_Authorization.ResumeLayout(false);
            this.groupBox_Authorization.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Button button_Statistics;
        private System.Windows.Forms.Button button_Archive;
        public System.Windows.Forms.Button button_AddingInfo;
        private System.Windows.Forms.Button button_Basket;
        private System.Windows.Forms.Button button_Products;
        private System.Windows.Forms.Panel panel_TitleBar;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Panel panel_Desktop;
        private System.Windows.Forms.Button button_Close;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox_Authorization;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Label label_Authorization;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_SignIn;
        private System.Windows.Forms.Button button_Logout;
    }
}

