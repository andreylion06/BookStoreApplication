using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Author
    {
        [Key]
        public int ID { get; set; }
        public string FullName { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
        public override string ToString()
        {
            return $"{FullName}";
        }
    }
}
