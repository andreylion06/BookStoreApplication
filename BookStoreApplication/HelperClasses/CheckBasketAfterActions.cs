using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApplication.HelperClasses
{
    public class CheckBasketAfterActions
    {
        public static void Check(int bookIndex, bool editing = false)
        {
            using (BookStoreDB db = new BookStoreDB())
            {
                var basket = db.Basket.SingleOrDefault(x => x.BookID == bookIndex);
                if (basket != null)
                {
                    if (editing)
                    {
                        var book = db.Book.SingleOrDefault(x => x.ID == bookIndex);
                        if (basket.Count > book.QuantityInStock && book.QuantityInStock != 0)
                        {
                            basket.Count = book.QuantityInStock;
                            db.Entry(basket).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            MessageBox.Show("The book you changed was in the basket, the quantity has been changed", 
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        db.Basket.Remove(basket);
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
