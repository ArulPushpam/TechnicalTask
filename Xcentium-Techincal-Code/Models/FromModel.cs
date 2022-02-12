using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Xcentium_Techincal_Code.Models
{
    public class FromModel
    {
        [DisplayName("Website URL")]
        [Required(ErrorMessage = "Website URL is required.")]
        [MinLength(5, ErrorMessage = "Website URL must be atleast 5 characters")]
        [MaxLength(500, ErrorMessage = "Website URL cannot be more than 500 characters")]
        public string WebsiteUrl {get;set;}
    }
}
