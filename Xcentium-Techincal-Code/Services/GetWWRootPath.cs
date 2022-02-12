using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Xcentium_Techincal_Code.Services
{
    public class GetWWRootPath
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public GetWWRootPath(IWebHostEnvironment webHostEnvironment)
        {
            this._webHostEnvironment = webHostEnvironment;
        }
        public string GetPath()
        {
            var rootPath = System.IO.Path.Combine(_webHostEnvironment.WebRootPath, "CarouselImages");

            if (!System.IO.Directory.Exists(rootPath))
                Directory.CreateDirectory(rootPath);

            return rootPath; 
        }
    }
}
