using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Encyc.Models
{
    public class ApiResponse
    {
        [JsonPropertyName("lastBuildDate")]
        public string LastBuildDate { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("start")]
        public int Start { get; set; }

        [JsonPropertyName("display")]
        public int Display { get; set; }

        [JsonPropertyName("items")]
        public List<ApiItem> Items { get; set; }
    }
}
