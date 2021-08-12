using static Microservices.WebUI.StaticDetails;

namespace Microservices.WebUI.Models
{
    public class ApiRequest
    {
        public ApiRequest()
        {
            ApiType = APIType.GET;
        }
        public APIType ApiType { get; set; }
        public string Url {get; set;}
        public object Data { get; set; }
        public string Token { get; set; }
    }
}