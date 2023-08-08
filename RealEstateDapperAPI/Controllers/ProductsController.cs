using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapperAPI.Repositories.CategoryRepository;
using RealEstateDapperAPI.Repositories.ProductRepository;

namespace RealEstateDapperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var values = await _productRepository.GetAllProductAsync();
            return Ok(values);
        }
        [HttpGet("GetAllProductsWithCategory")]
        public async Task<IActionResult> GetAllProductsWithCategory()
        {
            var values = await _productRepository.GetResultProductWithCategoryAsync();
            return Ok(values);
        }
    }
}
