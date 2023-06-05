using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data
{
    public class Employee
    {
        public Employee() { 
        
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime Hired { get; set; }

        [NotMapped]
        public int TotalSpecdings { get; set; }

        public List<Address> Addresses { get; set; }
    }
}
