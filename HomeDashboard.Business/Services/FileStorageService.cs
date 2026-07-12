//using HomeDashboard.Business.Interfaces;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Hosting;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace HomeDashboard.Business.Services
//{
//    public class FileStorageService : IFileStorageService
//    {
//        private readonly IWebHostEnvironment _environment;


//        public FileStorageService(
//            IWebHostEnvironment environment)
//        {
//            _environment = environment;
//        }


//        public async Task<string> SaveFileAsync(
//            IFormFile file,
//            string folder)
//        {
//            var storagePath = Path.Combine(
//                _environment.ContentRootPath,
//                "Storage",
//                folder);


//            Directory.CreateDirectory(storagePath);


//            var extension =
//                Path.GetExtension(file.FileName);


//            var fileName =
//                $"{Guid.NewGuid()}{extension}";


//            var fullPath =
//                Path.Combine(storagePath, fileName);


//            await using var stream =
//                new FileStream(
//                    fullPath,
//                    FileMode.Create);


//            await file.CopyToAsync(stream);


//            return Path.Combine(folder, fileName);
//        }


//        public Task DeleteFileAsync(string path)
//        {
//            var fullPath =
//                Path.Combine(
//                    _environment.ContentRootPath,
//                    "Storage",
//                    path);


//            if (File.Exists(fullPath))
//                File.Delete(fullPath);


//            return Task.CompletedTask;
//        }
//    }
