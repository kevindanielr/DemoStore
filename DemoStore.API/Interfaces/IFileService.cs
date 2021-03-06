﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DemoStore.API.Interfaces
{
    public interface IFileService
    {
        Task<string> SaveFileAsync(IFormFile formFile, HttpRequest request);

        void DeleteFile(string imageUrl);

    }
}
