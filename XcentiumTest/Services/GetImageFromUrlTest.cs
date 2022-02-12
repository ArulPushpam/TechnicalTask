using System;
using System.Collections.Generic;
using System.Text;
using Xcentium_Techincal_Code.Services;
using Xunit;

namespace XcentiumTest.Services
{
   public class GetImageFromUrlTest
    {
        [Fact]
        public void GetImageFromUrl_ThrowsArgumentException()
        {

            //arrange
            GetImageFromUrl getImageFromUrl = new GetImageFromUrl();
            //act
            Action act = () => getImageFromUrl.ImageUrl("");
            //assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);

            Assert.Equal("websiteUrl Cannot be null", exception.Message);
        }
        [Theory]
        [InlineData("https://www.britannica.com/science/flower")]
        public void GetImageFromUrl_Should_Return_List(string webisteUrl)
        {

            //arrange
            GetImageFromUrl getImageFromUrl = new GetImageFromUrl();
            //act
            var list = getImageFromUrl.ImageUrl(webisteUrl);
            //assert
            //The thrown exception can be used for even more detailed assertions.
            Assert.Equal(18, list.Count);
        }
    }
}
