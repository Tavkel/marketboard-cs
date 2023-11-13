using AutoMapper;
using marketboard.Application.Features.Products.Commands.AddEdit;
using marketboard.Domain.Entities.Catalog;

namespace marketboard.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}