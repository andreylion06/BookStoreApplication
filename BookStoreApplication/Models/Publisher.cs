using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Publisher
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string OfficeAddress { get; set; }
        public string PhoneNumber { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
