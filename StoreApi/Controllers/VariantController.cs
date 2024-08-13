using Microsoft.AspNetCore.Mvc;
using StoreApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StoreApi.Controllers
{
    [Route("api/v1/variants")]
    [ApiController]
    public class VariantController : ControllerBase
    {
        protected readonly IVariantService _variantService;

        public VariantController(IVariantService variantService)
        {
            _variantService = variantService;
        }

        // GET api/<VariantController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_variantService.Show(id));
        }
    }
}
