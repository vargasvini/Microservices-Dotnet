using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microservices.WebUI.Models;
using Microservices.WebUI.Models.DTO;
using Microservices.WebUI.Services.Interfaces;
using Newtonsoft.Json;

namespace Microservices.WebUI.Services.Implementations
{
    public class BaseService : IBaseService
    {
        public ResponseDTO responseModel { get; set; }
        public IHttpClientFactory httpClient { get; set; }

        public BaseService(IHttpClientFactory httpclient)
        {
            this.httpClient = httpclient;
            responseModel = new ResponseDTO();
        }
        public async Task<T> SendAsync<T>(ApiRequest apiRequest)
        {
            try
            {
                var client = httpClient.CreateClient("WebUI");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(apiRequest.Url);
                client.DefaultRequestHeaders.Clear();
                if(apiRequest.Data != null)
                {
                    message.Content = new StringContent(
                        JsonConvert.SerializeObject(apiRequest.Data), 
                        Encoding.UTF8, 
                        "application/json"
                    );
                }
               HttpResponseMessage apiResponse = null;
                switch(apiRequest.ApiType)
                {
                    case StaticDetails.APIType.POST:
                        message.Method = HttpMethod.Post;
                        break;
                    case StaticDetails.APIType.PUT:
                        message.Method = HttpMethod.Put;
                        break;
                    case StaticDetails.APIType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;
                    default:
                        message.Method = HttpMethod.Get;
                        break;
                }

                apiResponse = await client.SendAsync(message);

                var apiContent = await apiResponse.Content.ReadAsStringAsync();
                var apiResponseDTO = JsonConvert.DeserializeObject<T>(apiContent);

                return apiResponseDTO;
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}