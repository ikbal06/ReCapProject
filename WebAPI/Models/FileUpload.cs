using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.images
{
    public class FileUpload
    {
        public IFormFile files { get; set; }
    }
}
