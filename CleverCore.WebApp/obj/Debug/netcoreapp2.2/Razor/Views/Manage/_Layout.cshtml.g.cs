#pragma checksum "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Manage\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98ddb01d05b5c8ec08f07c8d50e3e9629bfe9ab0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage__Layout), @"mvc.1.0.view", @"/Views/Manage/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/_Layout.cshtml", typeof(AspNetCore.Views_Manage__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98ddb01d05b5c8ec08f07c8d50e3e9629bfe9ab0", @"/Views/Manage/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd3d1c620fe16ab0e5d895183369fa17156bf5e", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Manage\_Layout.cshtml"
   
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(51, 155, true);
            WriteLiteral("\n<h2>Manage your account</h2>\n\n<div>\n    <h4>Change your account settings</h4>\n    <hr />\n    <div class=\"row\">\n        <div class=\"col-md-3\">\n            ");
            EndContext();
            BeginContext(207, 37, false);
#line 12 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Manage\_Layout.cshtml"
       Write(await Html.PartialAsync("_ManageNav"));

#line default
#line hidden
            EndContext();
            BeginContext(244, 59, true);
            WriteLiteral("\n        </div>\n        <div class=\"col-md-9\">\n            ");
            EndContext();
            BeginContext(304, 12, false);
#line 15 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Manage\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(316, 35, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(369, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(375, 41, false);
#line 21 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Manage\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(416, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(419, 9, true);
            WriteLiteral("        \n");
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
