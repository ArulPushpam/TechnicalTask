using Microsoft.AspNetCore.Mvc;
using Xcentium_Techincal_Code.Models;
using Xcentium_Techincal_Code.Repositories;

namespace Xcentium_Techincal_Code.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetDataRepository _getDataRepository;
        private readonly ISaveImageRepository _saveImageRepository;

        public HomeController(IGetDataRepository getDataRepository, ISaveImageRepository saveImageRepository)
        {
            _getDataRepository = getDataRepository;
            _saveImageRepository = saveImageRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Carousel(FromModel websiteURLModel)
        {
            ResultViewModel carouselImages = new ResultViewModel();
            if (_saveImageRepository.stroreImages(websiteURLModel.WebsiteUrl))
                carouselImages = _getDataRepository.readResultData(websiteURLModel.WebsiteUrl);
            return View(carouselImages);
        }
      
     
    }
}
