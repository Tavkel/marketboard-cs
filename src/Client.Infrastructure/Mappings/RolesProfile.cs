using AutoMapper;
using marketboard.Application.Requests.Identity;
using marketboard.Application.Responses.Identity;

namespace marketboard.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}