#pragma checksum "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "237f7771abbf83b491d254f8db9ac2f56cf4c31c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TokenRequestorRegistrations_Details), @"mvc.1.0.view", @"/Views/TokenRequestorRegistrations/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TokenRequestorRegistrations/Details.cshtml", typeof(AspNetCore.Views_TokenRequestorRegistrations_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"237f7771abbf83b491d254f8db9ac2f56cf4c31c", @"/Views/TokenRequestorRegistrations/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8264f60d1d86467c1e67d3a5c768af9d54aaac17", @"/Views/_ViewImports.cshtml")]
    public class Views_TokenRequestorRegistrations_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAspNet_Core.Models.TokenRequestorRegistration>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(102, 140, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>TokenRequestorRegistration</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(243, 39, false);
#line 14 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bin));

#line default
#line hidden
            EndContext();
            BeginContext(282, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(326, 35, false);
#line 17 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bin));

#line default
#line hidden
            EndContext();
            BeginContext(361, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(405, 44, false);
#line 20 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TokenBin));

#line default
#line hidden
            EndContext();
            BeginContext(449, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(493, 40, false);
#line 23 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayFor(model => model.TokenBin));

#line default
#line hidden
            EndContext();
            BeginContext(533, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(577, 51, false);
#line 26 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InitialRangeBin));

#line default
#line hidden
            EndContext();
            BeginContext(628, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(672, 47, false);
#line 29 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayFor(model => model.InitialRangeBin));

#line default
#line hidden
            EndContext();
            BeginContext(719, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(763, 49, false);
#line 32 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FinalRangeBin));

#line default
#line hidden
            EndContext();
            BeginContext(812, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(856, 45, false);
#line 35 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayFor(model => model.FinalRangeBin));

#line default
#line hidden
            EndContext();
            BeginContext(901, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(945, 48, false);
#line 38 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RangeCounter));

#line default
#line hidden
            EndContext();
            BeginContext(993, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1037, 44, false);
#line 41 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayFor(model => model.RangeCounter));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1125, 46, false);
#line 44 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LabelImkac));

#line default
#line hidden
            EndContext();
            BeginContext(1171, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1215, 42, false);
#line 47 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayFor(model => model.LabelImkac));

#line default
#line hidden
            EndContext();
            BeginContext(1257, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1301, 44, false);
#line 50 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LabelPci));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1389, 40, false);
#line 53 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayFor(model => model.LabelPci));

#line default
#line hidden
            EndContext();
            BeginContext(1429, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1473, 47, false);
#line 56 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmvkeyIndex));

#line default
#line hidden
            EndContext();
            BeginContext(1520, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1564, 43, false);
#line 59 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmvkeyIndex));

#line default
#line hidden
            EndContext();
            BeginContext(1607, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1651, 47, false);
#line 62 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PcikeyIndex));

#line default
#line hidden
            EndContext();
            BeginContext(1698, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1742, 43, false);
#line 65 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayFor(model => model.PcikeyIndex));

#line default
#line hidden
            EndContext();
            BeginContext(1785, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1829, 61, false);
#line 68 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateExpirationTokenPolicy));

#line default
#line hidden
            EndContext();
            BeginContext(1890, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1934, 57, false);
#line 71 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateExpirationTokenPolicy));

#line default
#line hidden
            EndContext();
            BeginContext(1991, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2035, 66, false);
#line 74 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TimeEventExpirationTokenPolicy));

#line default
#line hidden
            EndContext();
            BeginContext(2101, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2145, 62, false);
#line 77 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayFor(model => model.TimeEventExpirationTokenPolicy));

#line default
#line hidden
            EndContext();
            BeginContext(2207, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2251, 60, false);
#line 80 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EventCounterMaximuPolicy));

#line default
#line hidden
            EndContext();
            BeginContext(2311, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2355, 56, false);
#line 83 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayFor(model => model.EventCounterMaximuPolicy));

#line default
#line hidden
            EndContext();
            BeginContext(2411, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2455, 66, false);
#line 86 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TransactionAmountMaximumPolicy));

#line default
#line hidden
            EndContext();
            BeginContext(2521, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2565, 62, false);
#line 89 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
       Write(Html.DisplayFor(model => model.TransactionAmountMaximumPolicy));

#line default
#line hidden
            EndContext();
            BeginContext(2627, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2674, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75d38e39416d4975b6dbf7c563bd5281", async() => {
                BeginContext(2734, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 94 "C:\projetos\SampleLaerton\WebAspNet_Core\Views\TokenRequestorRegistrations\Details.cshtml"
                           WriteLiteral(Model.TokenRequestorId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2742, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2750, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7805badd2e24ec8ba8b6bf0a21f5cda", async() => {
                BeginContext(2772, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2788, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAspNet_Core.Models.TokenRequestorRegistration> Html { get; private set; }
    }
}
#pragma warning restore 1591
