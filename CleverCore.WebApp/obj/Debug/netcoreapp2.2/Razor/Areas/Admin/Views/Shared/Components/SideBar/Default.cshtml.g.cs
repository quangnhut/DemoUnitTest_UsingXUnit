#pragma checksum "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7f0cbc8f089cced2e262ace93017c95892d5dbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_SideBar_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/SideBar/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/Components/SideBar/Default.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_Components_SideBar_Default))]
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
#line 1 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7f0cbc8f089cced2e262ace93017c95892d5dbf", @"/Areas/Admin/Views/Shared/Components/SideBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3503cf13dbcba3e5f1f93859144ce3b575aea72", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_SideBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CleverCore.Application.ViewModels.System.FunctionViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(72, 163, true);
            WriteLiteral("<div id=\"sidebar-menu\" class=\"main_menu_side hidden-print main_menu\">\n    <div class=\"menu_section\">\n        <h3>Functions</h3>\n        <ul class=\"nav side-menu\">\n");
            EndContext();
#line 6 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
             foreach (var item in Model.Where(x=>string.IsNullOrEmpty(x.ParentId)))
            {

#line default
#line hidden
            BeginContext(333, 46, true);
            WriteLiteral("                <li>\n                    <a><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 379, "\"", 403, 2);
            WriteAttributeValue("", 387, "fa", 387, 2, true);
#line 9 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue(" ", 389, item.IconCss, 390, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(404, 6, true);
            WriteLiteral("></i> ");
            EndContext();
            BeginContext(411, 9, false);
#line 9 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(420, 46, true);
            WriteLiteral(" <span class=\"fa fa-chevron-down\"></span></a>\n");
            EndContext();
#line 10 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                     if (Model.Any(x => x.ParentId == item.Id))
                    {

#line default
#line hidden
            BeginContext(552, 52, true);
            WriteLiteral("                        <ul class=\"nav child_menu\">\n");
            EndContext();
#line 13 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                             foreach (var jitem in Model.Where(x => x.ParentId == item.Id))
                            {

#line default
#line hidden
            BeginContext(726, 38, true);
            WriteLiteral("                                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 764, "\"", 781, 1);
#line 15 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 771, jitem.URL, 771, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(782, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(784, 10, false);
#line 15 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                                                    Write(jitem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(794, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 16 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"

                            }

#line default
#line hidden
            BeginContext(835, 30, true);
            WriteLiteral("                        </ul>\n");
            EndContext();
#line 19 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"
                    }

#line default
#line hidden
            BeginContext(887, 42, true);
            WriteLiteral("                   \n                </li>\n");
            EndContext();
#line 22 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Areas\Admin\Views\Shared\Components\SideBar\Default.cshtml"

            }

#line default
#line hidden
            BeginContext(944, 43, true);
            WriteLiteral("           \n        </ul>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CleverCore.Application.ViewModels.System.FunctionViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591