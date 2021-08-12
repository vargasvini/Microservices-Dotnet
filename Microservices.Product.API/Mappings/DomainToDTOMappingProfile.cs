using AutoMapper;
using Microservices.Product.API.Models.DTO;

namespace Microservices.Product.API.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Models.Product, ProductDTO>().ReverseMap();
        }
    }
}