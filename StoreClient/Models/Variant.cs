using System.Text.Json.Serialization;

namespace StoreClient.Models
{
    public class Variant
    {
        public int VariantID { get; set; }
        public string Name { get; set; }
        public float RetailPrice { get; set; }
        public int Currency { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int ProductID { get; set; } // foreign key
        public Product? Product { get; set; }
    }
}
