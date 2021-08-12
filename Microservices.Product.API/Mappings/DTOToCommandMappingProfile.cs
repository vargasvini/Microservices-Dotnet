using AutoMapper;
using Microservices.Product.API.Models.DTO;

namespace Microservices.Product.API.Mappings
{
    public class DTOToCommandMappingProfile : Profile
    {
        public DTOToCommandMappingProfile()
        {
            CreateMap<ProductDTO, Models.Product>();
        }
    }
}