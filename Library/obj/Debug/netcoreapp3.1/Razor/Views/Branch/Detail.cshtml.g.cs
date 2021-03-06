#pragma checksum "C:\Users\Florin\source\repos\Library\Library\Views\Branch\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0a75c416431b5a3f3e361ed137d35ca2a46dadf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Branch_Detail), @"mvc.1.0.view", @"/Views/Branch/Detail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Florin\source\repos\Library\Library\Views\_ViewImports.cshtml"
using Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Florin\source\repos\Library\Library\Views\_ViewImports.cshtml"
using Library.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0a75c416431b5a3f3e361ed137d35ca2a46dadf", @"/Views/Branch/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Branch_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Branch.BranchDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Florin\source\repos\Library\Library\Views\Branch\Detail.cshtml"
  
    ViewBag.Title = $"{@Model.Name} Branch";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section>\r\n    <div class=\"p-4 p-md-5 mb-4 text-white rounded bg-dark\"");
            BeginWriteAttribute("style", "\r\n         style=\"", 175, "\"", 502, 20);
            WriteAttributeValue("", 193, "background-image:", 193, 17, true);
            WriteAttributeValue("\r\n                ", 210, "linear-gradient(to", 228, 36, true);
            WriteAttributeValue(" ", 246, "bottom,", 247, 8, true);
            WriteAttributeValue(" ", 254, "rgba(0,", 255, 8, true);
            WriteAttributeValue(" ", 262, "0,", 263, 3, true);
            WriteAttributeValue(" ", 265, "0,", 266, 3, true);
            WriteAttributeValue(" ", 268, "0.6),", 269, 6, true);
            WriteAttributeValue(" ", 274, "rgba(0,", 275, 8, true);
            WriteAttributeValue(" ", 282, "0,", 283, 3, true);
            WriteAttributeValue(" ", 285, "0,", 286, 3, true);
            WriteAttributeValue(" ", 288, "0.95)),", 289, 8, true);
            WriteAttributeValue("\r\n                ", 296, "url(", 314, 22, true);
#nullable restore
#line 11 "C:\Users\Florin\source\repos\Library\Library\Views\Branch\Detail.cshtml"
WriteAttributeValue("", 318, Url.Content($"~/images/libraries/{Model.ImageUrl}"), 318, 52, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 370, ");", 370, 2, true);
            WriteAttributeValue("\r\n                ", 372, "background-position:", 390, 38, true);
            WriteAttributeValue(" ", 410, "center;", 411, 8, true);
            WriteAttributeValue("\r\n                ", 418, "background-repeat:", 436, 36, true);
            WriteAttributeValue(" ", 454, "repeat;", 455, 8, true);
            WriteAttributeValue("\r\n                ", 462, "background-size:", 480, 34, true);
            WriteAttributeValue(" ", 496, "auto;", 497, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8 px-0\">\r\n                <h1 class=\"display-1 fw-bold\">");
#nullable restore
#line 17 "C:\Users\Florin\source\repos\Library\Library\Views\Branch\Detail.cshtml"
                                         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <p class=\"lead my-3\">");
#nullable restore
#line 18 "C:\Users\Florin\source\repos\Library\Library\Views\Branch\Detail.cshtml"
                                Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-md-4 px-0\">\r\n                <figure class=\"figure\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 825, "\"", 883, 1);
#nullable restore
#line 22 "C:\Users\Florin\source\repos\Library\Library\Views\Branch\Detail.cshtml"
WriteAttributeValue("", 831, Url.Content($"~/images/libraries/{Model.ImageUrl}"), 831, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                         class=\"figure-img rounded img-thumbnail img-fluid\"");
            BeginWriteAttribute("alt", "\r\n                         alt=\"", 961, "\"", 1013, 3);
            WriteAttributeValue("", 993, "Image", 993, 5, true);
            WriteAttributeValue(" ", 998, "of", 999, 3, true);
#nullable restore
#line 24 "C:\Users\Florin\source\repos\Library\Library\Views\Branch\Detail.cshtml"
WriteAttributeValue(" ", 1001, Model.Name, 1002, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <figcaption class=\"figure-caption text-light\">\r\n                        Photo of ");
#nullable restore
#line 26 "C:\Users\Florin\source\repos\Library\Library\Views\Branch\Detail.cshtml"
                            Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </figcaption>
                </figure>
            </div>
        </div>
    </div>
</section>

<hr />

<section>
    <div class=""container"">
        <div class=""row"">
            <h3>Branch Data</h3>
            <div class=""col-6"">
                <h4>Branch Info</h4>
                <table class=""table table-sm"">
                    <tr>
                        <td>Address</td>
                        <td>");
#nullable restore
#line 45 "C:\Users\Florin\source\repos\Library\Library\Views\Branch\Detail.cshtml"
                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Telephone</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\Florin\source\repos\Library\Library\Views\Branch\Detail.cshtml"
                       Write(Model.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Date Established</td>\r\n                        <td>");
#nullable restore
#line 53 "C:\Users\Florin\source\repos\Library\Library\Views\Branch\Detail.cshtml"
                       Write(Model.OpenDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    </tr>
                </table>
            </div>
            <div class=""col-6"">
                <h4>Branch Asset Summary</h4>
                <table class=""table table-sm"">
                    <tr>
                        <td>Total Asset Count</td>
                        <td>");
#nullable restore
#line 62 "C:\Users\Florin\source\repos\Library\Library\Views\Branch\Detail.cshtml"
                       Write(Model.NumberOfAssets);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Total Asset Value</td>\r\n                        <td>");
#nullable restore
#line 66 "C:\Users\Florin\source\repos\Library\Library\Views\Branch\Detail.cshtml"
                       Write(Model.TotalAssetValue);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</section>

<hr />

<section>
    <div class=""container"">
        <div class=""row"">
            <h3>Schedule</h3>
            <div class=""col-lg-12"">
                <div id=""branchHours"">
                    <table class=""table table-sm"">
");
#nullable restore
#line 83 "C:\Users\Florin\source\repos\Library\Library\Views\Branch\Detail.cshtml"
                         foreach (var day in @Model.HoursOpen)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 86 "C:\Users\Florin\source\repos\Library\Library\Views\Branch\Detail.cshtml"
                               Write(day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 88 "C:\Users\Florin\source\repos\Library\Library\Views\Branch\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n                </div>\r\n            </div>\r\n            <h3>Registered Patrons</h3>\r\n            <div class=\"col-lg-12\">\r\n                <div id=\"branchHours\">\r\n                    <table class=\"table table-sm\">\r\n");
#nullable restore
#line 96 "C:\Users\Florin\source\repos\Library\Library\Views\Branch\Detail.cshtml"
                         foreach (var day in @Model.HoursOpen)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 99 "C:\Users\Florin\source\repos\Library\Library\Views\Branch\Detail.cshtml"
                               Write(day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 101 "C:\Users\Florin\source\repos\Library\Library\Views\Branch\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Branch.BranchDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
