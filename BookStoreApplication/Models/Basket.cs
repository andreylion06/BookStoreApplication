using Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainForm.Models
{
    public class Basket
    {
        [Key]
        public int ID { get; set; }
        public int Count { get; set; }
        public int BookID { get; set; }
        [ForeignKey("BookID")]
        public Book Book { get; set; }
    }
}
