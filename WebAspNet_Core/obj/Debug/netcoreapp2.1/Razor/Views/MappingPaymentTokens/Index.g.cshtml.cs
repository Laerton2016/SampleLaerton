#pragma checksum "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "577e44639cfd2da3ae531e71f38ae99657bc28ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MappingPaymentTokens_Index), @"mvc.1.0.view", @"/Views/MappingPaymentTokens/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MappingPaymentTokens/Index.cshtml", typeof(AspNetCore.Views_MappingPaymentTokens_Index))]
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
#line 1 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\_ViewImports.cshtml"
using WebAspNet_Core;

#line default
#line hidden
#line 2 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\_ViewImports.cshtml"
using WebAspNet_Core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"577e44639cfd2da3ae531e71f38ae99657bc28ee", @"/Views/MappingPaymentTokens/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8264f60d1d86467c1e67d3a5c768af9d54aaac17", @"/Views/_ViewImports.cshtml")]
    public class Views_MappingPaymentTokens_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebAspNet_Core.Models.MappingPaymentToken>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(106, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(135, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e03e5ef841494b9b88f93f3b7984da80", async() => {
                BeginContext(158, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(172, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(265, 39, false);
#line 16 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bin));

#line default
#line hidden
            EndContext();
            BeginContext(304, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(360, 45, false);
#line 19 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Panlength));

#line default
#line hidden
            EndContext();
            BeginContext(405, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(461, 47, false);
#line 22 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Panciphered));

#line default
#line hidden
            EndContext();
            BeginContext(508, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(564, 61, false);
#line 25 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PanexpirationDateCiphered));

#line default
#line hidden
            EndContext();
            BeginContext(625, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(681, 47, false);
#line 28 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TokenLength));

#line default
#line hidden
            EndContext();
            BeginContext(728, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(784, 48, false);
#line 31 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PaymentToken));

#line default
#line hidden
            EndContext();
            BeginContext(832, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(888, 48, false);
#line 34 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RangeCounter));

#line default
#line hidden
            EndContext();
            BeginContext(936, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(992, 58, false);
#line 37 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TokenReferenceIdlength));

#line default
#line hidden
            EndContext();
            BeginContext(1050, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1106, 55, false);
#line 40 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TokenExpirationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1161, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1217, 39, false);
#line 43 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Atc));

#line default
#line hidden
            EndContext();
            BeginContext(1256, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1312, 48, false);
#line 46 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EventCounter));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1416, 56, false);
#line 49 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TimerEventExpiration));

#line default
#line hidden
            EndContext();
            BeginContext(1472, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1528, 50, false);
#line 52 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Last4DigitsPan));

#line default
#line hidden
            EndContext();
            BeginContext(1578, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1634, 50, false);
#line 55 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CodeValidation));

#line default
#line hidden
            EndContext();
            BeginContext(1684, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1740, 49, false);
#line 58 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TokenLocation));

#line default
#line hidden
            EndContext();
            BeginContext(1789, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1845, 47, false);
#line 61 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmvkeyIndex));

#line default
#line hidden
            EndContext();
            BeginContext(1892, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1948, 47, false);
#line 64 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PcikeyIndex));

#line default
#line hidden
            EndContext();
            BeginContext(1995, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2051, 81, false);
#line 67 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountAndCardHolderDataAndDeviceDataCiphered));

#line default
#line hidden
            EndContext();
            BeginContext(2132, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2188, 50, false);
#line 70 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TokenRequestor));

#line default
#line hidden
            EndContext();
            BeginContext(2238, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 76 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2356, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2405, 38, false);
#line 79 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bin));

#line default
#line hidden
            EndContext();
            BeginContext(2443, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2499, 44, false);
#line 82 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Panlength));

#line default
#line hidden
            EndContext();
            BeginContext(2543, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2599, 46, false);
#line 85 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Panciphered));

#line default
#line hidden
            EndContext();
            BeginContext(2645, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2701, 60, false);
#line 88 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PanexpirationDateCiphered));

#line default
#line hidden
            EndContext();
            BeginContext(2761, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2817, 46, false);
#line 91 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TokenLength));

#line default
#line hidden
            EndContext();
            BeginContext(2863, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2919, 47, false);
#line 94 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PaymentToken));

#line default
#line hidden
            EndContext();
            BeginContext(2966, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3022, 47, false);
#line 97 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RangeCounter));

#line default
#line hidden
            EndContext();
            BeginContext(3069, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3125, 57, false);
#line 100 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TokenReferenceIdlength));

#line default
#line hidden
            EndContext();
            BeginContext(3182, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3238, 54, false);
#line 103 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TokenExpirationDate));

#line default
#line hidden
            EndContext();
            BeginContext(3292, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3348, 38, false);
#line 106 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Atc));

#line default
#line hidden
            EndContext();
            BeginContext(3386, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3442, 47, false);
#line 109 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EventCounter));

#line default
#line hidden
            EndContext();
            BeginContext(3489, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3545, 55, false);
#line 112 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TimerEventExpiration));

#line default
#line hidden
            EndContext();
            BeginContext(3600, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3656, 49, false);
#line 115 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Last4DigitsPan));

#line default
#line hidden
            EndContext();
            BeginContext(3705, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3761, 49, false);
#line 118 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CodeValidation));

#line default
#line hidden
            EndContext();
            BeginContext(3810, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3866, 48, false);
#line 121 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TokenLocation));

#line default
#line hidden
            EndContext();
            BeginContext(3914, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3970, 46, false);
#line 124 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmvkeyIndex));

#line default
#line hidden
            EndContext();
            BeginContext(4016, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4072, 46, false);
#line 127 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PcikeyIndex));

#line default
#line hidden
            EndContext();
            BeginContext(4118, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4174, 80, false);
#line 130 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AccountAndCardHolderDataAndDeviceDataCiphered));

#line default
#line hidden
            EndContext();
            BeginContext(4254, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4310, 66, false);
#line 133 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TokenRequestor.TokenRequestorId));

#line default
#line hidden
            EndContext();
            BeginContext(4376, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4432, 121, false);
#line 136 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.TokenReferenceId , id2= item.TokenRequestorId /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(4553, 19, true);
            WriteLiteral(" \r\n                ");
            EndContext();
            BeginContext(4573, 126, false);
#line 137 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new {id = item.TokenReferenceId , id2= item.TokenRequestorId /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(4699, 19, true);
            WriteLiteral(" \r\n                ");
            EndContext();
            BeginContext(4719, 124, false);
#line 138 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.TokenReferenceId , id2= item.TokenRequestorId/* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(4843, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 141 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Index.cshtml"
}

#line default
#line hidden
            BeginContext(4882, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebAspNet_Core.Models.MappingPaymentToken>> Html { get; private set; }
    }
}
#pragma warning restore 1591
