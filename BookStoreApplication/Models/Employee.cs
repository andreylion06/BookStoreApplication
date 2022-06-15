using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

    }
}
