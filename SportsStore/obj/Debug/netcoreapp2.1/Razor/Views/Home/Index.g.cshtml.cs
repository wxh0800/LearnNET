#pragma checksum "C:\Users\wxh08\Downloads\cmder\SportsStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "230b5be1c79ba2cea5a4a22118b1b83094d15925"
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
#line 1 "C:\Users\wxh08\Downloads\cmder\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"230b5be1c79ba2cea5a4a22118b1b83094d15925", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4d4e412f92f7e2dfc2df05447230d919cdf209a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(29, 459, true);
            WriteLiteral(@"
<h3 class=""p-2 bg-primary text-white text-center"">Products</h3>

<div class=""container-fluid mt-3"">
    <div class=""row"">
        <div class=""col-lg-3 font-weight-bold"">Name</div>
        <div class=""col-lg-3 font-weight-bold"">Category</div>
        <div class=""col-lg-3 font-weight-bold text-right"">Purchase Price</div>
        <div class=""col-lg-3 font-weight-bold text-right"">Retail Price</div>
        <div class=""col""></div>
    </div>

    ");
            EndContext();
            BeginContext(488, 647, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ba4abad2a134732b71a733a80f73669", async() => {
                BeginContext(532, 596, true);
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-lg-3""><input name=""Name"" class=""form-control"" /></div>
            <div class=""col-lg-3""><input name=""Category"" class=""form-control"" /></div>
            <div class=""col-lg-3"">
                <input name=""PurchasePrice"" class=""form-control"" />
            </div>
            <div class=""col-lg-3"">
                <input name=""RetailPrice"" class=""form-control"" />
            </div>
            <div class=""col"">
                <button type=""submit"" class=""btn btn-primary"">Add</button>
            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1135, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 30 "C:\Users\wxh08\Downloads\cmder\SportsStore\Views\Home\Index.cshtml"
     if (Model.Count() == 0) {

#line default
#line hidden
            BeginContext(1171, 99, true);
            WriteLiteral("        <div class=\"row\">\r\n        <div class=\"col text-center p-2\">No Data</div>\r\n        </div>\r\n");
            EndContext();
#line 34 "C:\Users\wxh08\Downloads\cmder\SportsStore\Views\Home\Index.cshtml"
    } else {
        

#line default
#line hidden
#line 35 "C:\Users\wxh08\Downloads\cmder\SportsStore\Views\Home\Index.cshtml"
         foreach (Product p in Model) {

#line default
#line hidden
            BeginContext(1325, 68, true);
            WriteLiteral("            <div class=\"row p-2\">\r\n                <div class=\"col\">");
            EndContext();
            BeginContext(1394, 6, false);
#line 37 "C:\Users\wxh08\Downloads\cmder\SportsStore\Views\Home\Index.cshtml"
                            Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1400, 41, true);
            WriteLiteral("</div>\r\n                <div class=\"col\">");
            EndContext();
            BeginContext(1442, 10, false);
#line 38 "C:\Users\wxh08\Downloads\cmder\SportsStore\Views\Home\Index.cshtml"
                            Write(p.Category);

#line default
#line hidden
            EndContext();
            BeginContext(1452, 52, true);
            WriteLiteral("</div>\r\n                <div class=\"col text-right\">");
            EndContext();
            BeginContext(1505, 15, false);
#line 39 "C:\Users\wxh08\Downloads\cmder\SportsStore\Views\Home\Index.cshtml"
                                       Write(p.PurchasePrice);

#line default
#line hidden
            EndContext();
            BeginContext(1520, 52, true);
            WriteLiteral("</div>\r\n                <div class=\"col text-right\">");
            EndContext();
            BeginContext(1573, 13, false);
#line 40 "C:\Users\wxh08\Downloads\cmder\SportsStore\Views\Home\Index.cshtml"
                                       Write(p.RetailPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1586, 69, true);
            WriteLiteral("</div>\r\n                <div class=\"col\"></div>\r\n            </div>\r\n");
            EndContext();
#line 43 "C:\Users\wxh08\Downloads\cmder\SportsStore\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#line 43 "C:\Users\wxh08\Downloads\cmder\SportsStore\Views\Home\Index.cshtml"
         
    }

#line default
#line hidden
            BeginContext(1673, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
