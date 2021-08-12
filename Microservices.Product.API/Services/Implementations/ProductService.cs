using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microservices.Product.API.Models.DTO;
using Microservices.Product.API.Repository.Interfaces;
using Microservices.Product.API.Services.Interfaces;

namespace Microservices.Product.API.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetProductsAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }
    }
}