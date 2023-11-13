using AutoMapper;
using marketboard.Application.Features.Brands.Commands.AddEdit;
using marketboard.Application.Features.Brands.Queries.GetAll;
using marketboard.Application.Features.Brands.Queries.GetById;
using marketboard.Domain.Entities.Catalog;

namespace marketboard.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}