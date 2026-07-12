using Microsoft.AspNetCore.Http;

namespace HomeDashboard.Business.Interfaces
{
    public interface IFileStorageService
    {
        Task<string> SaveFileAsync(
        IFormFile file,
        string folder);

        Task DeleteFileAsync(
            string path);
    }
}