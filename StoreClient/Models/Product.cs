namespace StoreClient.Models
{
    public class Product
    {
        public Product()
        {
            if (Variants?.Count == 0)
            {
                Variants = new List<Variant>();
            }
        }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ThumbnailUrl { get; set; } // nullable
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<Variant>? Variants { get; set; }

        public Variant? LowestVariant
        {
            get
            {
                return Variants?.OrderBy(v => v.RetailPrice).FirstOrDefault();
            }
        }
    }
}
