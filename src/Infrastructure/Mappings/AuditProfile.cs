using AutoMapper;
using marketboard.Infrastructure.Models.Audit;
using marketboard.Application.Responses.Audit;

namespace marketboard.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}