#pragma checksum "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Page\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38bdffe73f097bc14d200d994440e7010405ef13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_Index), @"mvc.1.0.view", @"/Views/Page/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Page/Index.cshtml", typeof(AspNetCore.Views_Page_Index))]
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
#line 1 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38bdffe73f097bc14d200d994440e7010405ef13", @"/Views/Page/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd3d1c620fe16ab0e5d895183369fa17156bf5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Page_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CleverCore.Application.ViewModels.Blog.PageViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Page\Index.cshtml"
  
    ViewData["Title"] = Model.Name;
    ViewData["MetaKeyword"] = Model.Name;
    ViewData["MetaDescription"] = Model.Name;

#line default
#line hidden
            BeginContext(189, 402, true);
            WriteLiteral(@"
<!-- Main Container -->
<section class=""blog_post"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12"">
                <div class=""entry-detail"">
                    <div class=""page-title"">
                    </div>
                    <div class=""entry-meta-data"">
                        <div class=""blog-top-desc"">
                            <h1>");
            EndContext();
            BeginContext(592, 10, false);
#line 18 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Page\Index.cshtml"
                           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(602, 144, true);
            WriteLiteral("</h1>\n                        </div>\n                    </div>\n                    <div class=\"content-text clearfix\">\n                        ");
            EndContext();
            BeginContext(747, 23, false);
#line 22 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Page\Index.cshtml"
                   Write(Html.Raw(Model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(770, 135, true);
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</section>\n<!-- Main Container End --> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CleverCore.Application.ViewModels.Blog.PageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591