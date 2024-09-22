using NZWalk.API.Models.Domain;

namespace NZWalk.API.Repositories
{
    public interface IImageUploadRepository
    {
        Task<Image> Upload(Image image);
    }
}
