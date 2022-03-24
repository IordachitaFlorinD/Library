#pragma checksum "C:\Users\Florin\source\repos\Library\Library\Views\Patron\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7576a16621ce6320c10cc70b092c1d9ea8c0d14b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patron_Detail), @"mvc.1.0.view", @"/Views/Patron/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7576a16621ce6320c10cc70b092c1d9ea8c0d14b", @"/Views/Patron/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Patron_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Patron.PatronDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Florin\source\repos\Library\Library\Views\Patron\Detail.cshtml"
  
    ViewBag.Title = $"Patron: {@Model.LastName}, {@Model.FirstName}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section>\r\n    <div class=\"p-4 p-md-5 mb-4 text-white rounded bg-dark\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8 px-0\">\r\n                <h1 class=\"display-1 fw-bold\">");
#nullable restore
#line 10 "C:\Users\Florin\source\repos\Library\Library\Views\Patron\Detail.cshtml"
                                         Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "C:\Users\Florin\source\repos\Library\Library\Views\Patron\Detail.cshtml"
                                                          Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <p class=\"lead my-3\">Member for ");
#nullable restore
#line 11 "C:\Users\Florin\source\repos\Library\Library\Views\Patron\Detail.cshtml"
                                           Write(Model.MemberSince);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
            <div class=""col-4"">
                <h4>Patron Info</h4>
                <table class=""table table-sm table-dark text-white"">
                    <tr>
                        <td>Address</td>
                        <td>");
#nullable restore
#line 18 "C:\Users\Florin\source\repos\Library\Library\Views\Patron\Detail.cshtml"
                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Telephone</td>\r\n                        <td>");
#nullable restore
#line 22 "C:\Users\Florin\source\repos\Library\Library\Views\Patron\Detail.cshtml"
                       Write(Model.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>OverdueFees</td>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\Florin\source\repos\Library\Library\Views\Patron\Detail.cshtml"
                       Write(Model.OverdueFees);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>LibraryCardId</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\Florin\source\repos\Library\Library\Views\Patron\Detail.cshtml"
                       Write(Model.LibraryCardId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>HomeLibrary</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\Florin\source\repos\Library\Library\Views\Patron\Detail.cshtml"
                       Write(Model.HomeLibraryBranch);

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
            <div class=""col-6"">
                <h4>Current Checked Out Assets</h4>
");
#nullable restore
#line 49 "C:\Users\Florin\source\repos\Library\Library\Views\Patron\Detail.cshtml"
                 if (!Model.AssestsCheckedOut.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>\r\n                        No items checked out.\r\n                    </p>\r\n");
#nullable restore
#line 54 "C:\Users\Florin\source\repos\Library\Library\Views\Patron\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <table class=\"table table-sm\">\r\n                    </table>\r\n");
#nullable restore
#line 59 "C:\Users\Florin\source\repos\Library\Library\Views\Patron\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-6\">\r\n                <h4>Current Holds</h4>\r\n");
#nullable restore
#line 63 "C:\Users\Florin\source\repos\Library\Library\Views\Patron\Detail.cshtml"
                 if (!Model.Holds.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>\r\n                        No items currently on hold.\r\n                    </p>\r\n");
#nullable restore
#line 68 "C:\Users\Florin\source\repos\Library\Library\Views\Patron\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <table class=\"table table-sm\">\r\n                    </table>\r\n");
#nullable restore
#line 73 "C:\Users\Florin\source\repos\Library\Library\Views\Patron\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<hr />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Patron.PatronDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
