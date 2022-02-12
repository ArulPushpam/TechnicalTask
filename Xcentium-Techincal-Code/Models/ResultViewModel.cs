using System.Collections.Generic;

namespace Xcentium_Techincal_Code.Models
{
    public class ResultViewModel
    {
        public List<string> ImageList { get; set; }
        public List<WordOccuranceModel> wordOccurances { get; set; }

        public string ImageFolder = "CarouselImages";
    }
}
