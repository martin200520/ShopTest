using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Abstract;
using Shop.Data.Entities;

namespace Shop.Web.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _productRepository.GetAllProductsAsync());
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _productRepository.GetProductAsync(id));
        }

        [Route("add")]
        [HttpPost]
        public async Task<IActionResult> Add(Product product)
        {
            await _productRepository.AddProductAsync(product);
            return Ok();
        }

        [Route("update")]
        [HttpPut]
        public async Task<IActionResult> Update(Product product)
        {
            await _productRepository.UpdateProductAsync(product);
            return Ok();
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _productRepository.DeleteProductAsync(id);
            return Ok();
        }
    }
}
