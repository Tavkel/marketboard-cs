using marketboard.Application.Interfaces.Common;

namespace marketboard.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}