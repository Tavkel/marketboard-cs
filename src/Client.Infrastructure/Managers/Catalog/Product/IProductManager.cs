using marketboard.Application.Features.Products.Commands.AddEdit;
using marketboard.Application.Features.Products.Queries.GetAllPaged;
using marketboard.Application.Requests.Catalog;
using marketboard.Shared.Wrapper;
using System.Threading.Tasks;

namespace marketboard.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}