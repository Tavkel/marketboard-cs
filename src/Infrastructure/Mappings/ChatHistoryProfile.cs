using AutoMapper;
using marketboard.Application.Interfaces.Chat;
using marketboard.Application.Models.Chat;
using marketboard.Infrastructure.Models.Identity;

namespace marketboard.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}