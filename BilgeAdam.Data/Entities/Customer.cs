using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Data.Entities
{
   
       [Table("Customers")]
        public class Customer
        {
            [Key]
            public string CustomerID { get; set; }
            public string CompanyName { get; set; }
            public string? ContactName { get; set; }
            public string? Phone { get; set; }
            public string? Address { get; set; }

        }
    
}
