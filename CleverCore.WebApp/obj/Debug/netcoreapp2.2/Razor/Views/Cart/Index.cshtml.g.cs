#pragma checksum "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c515be1d46b50d383077167e21f863450c8c4db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c515be1d46b50d383077167e21f863450c8c4db", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd3d1c620fe16ab0e5d895183369fa17156bf5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/client-app/controllers/cart/index.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Cart";

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(55, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(60, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c515be1d46b50d383077167e21f863450c8c4db4176", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 6 "D:\Project\unit test\CleverCore-second\CleverCore-master\CleverCore.WebApp\Views\Cart\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(148, 102, true);
                WriteLiteral("\n    <script>\n        var cartObj = new CartController();\n        cartObj.initialize();\n    </script>\n");
                EndContext();
            }
            );
            BeginContext(252, 3532, true);
            WriteLiteral(@"<!-- Main Container -->
<section class=""main-container col1-layout"">
    <div class=""main container"">
        <div class=""col-main"">
            <div class=""cart"">

                <div class=""page-content page-order"">
                    <div class=""page-title"">
                        <h2>Shopping Cart</h2>
                    </div>


                    <div class=""order-detail-content"">
                        <div class=""table-responsive"">
                            <table class=""table table-bordered cart_summary"">
                                <thead>
                                    <tr>
                                        <th class=""cart_product"">Product</th>
                                        <th>Description</th>
                                        <th>Unit price</th>
                                        <th>Qty</th>
                                        <th>Total</th>
                                        <th class=""action""><i class=""fa fa-trash-o""></i></th>
              ");
            WriteLiteral(@"                      </tr>
                                </thead>
                                <tbody id=""table-cart-content""></tbody>
                                <tfoot>
                                    <tr>
                                        <td colspan=""3""><strong>Total</strong></td>
                                        <td colspan=""3""><strong><span id=""lblTotalAmount""></span> </strong></td>
                                    </tr>
                                </tfoot>
                            </table>
                            <script id=""template-cart"" type=""x-tmpl-mustache"">
                                <tr data-id=""{{ProductId}}"">
                                    <td class=""cart_product"">
                                        <a href=""{{Url}}"">
                                            <img src=""{{Image}}"" alt=""{{ProductName}}"">
                                        </a>
                                    </td>
                                    <td class=""ca");
            WriteLiteral(@"rt_description"">
                                        <p class=""product-name""><a href=""#"">{{ProductName}}</a></p>
                                        <small><a href=""#"">Color : {{{Colors}}}</a></small>
                                        <small><a href=""#"">Size : {{{Sizes}}}</a></small>
                                    </td>
                                    <td class=""price""><span>{{Price}}</span></td>
                                    <td class=""qty""><input class=""form-control input-sm txtQuantity"" data-id=""{{ProductId}}"" type=""text"" value=""{{Quantity}}""></td>
                                    <td class=""price""><span>{{Amount}}</span></td>
                                    <td class=""action""><a href=""#"" data-id=""{{ProductId}}"" class=""btn-delete""><i class=""icon-close""></i></a></td>
                                </tr>
                            </script>
                        </div>
                        <div class=""cart_navigation"">
                            <a class=""continue-");
            WriteLiteral(@"btn"" href=""/products.html""><i class=""fa fa-arrow-left""> </i>&nbsp; Continue shopping</a>
                            <a id=""btnClearAll"" href=""#""><i class=""fa fa-remove""> </i>&nbsp; Clear cart</a>
                            <a class=""checkout-btn"" href=""/checkout.html""><i class=""fa fa-check""></i> Proceed to checkout</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
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
