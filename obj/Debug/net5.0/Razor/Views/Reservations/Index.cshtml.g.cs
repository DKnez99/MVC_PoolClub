#pragma checksum "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ab204a00f80dc873ecd6e254395dab8cbb3c2f2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ab204a00f80dc873ecd6e254395dab8cbb3c2f2", @"/Views/Reservations/Index.cshtml")]
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
<table id=""reservationsTable"" class=""table table-striped table-hover"">
    <thead>
        <tr>
            <th style=""display:none"" scope=""col"">ReservationId</th>
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
#line 19 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
         foreach (var res in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
             if (res.Expired)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"text-danger\" style=\"cursor:pointer\" ");
            WriteLiteral(">\r\n                    <th style=\"display:none\" scope=\"row\">");
#nullable restore
#line 24 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                                                    Write(res.ReservationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 25 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.TableId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.TimeFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.TimeTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 32 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\"cursor:pointer\" ");
            WriteLiteral(">\r\n                    <th style=\"display:none\" scope=\"row\">");
#nullable restore
#line 36 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                                                    Write(res.ReservationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 37 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.TableId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.TimeFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.TimeTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
                   Write(res.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 44 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ab204a00f80dc873ecd6e254395dab8cbb3c2f29710", async() => {
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

    connection.on(""ReceiveReservation"", (reservation) => {

        var tbodyRef = document.getElementById(""reservationsTable"").getElementsByTagName(""tbody"")[0];

        var newRow = tbodyRef.insertRow(0);
        newRow.style.cursor = ""pointer"";
        var headerCell = document.createElement(""TH"");
        headerCell.innerHTML = reservation[0];
        headerCell.style.display = 'none';
        newRow.appendChild(headerCell);
        newRow.onclick = function () {
                var value = newRow.getElementsByTagName(""th"")[0].innerHTML;
                console.log(""/Reservations/Details/"" + value);
                window.location = ""/Reservations/Details/"" + value;
        };
        
        var cell1 = newRow.insertCell();
        cell1.innerHTML = reservation[3];
        var cell2 = newRow.insertCell();
        cell2.innerHTML = r");
            WriteLiteral(@"eservation[4];
        var cell3 = newRow.insertCell();
        cell3.innerHTML = reservation[5];
        var cell4 = newRow.insertCell();
        cell4.innerHTML = reservation[6];
        var cell5 = newRow.insertCell();
        cell5.innerHTML = reservation[1];
        var cell6 = newRow.insertCell();
        cell6.innerHTML = reservation[2];
        /*document.getElementById(""connected"").textContent = ""Received"";*/
        //var li = document.createElement(""li"");
        //document.getElementById(""reservationList"").appendChild(li);
        //li.textContent = reservation[0] + "" "" + reservation[1] + "" "" + reservation[2] + "" "" + reservation[3] + "" "" + reservation[4] + "" "" + reservation[5] + "" "" + reservation[6];
    });

    connection.on(""DeleteReservation"", (reservationId) => {
        var rows = document.getElementsByTagName(""tr"");
        for (var i = rows.length; i--;) {
            if (rows[i].cells[0].innerHTML==reservationId) {
                rows[i].parentNode.removeChild(rows[i])");
            WriteLiteral(@";
            }
        }
    });

    //signalR start connection
    connection.start().then(function () {
        document.getElementById(""connected"").textContent = ""Connected"";
    }).catch(function (err) {
        return console.error(err.toString());
    });

    //add on click functionality to every row in the table
    function onRowClick(tableId, callback) {
        var table = document.getElementById(tableId),
            rows = table.getElementsByTagName(""tr""),
            i;
        for (i = 0; i < rows.length; i++) {
            table.rows[i].onclick = function (row) {
                return function () {
                    callback(row);
                };
            }(table.rows[i]);
        }
    };

    //redirect to row's details page
    onRowClick(""reservationsTable"", function (row) {
        var value = row.getElementsByTagName(""th"")[0].innerHTML;
        console.log(""/Reservations/Details/"" + value);
        window.location = ""/Reservations/Details/"" + valu");
            WriteLiteral("e;\r\n    });\r\n\r\n</script>");
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
