using marketboard.Application.Requests.Mail;
using System.Threading.Tasks;

namespace marketboard.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}