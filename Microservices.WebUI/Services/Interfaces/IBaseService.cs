using System;
using System.Threading.Tasks;
using Microservices.WebUI.Models;
using Microservices.WebUI.Models.DTO;

namespace Microservices.WebUI.Services.Interfaces
{
    public interface IBaseService : IDisposable
    {
        ResponseDTO responseModel {get; set;}
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}