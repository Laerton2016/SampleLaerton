#pragma checksum "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbfb75aa4c4cc595381e616c7a34b5428af4c34f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MappingPaymentTokens_Delete), @"mvc.1.0.view", @"/Views/MappingPaymentTokens/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MappingPaymentTokens/Delete.cshtml", typeof(AspNetCore.Views_MappingPaymentTokens_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbfb75aa4c4cc595381e616c7a34b5428af4c34f", @"/Views/MappingPaymentTokens/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8264f60d1d86467c1e67d3a5c768af9d54aaac17", @"/Views/_ViewImports.cshtml")]
    public class Views_MappingPaymentTokens_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAspNet_Core.Models.MappingPaymentToken>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(94, 180, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>MappingPaymentToken</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(275, 39, false);
#line 15 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bin));

#line default
#line hidden
            EndContext();
            BeginContext(314, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(358, 35, false);
#line 18 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bin));

#line default
#line hidden
            EndContext();
            BeginContext(393, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(437, 45, false);
#line 21 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Panlength));

#line default
#line hidden
            EndContext();
            BeginContext(482, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(526, 41, false);
#line 24 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Panlength));

#line default
#line hidden
            EndContext();
            BeginContext(567, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(611, 47, false);
#line 27 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Panciphered));

#line default
#line hidden
            EndContext();
            BeginContext(658, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(702, 43, false);
#line 30 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Panciphered));

#line default
#line hidden
            EndContext();
            BeginContext(745, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(789, 61, false);
#line 33 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PanexpirationDateCiphered));

#line default
#line hidden
            EndContext();
            BeginContext(850, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(894, 57, false);
#line 36 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PanexpirationDateCiphered));

#line default
#line hidden
            EndContext();
            BeginContext(951, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(995, 47, false);
#line 39 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TokenLength));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1086, 43, false);
#line 42 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TokenLength));

#line default
#line hidden
            EndContext();
            BeginContext(1129, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1173, 48, false);
#line 45 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PaymentToken));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1265, 44, false);
#line 48 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PaymentToken));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1353, 48, false);
#line 51 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RangeCounter));

#line default
#line hidden
            EndContext();
            BeginContext(1401, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1445, 44, false);
#line 54 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RangeCounter));

#line default
#line hidden
            EndContext();
            BeginContext(1489, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1533, 58, false);
#line 57 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TokenReferenceIdlength));

#line default
#line hidden
            EndContext();
            BeginContext(1591, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1635, 54, false);
#line 60 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TokenReferenceIdlength));

#line default
#line hidden
            EndContext();
            BeginContext(1689, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1733, 55, false);
#line 63 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TokenExpirationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1788, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1832, 51, false);
#line 66 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TokenExpirationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1883, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1927, 39, false);
#line 69 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Atc));

#line default
#line hidden
            EndContext();
            BeginContext(1966, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2010, 35, false);
#line 72 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Atc));

#line default
#line hidden
            EndContext();
            BeginContext(2045, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2089, 48, false);
#line 75 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EventCounter));

#line default
#line hidden
            EndContext();
            BeginContext(2137, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2181, 44, false);
#line 78 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EventCounter));

#line default
#line hidden
            EndContext();
            BeginContext(2225, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2269, 56, false);
#line 81 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TimerEventExpiration));

#line default
#line hidden
            EndContext();
            BeginContext(2325, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2369, 52, false);
#line 84 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TimerEventExpiration));

#line default
#line hidden
            EndContext();
            BeginContext(2421, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2465, 50, false);
#line 87 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Last4DigitsPan));

#line default
#line hidden
            EndContext();
            BeginContext(2515, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2559, 46, false);
#line 90 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Last4DigitsPan));

#line default
#line hidden
            EndContext();
            BeginContext(2605, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2649, 50, false);
#line 93 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CodeValidation));

#line default
#line hidden
            EndContext();
            BeginContext(2699, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2743, 46, false);
#line 96 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CodeValidation));

#line default
#line hidden
            EndContext();
            BeginContext(2789, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2833, 49, false);
#line 99 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TokenLocation));

#line default
#line hidden
            EndContext();
            BeginContext(2882, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2926, 45, false);
#line 102 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TokenLocation));

#line default
#line hidden
            EndContext();
            BeginContext(2971, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3015, 47, false);
#line 105 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmvkeyIndex));

#line default
#line hidden
            EndContext();
            BeginContext(3062, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3106, 43, false);
#line 108 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmvkeyIndex));

#line default
#line hidden
            EndContext();
            BeginContext(3149, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3193, 47, false);
#line 111 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PcikeyIndex));

#line default
#line hidden
            EndContext();
            BeginContext(3240, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3284, 43, false);
#line 114 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PcikeyIndex));

#line default
#line hidden
            EndContext();
            BeginContext(3327, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3371, 81, false);
#line 117 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AccountAndCardHolderDataAndDeviceDataCiphered));

#line default
#line hidden
            EndContext();
            BeginContext(3452, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3496, 77, false);
#line 120 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AccountAndCardHolderDataAndDeviceDataCiphered));

#line default
#line hidden
            EndContext();
            BeginContext(3573, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3617, 50, false);
#line 123 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TokenRequestor));

#line default
#line hidden
            EndContext();
            BeginContext(3667, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3711, 63, false);
#line 126 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TokenRequestor.TokenRequestorId));

#line default
#line hidden
            EndContext();
            BeginContext(3774, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3812, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d5dd75d6a82406c8616d8cd189bb29e", async() => {
                BeginContext(3818, 36, true);
                WriteLiteral("\r\n        <a class=\"btn btn-default\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3854, "\"", 3951, 1);
#line 131 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\MappingPaymentTokens\Delete.cshtml"
WriteAttributeValue("", 3861, Url.Action("DeleteConfirmed",new {id2=Model.TokenRequestorId, id=Model.TokenReferenceId}), 3861, 90, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3952, 21, true);
                WriteLiteral(">Delete</a>\r\n        ");
                EndContext();
                BeginContext(3973, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30cfc1cf57f748ff82dc6b6f9c901885", async() => {
                    BeginContext(3995, 12, true);
                    WriteLiteral("Back to List");
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
                BeginContext(4011, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4024, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAspNet_Core.Models.MappingPaymentToken> Html { get; private set; }
    }
}
#pragma warning restore 1591