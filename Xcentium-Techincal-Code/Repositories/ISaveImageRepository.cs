using Xcentium_Techincal_Code.Models;

namespace Xcentium_Techincal_Code.Repositories
{
    public interface ISaveImageRepository
    {
        FromModel Get();
        bool stroreImages(string websiteurl);
    }
}
