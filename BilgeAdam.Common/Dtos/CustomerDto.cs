using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Common.Dtos
{
    public class CustomerDto
    {
        public string CustomerName { get; set; }
        public string? ContactName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
    }
}
