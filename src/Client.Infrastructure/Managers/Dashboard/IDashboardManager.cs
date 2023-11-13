using marketboard.Shared.Wrapper;
using System.Threading.Tasks;
using marketboard.Application.Features.Dashboards.Queries.GetData;

namespace marketboard.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}