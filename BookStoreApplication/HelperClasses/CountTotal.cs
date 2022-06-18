using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.HelperClasses
{
    public class CountTotal
    {
        public static double Total()
        {
            double total = 0;
            using (BookStoreDB db = new BookStoreDB())
            {
                var basket = db.Basket.ToList();
                foreach (var item in basket)
                {
                    double priceOfItem = db.Book.FirstOrDefault(x => x.ID == item.BookID).Price;
                    total += (priceOfItem * item.Count);
                }
            }
            return total;
        }
    }
}
