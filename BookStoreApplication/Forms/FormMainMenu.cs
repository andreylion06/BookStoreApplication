using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using Models;

namespace BookStoreApplication
{
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public FormMainMenu()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.ActiveControl = label_Authorization;
            SetChildFormDesign.LoadTheme(button_SignIn);
            timer.Start();
            SetTime(true);
            random = new Random();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            textBox_Login.GotFocus += Focus;
            textBox_Login.LostFocus += LostFocus;

            textBox_Password.GotFocus += Focus;
            textBox_Password.LostFocus += LostFocus;
        }

        public void Focus(object sender, EventArgs e)
        {
            TextBox textBox = (sender as TextBox);
            if (textBox.Text == "Login" || textBox.Text == "Password")
            {
                textBox.Text = "";
                textBox.BackColor = Color.White;
            }
        }

        public void LostFocus(object sender, EventArgs e)
        {
            TextBox textBox = (sender as TextBox);
            if (textBox.Text.Trim().Length == 0)
            {
                if (textBox.Name == textBox_Login.Name)
                {
                    textBox.Text = "Login";
                }
                else if (textBox.Name == textBox_Password.Name)
                {
                    textBox.Text = "Password";
                }
                textBox.BackColor = Color.LightGray;
            }
        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            if (textBox_Login.Text.Length == 0)
            {
                MessageBox.Show("Login field is empty", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox_Password.Text.Length == 0)
            {
                MessageBox.Show("Password field is empty", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (BookStoreDB db = new BookStoreDB())
            {
                var user = db.SignIn.SingleOrDefault(x => x.Login == textBox_Login.Text);
                if (user != null)
                {
                    if (user.Password == EncryptPassword(textBox_Password.Text))
                    {
                        ClearFields.Clear(groupBox_Authorization);
                        LostFocus(textBox_Login, null);
                        LostFocus(textBox_Password, null);
                        groupBox_Authorization.Visible = false;
                        this.Load -= FormMainMenu_Load;
                        LoadData();
                        return;
                    }
                }
                MessageBox.Show("Incorrect username or password.", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static string EncryptPassword(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToBase64String(hashBytes);
            }
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
                index = random.Next(ThemeColor.ColorList.Count);
            tempIndex = index;
            string color = ThemeColor.ColorList[tempIndex];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    panel_TitleBar.BackColor = color;
                    panel_Logo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    button_Close.Visible = true;
                }
            }
        }
        public void DisableButton()
        {
            foreach (Control previousBtn in panel_Menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender, int index = -1)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_Desktop.Controls.Add(childForm);
            this.panel_Desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_Products_Click(object sender, EventArgs e)
        {
            label_Title.Text = "All Products";
            OpenChildForm(new Forms.FormProducts(), sender);
        }

        private void button_Basket_Click(object sender, EventArgs e)
        {
            label_Title.Text = "Basket";
            OpenChildForm(new Forms.FormBasket(), sender);
        }

        private void button_AddingInfo_Click(object sender, EventArgs e)
        {
            label_Title.Text = "Adding or editting info";
            OpenChildForm(new Forms.FormAdding(), sender);
        }

        private void button_Archive_Click(object sender, EventArgs e)
        {
            label_Title.Text = "Archive";
            OpenChildForm(new Forms.FormArchive(), sender);
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                groupBox_Authorization.Visible = true;
                this.ActiveControl = label_Authorization;
                EnabledMenuButtons(false);
                CloseChildForm();
            }
                
        }


        private void button_Close_Click(object sender, EventArgs e)
        {
            CloseChildForm();
        }

        private void CloseChildForm()
        {
            if (activeForm != null) activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            label_Title.Text = "HOME";
            panel_TitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panel_Logo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            button_Close.Visible = false;
        }

        public void LoadData()
        {
            using (BookStoreDB db = new BookStoreDB())
            {
                db.Book
                .Include(authors => authors.Author)
                .Include(publishers => publishers.Publisher)
                .Include(genres => genres.Genre)
                .Load();
            }
            backgroundWorker.RunWorkerAsync();
            progressBar.Show();
        }

        public void GoToFormProducts()
        {
            OpenChildForm(new Forms.FormProducts(), button_Products);
        }

        public void GoToFormAddingFromContext(int index = -1)
        {
            Forms.FormAdding formAdding = new Forms.FormAdding();
            label_Title.Text = "Adding or editting info";
            if (index != -1)
            {
                formAdding.IdEditBook = index;
            }
            OpenChildForm(formAdding, button_AddingInfo);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                Thread.Sleep(10);
                backgroundWorker.WorkerReportsProgress = true;
                backgroundWorker.ReportProgress(i);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            progressBar.Refresh();
            if (e.ProgressPercentage > 95)
            {
                progressBar.Visible = false;
                EnabledMenuButtons(true);
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (label_Time.Text.Contains(":")) SetTime(false);
            else SetTime(true);
        }

        private void SetTime(bool dots)
        {
            string time = dots ? "{0:00}:{1:00}" : "{0:00} {1:00}";
            label_Time.Text = string.Format(time, DateTime.Now.Hour, DateTime.Now.Minute); ;
        }

        private void FormMainMenu_SizeChanged(object sender, EventArgs e)
        {
            groupBox_Authorization.Left = (panel_Desktop.Width - groupBox_Authorization.Width) / 2;
            groupBox_Authorization.Top = (panel_Desktop.Height - groupBox_Authorization.Height) / 2;
        }

        private void EnabledMenuButtons(bool enabled)
        {
            foreach (Control cntrls in panel_Menu.Controls)
            {
                if (cntrls.GetType() == typeof(Button))
                {
                    Button btn = (Button)cntrls;
                    btn.Enabled = enabled;

                }
            }
        }
    }
}
