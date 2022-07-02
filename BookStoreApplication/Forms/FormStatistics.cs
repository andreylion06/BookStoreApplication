using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApplication.Forms
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            LoadCharts();
        }

        private void LoadCharts()
        {
            DateTime oneWeekAgo = DateTime.Now.AddDays(-30);
            using (BookStoreDB db = new BookStoreDB())
            {
                var sales = db.Sales.Where(x => x.DateOfSale >= oneWeekAgo).ToList();
                if (sales.Count == 0) return;

                double totalRevenue = 0;
                int totalCount = 0;
                DateTime date = sales[0].DateOfSale.Date;
                foreach (var sale in sales)
                {
                    if (date != sale.DateOfSale.Date)
                    {
                        chart_Revenue.Series["Revenue"].Points.AddXY(date.ToString("dd.MM"), totalRevenue);
                        chart_Count.Series["Count"].Points.AddXY(date.ToString("dd.MM"), totalCount);
                        
                        date = sale.DateOfSale.Date;
                        totalRevenue = 0;
                        totalCount = 0;
                    }
                    var book = db.Book.SingleOrDefault(x => x.ID == sale.BookID);
                    totalRevenue += book.Price * sale.Count;
                    totalCount++;
                    
                }
                chart_Revenue.Series["Revenue"].Color = ThemeColor.PrimaryColor;
                chart_Count.Series["Count"].Color = ThemeColor.PrimaryColor;
            }
        }
    }
}
