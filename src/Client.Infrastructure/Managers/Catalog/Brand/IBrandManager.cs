using marketboard.Application.Features.Brands.Queries.GetAll;
using marketboard.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using marketboard.Application.Features.Brands.Commands.AddEdit;

namespace marketboard.Client.Infrastructure.Managers.Catalog.Brand
{
    public interface IBrandManager : IManager
    {
        Task<IResult<List<GetAllBrandsResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditBrandCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}