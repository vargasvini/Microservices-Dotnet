using System.Collections.Generic;
using System.Threading.Tasks;
using Microservices.Product.API.Models.DTO;

namespace Microservices.Product.API.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetAllProductsAsync();
    }
}