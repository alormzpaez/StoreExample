using StoreClient.Models;
using StoreClient.Pages;
using System.Net.Http.Json;
using System.Text.Json;

namespace StoreClient.Services
{
    public class ProductService : IProductService
    {
        protected readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _options;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<List<Product>?> Index()
        {
            var response = await _httpClient.GetAsync("/api/v1/products");
			var content = await response.Content.ReadAsStringAsync();

			if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var stream = await response.Content.ReadAsStreamAsync();
            List<Product>? products = await JsonSerializer.DeserializeAsync<List<Product>>(stream, _options);

			return products;
		}

        public async Task<Product?> Show(int productId)
        {
            var response = await _httpClient.GetAsync($"/api/v1/products/{productId}");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var stream = await response.Content.ReadAsStreamAsync();
            Product? product = await JsonSerializer.DeserializeAsync<Product>(stream, _options);

            return product;
        }

        public async Task Update(int productId, Product product)
        {
            var response = await _httpClient.PutAsync($"/api/v1/products/{productId}", JsonContent.Create(product));
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
        }

        public async Task Store(Product product)
        {
            var response = await _httpClient.PostAsync("/api/v1/products", JsonContent.Create(product));
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
        }

        public async Task Destroy(int productId)
        {
            var response = await _httpClient.DeleteAsync($"/api/v1/products/{productId}");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
        }
    }

    public interface IProductService
    {
        Task<List<Product>> Index();
        Task<Product> Show(int productId);
        Task Store(Product product);
        Task Update(int productId, Product product);
        Task Destroy(int productId);
    }
}
