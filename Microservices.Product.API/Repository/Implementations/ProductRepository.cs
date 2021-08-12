using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservices.Product.API.Context;
using Microservices.Product.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Microservices.Product.API.Repository.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly MainContext _context;
        public ProductRepository(MainContext context)
        {
            _context = context;
        }

        public Task<Models.Product> CreateUpdateProductAsync(Models.Product product)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteProduct(int productId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Models.Product> GetProductByIdAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Models.Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}