using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Server.Helpers
{
    public class InAppStorageService : IFileStorageService
    {
        public Task DeleteFile(string fileRoute, string containerName)
        {
            throw new NotImplementedException();
        }

        public Task<string> EditFile(byte[] content, string extension, string containerName, string fileRoute)
        {
            throw new NotImplementedException();
        }

        public Task<string> SaveFile(byte[] content, string extension, string containerName)
        {
            throw new NotImplementedException();
        }
    }
}
