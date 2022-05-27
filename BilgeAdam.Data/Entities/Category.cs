using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Data.Entities
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        [Required]
        public int CategoryID { get; set; }
        [Required]
        [MaxLength(15)]
        public string CategoryName { get; set; }
     
        public string Description { get; set; }       
    }
}
