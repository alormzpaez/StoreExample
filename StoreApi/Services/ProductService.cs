using Microsoft.EntityFrameworkCore;
using StoreApi.Controllers;
using StoreApi.DBContext;
using StoreApi.Models;

namespace StoreApi.Services
{
    public class ProductService : IProductService
    {
        private StoreContext _dbContext;
        private readonly ILogger<ProductService> _logger;

        public ProductService(StoreContext dbContext, ILogger<ProductService> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public IEnumerable<Product> Index()
        {
            return _dbContext.Products.Include(q => q.Variants);
        }

        public Product? Show(int id)
        {
            var currentProduct = _dbContext.Products.Include(q => q.Variants).FirstOrDefault(q => q.ProductID == id);

            return currentProduct;
        }

        public async Task Store(Product product)
        {
            _dbContext.Products.Add(new Product()
            {
                Name = product.Name,
                ThumbnailUrl = product.ThumbnailUrl,
                Description = product.Description,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            });
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(int id, Product product)
        {
            var currentProduct = _dbContext.Products.Find(id);

            if (currentProduct != null)
            {
                _logger.LogInformation("Se encontró el producto");

                currentProduct.Description = product.Description;
                currentProduct.Name = product.Name;
                currentProduct.UpdatedAt = DateTime.Now;
                currentProduct.ThumbnailUrl = product.ThumbnailUrl;

                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task Destroy(int id)
        {
            var currentProduct = _dbContext.Products.Find(id);

            if (currentProduct != null)
            {
                _dbContext.Remove(currentProduct);

                await _dbContext.SaveChangesAsync();
            }
        }
    }

    public interface IProductService
    {
        IEnumerable<Product> Index();
        Product? Show(int id);
        Task Store(Product product);
        Task Update(int id, Product product);
        Task Destroy(int id);
    }
}
