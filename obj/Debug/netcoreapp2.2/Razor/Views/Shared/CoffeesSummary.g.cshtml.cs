#pragma checksum "C:\Users\Adrianna\source\repos\Cafe\Cafe\Views\Shared\CoffeesSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5162a1a973841b8ae341b231899afcf485475faa"
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
using Cafe;

#line default
#line hidden
#line 2 "C:\Users\Adrianna\source\repos\Cafe\Cafe\Views\_ViewImports.cshtml"
using Cafe.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5162a1a973841b8ae341b231899afcf485475faa", @"/Views/Shared/CoffeesSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ec1d1d2251e08cbfe34610fe24f19a3578c9b6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_CoffeesSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Coffee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 86, true);
            WriteLiteral("\r\n<div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n    <div class =\"thumbnail\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 101, "\"", 131, 1);
#line 5 "C:\Users\Adrianna\source\repos\Cafe\Cafe\Views\Shared\CoffeesSummary.cshtml"
WriteAttributeValue("", 107, Model.ImageThumbnailUrl, 107, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(132, 79, true);
            WriteLiteral(" alt=\"\" />\r\n        <div class=\"capition\">\r\n            <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(212, 25, false);
#line 7 "C:\Users\Adrianna\source\repos\Cafe\Cafe\Views\Shared\CoffeesSummary.cshtml"
                              Write(Model.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(237, 44, true);
            WriteLiteral("</h3>\r\n            <h3>\r\n                <a>");
            EndContext();
            BeginContext(282, 10, false);
#line 9 "C:\Users\Adrianna\source\repos\Cafe\Cafe\Views\Shared\CoffeesSummary.cshtml"
              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(292, 40, true);
            WriteLiteral("</a>\r\n            </h3>\r\n            <p>");
            EndContext();
            BeginContext(333, 22, false);
#line 11 "C:\Users\Adrianna\source\repos\Cafe\Cafe\Views\Shared\CoffeesSummary.cshtml"
          Write(Model.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(355, 42, true);
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