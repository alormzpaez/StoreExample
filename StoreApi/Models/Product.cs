using System.Text.Json.Serialization;

namespace StoreApi.Models
{
    public class Product
    {
        public Product()
        {
            Variants = new List<Variant>();
        }
        public int ProductID { get; set; }
        public string Name { get; set; }
		public string ThumbnailUrl { get; set; } // nullable
		public string Description { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
		public virtual ICollection<Variant>? Variants { get; set; }
    }
}
