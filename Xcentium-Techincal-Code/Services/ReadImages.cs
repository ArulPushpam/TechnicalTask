using Microsoft.Extensions.FileProviders;
using System.Collections.Generic;
using System.Linq;

namespace Xcentium_Techincal_Code.Services
{
    public class ReadImages
    {
        public List<string> GetImage(string imagePath)
        {
            var provider = new PhysicalFileProvider(imagePath);
            var contents = provider.GetDirectoryContents("");
            var objFiles = contents.OrderBy(m => m.LastModified);
            var ImageList = new List<string>();
            foreach (var item in objFiles.ToList())
            {
                ImageList.Add(item.Name);
            }
            return ImageList;
        }
    }
}
