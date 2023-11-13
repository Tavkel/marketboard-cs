using marketboard.Application.Interfaces.Common;
using marketboard.Application.Requests.Identity;
using marketboard.Application.Responses.Identity;
using marketboard.Shared.Wrapper;
using System.Threading.Tasks;

namespace marketboard.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}