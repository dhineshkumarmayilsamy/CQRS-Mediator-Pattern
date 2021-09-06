using API.DataStore.Domain;
using API.Dtos;
using AutoMapper;

namespace API.Helpers
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
        }
    }
}
