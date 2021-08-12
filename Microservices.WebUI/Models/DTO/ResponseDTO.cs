namespace Microservices.WebUI.Models.DTO
{
    public class ResponseDTO
    {
        public ResponseDTO()
        {
            IsSuccess = true;
        }
        public bool IsSuccess { get; set; }
        public object Result { get; set; }
        public string Message { get; set; }
        public string ErrorMessage { get; set; }
    }
}