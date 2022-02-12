using Xcentium_Techincal_Code.Models;

namespace Xcentium_Techincal_Code.Repositories
{
    public interface IGetDataRepository
    {
        public ResultViewModel readResultData(string siteUrl);
    }
}
