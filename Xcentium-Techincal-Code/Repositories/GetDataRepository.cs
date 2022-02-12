using Microsoft.Extensions.Logging;
using System;
using Xcentium_Techincal_Code.Models;
using Xcentium_Techincal_Code.Services;

namespace Xcentium_Techincal_Code.Repositories
{
    public class GetDataRepository : IGetDataRepository
    {
        protected readonly GetWWRootPath _getWWRootPath;
        protected readonly ReadImages _readImages;
        protected readonly GetWordCount _getWordCount;
        private readonly ILogger<GetDataRepository> _logger;
        public GetDataRepository(GetWWRootPath getWWRoot, ReadImages readImages, GetWordCount getWordCount, ILogger<GetDataRepository> logger)
        {
            _getWWRootPath = getWWRoot;
            _readImages = readImages;
            _getWordCount = getWordCount;
            _logger = logger;
        }
        public ResultViewModel readResultData(string siteUrl)
        {
            if (string.IsNullOrEmpty(siteUrl))
                throw new ArgumentException("siteUrl Cannot be null");

            ResultViewModel resultViewModel = new ResultViewModel();
            try
            {
                var rootPath = _getWWRootPath.GetPath();
                resultViewModel.ImageList = _readImages.GetImage(rootPath);
                resultViewModel.wordOccurances = _getWordCount.CalcualteWordOccurance(siteUrl);  
            }
            catch(Exception e)
            {
                _logger.LogInformation(e.Message);
            }
            return resultViewModel;
        }
    }
}
