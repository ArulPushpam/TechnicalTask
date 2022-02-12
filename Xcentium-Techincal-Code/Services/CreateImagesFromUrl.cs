using Microsoft.Extensions.Logging;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;

namespace Xcentium_Techincal_Code.Services
{
    public class CreateImagesFromUrl
    {
        protected readonly ILogger<CreateImagesFromUrl> _logger;

        public CreateImagesFromUrl(ILogger<CreateImagesFromUrl> logger)
        {
            this._logger = logger;
        }
        public void CreateImage(string websiteUrl, string rootPath)
        {
            try
            {
                var imageName = RemoveQueryString(websiteUrl);

                string encodedUrl = Convert.ToBase64String(Encoding.Default.GetBytes(websiteUrl));

                using (var client = new WebClient())
                {
                    byte[] dataBytes = client.DownloadData(new Uri(websiteUrl));
                    string encodedFileAsBase64 = Convert.ToBase64String(dataBytes);

                    Image image;
                    using (MemoryStream ms = new MemoryStream(dataBytes))
                    {
                        image = new Bitmap(Image.FromStream(ms));
                    }

                    image.Save(rootPath + "/" + imageName);
                }
            }
            catch (Exception e)
            {
                _logger.LogInformation(e.Message);
            }
        }

        public string RemoveQueryString(string imageUrl)
        {
            string[] separateURL = imageUrl.Split('?');

            var newQuerystring = separateURL[0];

            if (string.IsNullOrEmpty(newQuerystring))
                return null;

            return Path.GetFileName(newQuerystring);
        }

    
    }
}
