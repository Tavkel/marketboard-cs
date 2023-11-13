using marketboard.Application.Requests;

namespace marketboard.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}