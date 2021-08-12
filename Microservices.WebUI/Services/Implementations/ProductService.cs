using System.Net.Http;
using System.Threading.Tasks;
using Microservices.WebUI.Services.Interfaces;

namespace Microservices.WebUI.Services.Implementations
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductService(IHttpClientFactory httpclient) : base(httpclient)
        {
            _httpClientFactory = httpclient;
        }

        public async Task<T> GetAllProductsAsync<T>()
        {
            return await this.SendAsync<T>(new Models.ApiRequest(){
                ApiType = StaticDetails.APIType.GET,
                Url = StaticDetails.ProductAPIBase + "/api/product",
                Token = ""
            });
        }
    }
}