using Microsoft.Extensions.Logging;
using System;
using System.IO;
using Xcentium_Techincal_Code.Models;
using Xcentium_Techincal_Code.Services;

namespace Xcentium_Techincal_Code.Repositories
{
    public class SaveImageRepository : ISaveImageRepository
    {
        protected readonly GetWordCount _getWordCount;
        protected readonly ReadImages _getImages;
        protected readonly GetImageFromUrl _getImageUrl;
        protected CreateImagesFromUrl _createImagesFromUrl;
        private readonly ILogger<SaveImageRepository> _logger;
        protected readonly GetWWRootPath _getWWRootPath;
        public SaveImageRepository(GetWordCount getWordCount, ReadImages getImages, GetImageFromUrl getImageUrl, CreateImagesFromUrl createImagesFromUrl, ILogger<SaveImageRepository> logger, GetWWRootPath getWWRoot)
        {
            _getWordCount = getWordCount;
            _getImages = getImages;
            _getImageUrl = getImageUrl;
            _createImagesFromUrl = createImagesFromUrl;
            _logger = logger;
            _getWWRootPath = getWWRoot;
        }
        public FromModel Get()
        {
            throw new NotImplementedException();
        }

        public bool stroreImages(string websiteurl)
        {
            try
            {
                var ImageList = _getImageUrl.ImageUrl(websiteurl);
                var rootPath = _getWWRootPath.GetPath();
                if (ImageList == null)
                    return true;
                DeleteExistingFile(rootPath);
                ImageList.ForEach(x => _createImagesFromUrl.CreateImage(x, rootPath));
                return true;
            }
            catch (Exception e)
            {
                _logger.LogInformation(e.Message);
                return false;
            }
        }
        private void DeleteExistingFile(string sourcePath)
        {
            foreach (string files in Directory.GetFiles(sourcePath))
            {
                FileInfo fileInfo = new FileInfo(files);
                fileInfo.Delete(); //delete the files first. 
            }
        }

    }
}
