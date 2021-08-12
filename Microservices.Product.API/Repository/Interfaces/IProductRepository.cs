using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microservices.Product.API.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Models.Product>> GetProductsAsync();
        Task<Models.Product> GetProductByIdAsync();
        Task<Models.Product> CreateUpdateProductAsync(Models.Product product);
        Task<bool> DeleteProduct(int productId);
    }
}