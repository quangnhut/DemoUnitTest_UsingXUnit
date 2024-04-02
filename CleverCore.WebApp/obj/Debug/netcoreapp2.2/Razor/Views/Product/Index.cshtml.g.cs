#pragma checksum "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "999105f251ad03df4846511fd1ad6d08d805464e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"999105f251ad03df4846511fd1ad6d08d805464e", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd3d1c620fe16ab0e5d895183369fa17156bf5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CleverCore.Application.ViewModels.Product.ProductCategoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "All product  categories";
    ViewData["MetaDescription"] = "All our products";

#line default
#line hidden
            BeginContext(190, 874, true);
            WriteLiteral(@"<!-- Breadcrumbs -->

<div class=""breadcrumbs"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <ul>
                    <li class=""home""> <a title=""Go to Home Page"" href=""/"">Home</a><span>&raquo;</span></li>
                    <li><strong>Product categories</strong></li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- Breadcrumbs End -->
<!-- Main Container -->
<div class=""main-container col1-layout"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-main col-sm-12 col-xs-12"">
                <div class=""shop-inner"">
                    <div class=""page-title"">
                        <h2>Product categories</h2>
                    </div>

                    <div class=""product-grid-area"">
                        <ul class=""products-grid"">
");
            EndContext();
#line 33 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Product\Index.cshtml"
                             foreach (var item in Model)
                            {
                                var url = "/" + item.SeoAlias + "-c." + item.Id + ".html";

#line default
#line hidden
            BeginContext(1242, 613, true);
            WriteLiteral(@"                                <li class=""item col-lg-3 col-md-4 col-sm-6 col-xs-6 "">
                                    <div class=""product-item"">
                                        <div class=""item-inner"">
                                            <div class=""product-thumbnail"">
                                                <div class=""icon-sale-label sale-left"">Sale</div>
                                                <div class=""icon-new-label new-right"">New</div>
                                                <div class=""pr-img-area"">
                                                    <a");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1855, "\"", 1873, 1);
#line 43 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 1863, item.Name, 1863, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1874, "\"", 1885, 1);
#line 43 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 1881, url, 1881, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1886, 89, true);
            WriteLiteral(">\n                                                        <figure> <img class=\"first-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1975, "\"", 1992, 1);
#line 44 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 1981, item.Image, 1981, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1993, "\"", 2009, 1);
#line 44 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 1999, item.Name, 1999, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2010, 24, true);
            WriteLiteral("> <img class=\"hover-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2034, "\"", 2051, 1);
#line 44 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 2040, item.Image, 2040, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2052, "\"", 2068, 1);
#line 44 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Product\Index.cshtml"
WriteAttributeValue("", 2058, item.Name, 2058, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2069, 303, true);
            WriteLiteral(@"></figure>
                                                    </a>
                                                </div>

                                            </div>
                                        </div>
                                    </div>
                                </li>
");
            EndContext();
#line 52 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Product\Index.cshtml"

                            }

#line default
#line hidden
            BeginContext(2403, 161, true);
            WriteLiteral("\n                        </ul>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n<!-- Main Container End -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CleverCore.Application.ViewModels.Product.ProductCategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591