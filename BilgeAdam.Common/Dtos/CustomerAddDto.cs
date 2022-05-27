using System.ComponentModel.DataAnnotations;
namespace BilgeAdam.Common.Dtos
{
    public class CustomerAddDto
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string CustomerId { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string CustomerName { get; set; }
        public string? ContactName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
    }
}

