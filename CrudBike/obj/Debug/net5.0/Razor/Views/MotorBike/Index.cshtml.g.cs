#pragma checksum "C:\Users\hp\source\repos\CrudBike\CrudBike\Views\MotorBike\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87038611381f6251118f834717e256d3fe0272bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MotorBike_Index), @"mvc.1.0.view", @"/Views/MotorBike/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\hp\source\repos\CrudBike\CrudBike\Views\_ViewImports.cshtml"
using CrudBike;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\source\repos\CrudBike\CrudBike\Views\_ViewImports.cshtml"
using CrudBike.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\source\repos\CrudBike\CrudBike\Views\MotorBike\Index.cshtml"
using CrudBike.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87038611381f6251118f834717e256d3fe0272bd", @"/Views/MotorBike/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"094c0adbd0c1a64b8068e3c3907dc9c6b80e9560", @"/Views/_ViewImports.cshtml")]
    public class Views_MotorBike_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cloudscribe.Pagination.Models.PagedResult<MotorBike>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PaginationPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\hp\source\repos\CrudBike\CrudBike\Views\MotorBike\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["Controller"] = "MotorBike";
    ViewData["Action"] = "Index";

    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">MotorBikes</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87038611381f6251118f834717e256d3fe0272bd5169", async() => {
                WriteLiteral("<i class=\"fas fa-motorcycle\"></i> &nbsp; Add New MotorBike ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<br />
<div class=""col-12"">
    <table class=""table table-striped border"">
        <tr class=""table-info"">
            <th>Photo</th>
            <th>Detail</th>
            <th>Price</th>
            <th>Seller Information</th>
            <th></th>
        </tr>
");
#nullable restore
#line 32 "C:\Users\hp\source\repos\CrudBike\CrudBike\Views\MotorBike\Index.cshtml"
         foreach (var item in Model.Data)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td><img");
            BeginWriteAttribute("src", " src=\"", 915, "\"", 958, 1);
#nullable restore
#line 35 "C:\Users\hp\source\repos\CrudBike\CrudBike\Views\MotorBike\Index.cshtml"
WriteAttributeValue("", 921, Html.DisplayFor(m => item.ImagePath), 921, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\" height=\"100\"");
            BeginWriteAttribute("alt", " alt=\"", 984, "\"", 990, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td>\r\n                    <b>");
#nullable restore
#line 37 "C:\Users\hp\source\repos\CrudBike\CrudBike\Views\MotorBike\Index.cshtml"
                  Write(Html.DisplayFor(m => item.Make.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 37 "C:\Users\hp\source\repos\CrudBike\CrudBike\Views\MotorBike\Index.cshtml"
                                                         Write(Html.DisplayFor(m => item.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</b> <br />\r\n                    <b>Model: </b>");
#nullable restore
#line 38 "C:\Users\hp\source\repos\CrudBike\CrudBike\Views\MotorBike\Index.cshtml"
                             Write(Html.DisplayFor(m => item.Model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Mileage: </b>");
#nullable restore
#line 39 "C:\Users\hp\source\repos\CrudBike\CrudBike\Views\MotorBike\Index.cshtml"
                               Write(Html.DisplayFor(m => item.Mileage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\hp\source\repos\CrudBike\CrudBike\Views\MotorBike\Index.cshtml"
               Write(Html.DisplayFor(m => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 41 "C:\Users\hp\source\repos\CrudBike\CrudBike\Views\MotorBike\Index.cshtml"
                                                 Write(Html.DisplayFor(m => item.Currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <b>Name: </b> ");
#nullable restore
#line 43 "C:\Users\hp\source\repos\CrudBike\CrudBike\Views\MotorBike\Index.cshtml"
                             Write(Html.DisplayFor(m => item.SellerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Email: </b>");
#nullable restore
#line 44 "C:\Users\hp\source\repos\CrudBike\CrudBike\Views\MotorBike\Index.cshtml"
                             Write(Html.DisplayFor(m => item.SellerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Phone: </b>");
#nullable restore
#line 45 "C:\Users\hp\source\repos\CrudBike\CrudBike\Views\MotorBike\Index.cshtml"
                             Write(Html.DisplayFor(m => item.SellerPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "87038611381f6251118f834717e256d3fe0272bd10342", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 47 "C:\Users\hp\source\repos\CrudBike\CrudBike\Views\MotorBike\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </tr>\r\n");
#nullable restore
#line 49 "C:\Users\hp\source\repos\CrudBike\CrudBike\Views\MotorBike\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "87038611381f6251118f834717e256d3fe0272bd12144", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 52 "C:\Users\hp\source\repos\CrudBike\CrudBike\Views\MotorBike\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 52 "C:\Users\hp\source\repos\CrudBike\CrudBike\Views\MotorBike\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("   \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cloudscribe.Pagination.Models.PagedResult<MotorBike>> Html { get; private set; }
    }
}
#pragma warning restore 1591