using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data
{
    public class Address
    {
        public Address()
        {

        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string AddressDetails { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
