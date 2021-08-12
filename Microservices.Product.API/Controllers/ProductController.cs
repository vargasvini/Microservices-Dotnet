using System.Collections.Generic;
using System.Threading.Tasks;
using Microservices.Product.API.Models.DTO;
using Microservices.Product.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.Product.API.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        protected ResponseDTO _response;
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _response = new ResponseDTO();
            _productService = productService;
        }

        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                _response.Result = await _productService.GetAllProductsAsync();
                return StatusCode(200, _response);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}