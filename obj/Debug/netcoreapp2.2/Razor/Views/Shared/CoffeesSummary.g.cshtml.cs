#pragma checksum "C:\Users\Adrianna\source\repos\Cafe\Cafe\Views\Shared\CoffeesSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8b7c074b35b5e1756b00523900bce35e19c00ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_CoffeesSummary), @"mvc.1.0.view", @"/Views/Shared/CoffeesSummary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/CoffeesSummary.cshtml", typeof(AspNetCore.Views_Shared_CoffeesSummary))]
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
#line 1 "C:\Users\Adrianna\source\repos\Cafe\Cafe\Views\_ViewImports.cshtml"
using Cafe.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Adrianna\source\repos\Cafe\Cafe\Views\_ViewImports.cshtml"
using Cafe.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8b7c074b35b5e1756b00523900bce35e19c00ec", @"/Views/Shared/CoffeesSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d45e297311b3d6ccd682b1909d7b8d9384d64cfd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_CoffeesSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Coffee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 85, true);
            WriteLiteral("\r\n<div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n    <div class=\"thumbnail\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 100, "\"", 130, 1);
#line 5 "C:\Users\Adrianna\source\repos\Cafe\Cafe\Views\Shared\CoffeesSummary.cshtml"
WriteAttributeValue("", 106, Model.ImageThumbnailUrl, 106, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(131, 79, true);
            WriteLiteral(" alt=\"\" />\r\n        <div class=\"capition\">\r\n            <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(211, 25, false);
#line 7 "C:\Users\Adrianna\source\repos\Cafe\Cafe\Views\Shared\CoffeesSummary.cshtml"
                              Write(Model.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(236, 44, true);
            WriteLiteral("</h3>\r\n            <h3>\r\n                <a>");
            EndContext();
            BeginContext(281, 10, false);
#line 9 "C:\Users\Adrianna\source\repos\Cafe\Cafe\Views\Shared\CoffeesSummary.cshtml"
              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(291, 40, true);
            WriteLiteral("</a>\r\n            </h3>\r\n            <p>");
            EndContext();
            BeginContext(332, 22, false);
#line 11 "C:\Users\Adrianna\source\repos\Cafe\Cafe\Views\Shared\CoffeesSummary.cshtml"
          Write(Model.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(354, 42, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Coffee> Html { get; private set; }
    }
}
#pragma warning restore 1591
