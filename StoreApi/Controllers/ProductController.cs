using Microsoft.AspNetCore.Mvc;
using StoreApi.Models;
using StoreApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StoreApi.Controllers
{
    [Route("api/v1/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        protected readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.Index());
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_productService.Show(id));
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] Product product)
        {
            await _productService.Store(product);

            return Created();
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] Product product)
        {
            await _productService.Update(id, product);

            return Ok();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _productService.Destroy(id);

            return NoContent();
        }
    }
}
