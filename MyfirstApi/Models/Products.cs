using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MyfirstApi.Models
{
	public class Product
    { 
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Sku { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public bool Isavailable { get; set; }
        [Required]
        public int CatogeryId { get; set; }
        [JsonIgnore]
        public virtual Catogery? Catogery { get; set; }
    }
}

 