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
            button_Close.Visible = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            progressBar.Visible = false;

            LoadData();
            timer.Start();
            SetTime(true);
            random = new Random();
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
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    button_Close.Visible = true;
                }
            }
        }
        public void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
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


        private void button_Close_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            label_Title.Text = "HOME";
            panel_TitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
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
                button_Products.Enabled = true;
                button_Basket.Enabled = true;
                button_AddingInfo.Enabled = true;
                button_Archive.Enabled = true;
                button_Settings.Enabled = true;
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(label_Time.Text.Contains(":")) SetTime(false);
            else SetTime(true);
        }

        private void SetTime(bool dots)
        {
            string time = dots ? "{0:00}:{1:00}" : "{0:00} {1:00}";
            label_Time.Text = string.Format(time, DateTime.Now.Hour, DateTime.Now.Minute); ;
        }
    }
}
