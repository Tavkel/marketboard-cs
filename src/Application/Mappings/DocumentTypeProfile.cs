using AutoMapper;
using marketboard.Application.Features.DocumentTypes.Commands.AddEdit;
using marketboard.Application.Features.DocumentTypes.Queries.GetAll;
using marketboard.Application.Features.DocumentTypes.Queries.GetById;
using marketboard.Domain.Entities.Misc;

namespace marketboard.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}