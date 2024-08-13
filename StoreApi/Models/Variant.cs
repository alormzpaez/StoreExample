using System.Text.Json.Serialization;

namespace StoreApi.Models
{
    public class Variant
    {
        public int VariantID { get; set; }
        public string Name { get; set; }
        public float RetailPrice { get; set; }
        public Currency Currency { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int ProductID { get; set; } // foreign key
        [JsonIgnore]
        public virtual Product? Product { get; set; }
    }

    public enum Currency
    {
        MXN,
        USD
    }
}
