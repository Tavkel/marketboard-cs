using marketboard.Application.Models.Chat;
using marketboard.Application.Responses.Identity;
using marketboard.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using marketboard.Application.Interfaces.Chat;

namespace marketboard.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}