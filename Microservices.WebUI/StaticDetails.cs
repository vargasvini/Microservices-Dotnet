namespace Microservices.WebUI
{
    public static class StaticDetails
    {
        public static string ProductAPIBase {get; set;}
        public enum APIType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}