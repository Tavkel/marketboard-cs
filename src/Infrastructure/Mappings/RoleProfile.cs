using AutoMapper;
using marketboard.Infrastructure.Models.Identity;
using marketboard.Application.Responses.Identity;

namespace marketboard.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, BlazorHeroRole>().ReverseMap();
        }
    }
}