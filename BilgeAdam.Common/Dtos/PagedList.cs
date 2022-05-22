using System.Text.Json.Serialization;

namespace BilgeAdam.Common.Dtos
{
    public class PagedList<T> where T : class
    {
        [JsonPropertyName("data")]
        public T Data { get; set; }

        [JsonPropertyName("totalCount")]
        public int TotalCount { get; set; }
    }
}