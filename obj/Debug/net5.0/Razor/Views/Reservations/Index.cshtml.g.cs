#pragma checksum "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "313535f2710ddd0cbd8d10b7db7c8a69ad0987c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_Index), @"mvc.1.0.view", @"/Views/Reservations/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"313535f2710ddd0cbd8d10b7db7c8a69ad0987c4", @"/Views/Reservations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d48c2b91f1995c7ddab87f4847bc9c9ae7b8b5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ReservationViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
  
    ViewData["Title"] = "Reservations";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<table class=""table table-striped table-hover"">
    <thead>
        <tr>
            <th scope=""col"">Table</th>
            <th scope=""col"">Date</th>
            <th scope=""col"">From</th>
            <th scope=""col"">To</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">Phone number</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 18 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
         foreach (var res in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
             if (res.Expired)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"text-danger\" ");
            WriteLiteral(">\r\n                    <th scope=\"row\">");
#nullable restore
#line 23 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                               Write(res.TableId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 24 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.TimeFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.TimeTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr ");
            WriteLiteral(">\r\n                    <th scope=\"row\">");
#nullable restore
#line 34 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                               Write(res.TableId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 35 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.TimeFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.TimeTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 41 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<span id=\"connected\">Not connected</span>\r\n<ul id=\"reservationList\">\r\n</ul>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "313535f2710ddd0cbd8d10b7db7c8a69ad0987c49041", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"">
    ""use strict"";

    var connection = new signalR.HubConnectionBuilder().withUrl(""/Hubs/Reservation"").build();

    //connection.on(""ReceiveReservation"", (reservation) => {
    //    document.getElementById(""connected"").textContent = ""Received"";
    //    let messageObject = JSON.parse(reservation);
    //    var li = document.createElement(""li"");
    //    document.getElementById(""reservationList"").appendChild(li);
    //    var printout = JSON.parse(reservation);
    //// We can assign user-supplied strings to an element's textContent because it
    //// is not interpreted as markup. If you're assigning in any other way, you
    //// should be aware of possible script injection concerns.
    //    li.textContent = messageObject.UserEmail;
    //});

    connection.on(""ReceiveReservation"", (reservation) => {
        document.getElementById(""connected"").textContent = ""Received"";
        var li = document.createElement(""li"");
        document.getElementBy");
            WriteLiteral(@"Id(""reservationList"").appendChild(li);
        
        li.textContent = reservation[0]+"" ""+reservation[1];
    });

    connection.start().then(function () {
        document.getElementById(""connected"").textContent = ""Connected"";
    }).catch(function (err) {
    return console.error(err.toString());
});
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ReservationViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
