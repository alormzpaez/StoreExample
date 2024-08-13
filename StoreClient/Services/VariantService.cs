using StoreClient.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace StoreClient.Services
{
	public class VariantService : IVariantService
	{
		protected readonly HttpClient _httpClient;
		private readonly JsonSerializerOptions _options;

		public VariantService(HttpClient httpClient)
		{
			_httpClient = httpClient;
			_options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
		}

		public async Task<Variant?> Show(int variantId)
		{
			var response = await _httpClient.GetAsync($"/api/v1/variants/{variantId}");
			var content = await response.Content.ReadAsStringAsync();

			if (!response.IsSuccessStatusCode)
			{
				throw new ApplicationException(content);
			}

			var stream = await response.Content.ReadAsStreamAsync();

			Variant? variant = await JsonSerializer.DeserializeAsync<Variant>(stream, _options);

			return variant;
		}

	}

	public interface IVariantService
	{
		Task<Variant?> Show(int variantId);
	}
}

