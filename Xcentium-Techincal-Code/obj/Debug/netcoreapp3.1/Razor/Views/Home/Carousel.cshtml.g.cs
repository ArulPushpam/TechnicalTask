#pragma checksum "C:\Learning\Xcentium-Techincal-Code\Views\Home\Carousel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee9c029ad4013124d650a27914b75cba76f23399"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Carousel), @"mvc.1.0.view", @"/Views/Home/Carousel.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Learning\Xcentium-Techincal-Code\Views\_ViewImports.cshtml"
using Xcentium_Techincal_Code;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Learning\Xcentium-Techincal-Code\Views\_ViewImports.cshtml"
using Xcentium_Techincal_Code.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Learning\Xcentium-Techincal-Code\Views\Home\Carousel.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee9c029ad4013124d650a27914b75cba76f23399", @"/Views/Home/Carousel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec5d6e5379957e9aaf61a82ac7db73391764e669", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Carousel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Xcentium_Techincal_Code.Models.ResultViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Learning\Xcentium-Techincal-Code\Views\Home\Carousel.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Hey, This is my Caurosel Section</h3>\r\n<div id=\"carouselExampleControls\" class=\"carousel slide\" data-ride=\"carousel\">\r\n    <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 11 "C:\Learning\Xcentium-Techincal-Code\Views\Home\Carousel.cshtml"
          int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Learning\Xcentium-Techincal-Code\Views\Home\Carousel.cshtml"
         foreach (var items in Model.ImageList)
        {
            var carouselUrl = "/" + Model.ImageFolder + "/" + items;
            i++;
            var active = i == 1 ? "active" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 528, "\"", 557, 2);
            WriteAttributeValue("", 536, "carousel-item", 536, 13, true);
#nullable restore
#line 17 "C:\Learning\Xcentium-Techincal-Code\Views\Home\Carousel.cshtml"
WriteAttributeValue(" ", 549, active, 550, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 603, "\"", 621, 1);
#nullable restore
#line 18 "C:\Learning\Xcentium-Techincal-Code\Views\Home\Carousel.cshtml"
WriteAttributeValue("", 609, carouselUrl, 609, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"carouselUrl slides\" style=\" width: 640px; height: 360px \">\r\n            </div>\r\n");
#nullable restore
#line 20 "C:\Learning\Xcentium-Techincal-Code\Views\Home\Carousel.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>
<hr class=""striped-border""/>

");
#nullable restore
#line 33 "C:\Learning\Xcentium-Techincal-Code\Views\Home\Carousel.cshtml"
Write(Html.RenderPartialAsync("WordCountPartialView",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(";");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Xcentium_Techincal_Code.Models.ResultViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
