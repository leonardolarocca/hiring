#pragma checksum "/Users/larocca/Projects/hiring/C/XL/inventory/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c95da92f31b012a541b58157e247f3431a7215a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/larocca/Projects/hiring/C/XL/inventory/Views/_ViewImports.cshtml"
using inventory;

#line default
#line hidden
#line 2 "/Users/larocca/Projects/hiring/C/XL/inventory/Views/_ViewImports.cshtml"
using inventory.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c95da92f31b012a541b58157e247f3431a7215a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc3da102cfb7379d46a58f286856bb7313f44e97", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartphoneModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("searchForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/larocca/Projects/hiring/C/XL/inventory/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Inventory";

#line default
#line hidden
            BeginContext(85, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(92, 17, false);
#line 7 "/Users/larocca/Projects/hiring/C/XL/inventory/Views/Home/Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(109, 219, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"panel panel-default\">\r\n    <div class=\"panel-body\">        \r\n        <div class=\"col-md-6\"></div>\r\n        <div class=\"col-md-6\">            \r\n            <div class=\"input-group\">\r\n                ");
            EndContext();
            BeginContext(328, 419, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f6197686d0b4b9a94f5569ab14c8866", async() => {
                BeginContext(385, 355, true);
                WriteLiteral(@"
                    <input type=""text"" id=""searchbox"" name=""data"" class=""form-control"" placeholder=""search..."" />
                    <span class=""input-group-btn"">
                        <button type=""submit"" form=""searchForm"" class=""btn btn-default""><i class=""glyphicon glyphicon-search""></i></button>
                    </span>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(747, 653, true);
            WriteLiteral(@"
            </div>            
        </div>
        
        <div class=""form-group"">
            <table class=""table table-responsive table-striped"">
                <thead>
                    <tr>
                        <th><strong>Manufacturer</strong></th>
                        <th><strong>Model</strong></th>
                        <th><strong>Color</strong></th>
                        <th><strong>Carrier plan type</strong></th>
                        <th><strong>Quantity</strong></th>
                        <th><strong>Price</strong></th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 36 "/Users/larocca/Projects/hiring/C/XL/inventory/Views/Home/Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1473, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1536, 17, false);
#line 39 "/Users/larocca/Projects/hiring/C/XL/inventory/Views/Home/Index.cshtml"
                           Write(item.manufacturer);

#line default
#line hidden
            EndContext();
            BeginContext(1553, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1593, 10, false);
#line 40 "/Users/larocca/Projects/hiring/C/XL/inventory/Views/Home/Index.cshtml"
                           Write(item.model);

#line default
#line hidden
            EndContext();
            BeginContext(1603, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1643, 10, false);
#line 41 "/Users/larocca/Projects/hiring/C/XL/inventory/Views/Home/Index.cshtml"
                           Write(item.color);

#line default
#line hidden
            EndContext();
            BeginContext(1653, 141, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                <div class=\"label label-info\">\r\n                                    ");
            EndContext();
            BeginContext(1795, 22, false);
#line 44 "/Users/larocca/Projects/hiring/C/XL/inventory/Views/Home/Index.cshtml"
                               Write(item.carrier_plan_type);

#line default
#line hidden
            EndContext();
            BeginContext(1817, 200, true);
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"badge\">\r\n                                    ");
            EndContext();
            BeginContext(2018, 13, false);
#line 49 "/Users/larocca/Projects/hiring/C/XL/inventory/Views/Home/Index.cshtml"
                               Write(item.quantity);

#line default
#line hidden
            EndContext();
            BeginContext(2031, 111, true);
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                            <td>$ ");
            EndContext();
            BeginContext(2143, 10, false);
#line 52 "/Users/larocca/Projects/hiring/C/XL/inventory/Views/Home/Index.cshtml"
                             Write(item.price);

#line default
#line hidden
            EndContext();
            BeginContext(2153, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 54 "/Users/larocca/Projects/hiring/C/XL/inventory/Views/Home/Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2214, 84, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartphoneModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
