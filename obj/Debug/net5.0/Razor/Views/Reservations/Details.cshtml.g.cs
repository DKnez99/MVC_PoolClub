#pragma checksum "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3701830f40dcb549ab0ea19d421a58fcc5d8fcaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_Details), @"mvc.1.0.view", @"/Views/Reservations/Details.cshtml")]
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
#line 1 "E:\Programming\Random Stuff\PoolClub\Views\_ViewImports.cshtml"
using PoolClub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Programming\Random Stuff\PoolClub\Views\_ViewImports.cshtml"
using PoolClub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Programming\Random Stuff\PoolClub\Views\_ViewImports.cshtml"
using PoolClub.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Programming\Random Stuff\PoolClub\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3701830f40dcb549ab0ea19d421a58fcc5d8fcaa", @"/Views/Reservations/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d48c2b91f1995c7ddab87f4847bc9c9ae7b8b5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservations_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReservationsDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reservations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Details.cshtml"
  
    ViewData["Title"] = "Reservation Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card \">\r\n    <h4 class=\"card-header\">");
#nullable restore
#line 7 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Details.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <div class=\"card-body\">\r\n        <div class=\"card-text\">\r\n            Id: ");
#nullable restore
#line 10 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Details.cshtml"
           Write(Model.ReservationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr />\r\n            Name: ");
#nullable restore
#line 12 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Details.cshtml"
             Write(Model.UserFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr />\r\n            Email: ");
#nullable restore
#line 14 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Details.cshtml"
              Write(Model.UserEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr />\r\n            Phone: ");
#nullable restore
#line 16 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Details.cshtml"
              Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr />\r\n            Table: ");
#nullable restore
#line 18 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Details.cshtml"
              Write(Model.TableId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr />\r\n            Date: ");
#nullable restore
#line 20 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Details.cshtml"
             Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr />\r\n            Time From: ");
#nullable restore
#line 22 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Details.cshtml"
                  Write(Model.TimeFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr />\r\n            Time To: ");
#nullable restore
#line 24 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Details.cshtml"
                Write(Model.TimeTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3701830f40dcb549ab0ea19d421a58fcc5d8fcaa7475", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReservationsDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
