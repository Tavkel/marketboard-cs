using System.Collections.Generic;
using System.Threading.Tasks;
using marketboard.Application.Interfaces.Common;
using marketboard.Application.Requests.Identity;
using marketboard.Application.Responses.Identity;
using marketboard.Shared.Wrapper;

namespace marketboard.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}