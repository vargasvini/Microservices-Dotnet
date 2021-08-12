using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microservices.WebUI.Models.DTO;
using Microservices.WebUI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Microservices.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> ProductIndex()
        {
            var productList = new List<ProductDTO>();
            var response = await _productService.GetAllProductsAsync<ResponseDTO>();
            if(response != null && response.IsSuccess){
                productList = JsonConvert.DeserializeObject<List<ProductDTO>>(Convert.ToString(response.Result));
            }
            return View(productList);
        }
    }
}