using AutoMapper;
using marketboard.Application.Features.Documents.Commands.AddEdit;
using marketboard.Application.Features.Documents.Queries.GetById;
using marketboard.Domain.Entities.Misc;

namespace marketboard.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}