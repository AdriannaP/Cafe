#pragma checksum "C:\Users\Adrianna\source\repos\Cafe\Cafe\Views\Shared\Carousel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d3aadeb5dac236746520368ee95799d5b5e85e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Carousel), @"mvc.1.0.view", @"/Views/Shared/Carousel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Carousel.cshtml", typeof(AspNetCore.Views_Shared_Carousel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d3aadeb5dac236746520368ee95799d5b5e85e9", @"/Views/Shared/Carousel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ec1d1d2251e08cbfe34610fe24f19a3578c9b6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Carousel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1352, true);
            WriteLiteral(@"<div class=""row carousel-holder"">
    <div class=""col-md-12"">
        <div id=""carousel-example-generic"" class=""carousel slide"" data-ride=""carousel"">
            <ol class="" carousel-indicators"">
                <li data-target=""#carousel-example-generic"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#carousel-example-generic"" data-slide-to=""1"" class=""active""></li>
                <li data-target=""#carousel-example-generic"" data-slide-to=""2"" class=""active""></li>
            </ol>
            <div class=""carousel-inner"">
                <div class=""item activ"">
                    <img class=""slide-image"" src=""~`/Images/1.jpg"" alt="""" />
                </div>
            </div>
            <div class=""item"">
                <img class=""slide-image"" src=""~`/Images/2.jpg"" alt="""" />
            </div>
        </div>
        <div class=""item"">
            <img class=""slide-image"" src=""~`/Images/3.jpg"" alt="""" />
        </div>
        <a class=""left carousel-control"" hr");
            WriteLiteral(@"ef=""#carousel-example-generic"" data-slide=""prev"">
            <span class=""glyhicon glyhicon-chevron-left""></span>
        </a>
        <a class=""right carousel-control"" href=""#carousel-example-generic"" data-slide=""next"">
            <span class=""glyhicon glyhicon-chevron-right""></span>
        </a>
    </div>
 </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591