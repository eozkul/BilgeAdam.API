using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BilgeAdam.Common.Dtos
{
    public class CategoryListDto
    {
        [JsonPropertyName("categoryId")]
        public int CategoryId { get; set; }
        [JsonPropertyName("categoryName")]
        public string CategoryName { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
