using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ContosoCrafts.WebSite.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(70)]
        public string Maker { get; set; }
        [JsonPropertyName("img")]
        [MaxLength(200)]
        public string Image { get; set; }
        [MaxLength(200)]
        public string Url { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(1200)]
        public string Desciption { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
