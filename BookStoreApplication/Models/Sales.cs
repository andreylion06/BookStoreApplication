using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Sales
    {
        [Key]
        public int ID { get; set; }
        public int BookID { get; set; }
        [ForeignKey("BookID")]
        public Book Book { get; set; }
        public DateTime DateOfSale { get; set; }
        public int Count { get; set; }
    }
}
