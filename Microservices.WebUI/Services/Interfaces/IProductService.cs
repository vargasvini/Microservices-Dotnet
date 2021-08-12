using System.Threading.Tasks;

namespace Microservices.WebUI.Services.Interfaces
{
    public interface IProductService : IBaseService
    {
        Task<T> GetAllProductsAsync<T>();
    }
}