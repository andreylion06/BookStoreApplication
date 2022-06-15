using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Sales
    {
        [Key]
        public int ID { get; set; }
        public string NameOfBook { get; set; }
        public DateTime DateOfSale { get; set; }
        public double Price { get; set; }
    }
}
