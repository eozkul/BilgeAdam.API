using System.ComponentModel.DataAnnotations;

namespace BilgeAdam.Common.Dtos
{
    public class CategoryAddDto
    {
        [Required(ErrorMessage ="Bu alan boş bırakılamaz")]
        [MaxLength(15)]
        public string CategoryName { get; set; }

        public string Description { get; set; }
    }
}
