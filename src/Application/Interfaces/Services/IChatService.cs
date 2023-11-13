using marketboard.Application.Responses.Identity;
using marketboard.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using marketboard.Application.Interfaces.Chat;
using marketboard.Application.Models.Chat;

namespace marketboard.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}