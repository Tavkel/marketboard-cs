﻿using marketboard.Application.Features.Documents.Commands.AddEdit;
using marketboard.Application.Features.Documents.Queries.GetAll;
using marketboard.Application.Requests.Documents;
using marketboard.Shared.Wrapper;
using System.Threading.Tasks;
using marketboard.Application.Features.Documents.Queries.GetById;

namespace marketboard.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}