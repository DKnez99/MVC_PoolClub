#pragma checksum "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "162b1430621ff2f6a3c65026d8ff6ddbc4578850"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_MyReservations), @"mvc.1.0.view", @"/Views/Reservations/MyReservations.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"162b1430621ff2f6a3c65026d8ff6ddbc4578850", @"/Views/Reservations/MyReservations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d48c2b91f1995c7ddab87f4847bc9c9ae7b8b5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservations_MyReservations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ReservationViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reservations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyReservations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tables", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
  
    ViewData["Title"] = "My Reservations";
    var error = TempData["Error"] as string;
    var success = TempData["Success"] as string;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 7 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 8 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
 if (Model.Count > 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
     if (!String.IsNullOrEmpty(error))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"alert alert-danger\">");
#nullable restore
#line 12 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
                                 Write(error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 13 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
     if (!String.IsNullOrEmpty(success))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"alert alert-success\">");
#nullable restore
#line 17 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
                                  Write(success);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 18 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table id=""reservationsTable"" class=""table table-striped table-hover text-center"">
        <thead>
            <tr>
                <th style=""display:none"" scope=""col"">ReservationId</th>
                <th style=""width:10%"" scope=""col"">Table</th>
                <th style=""width:30%"" scope=""col"">Date</th>
                <th style=""width:20%"" scope=""col"">From</th>
                <th style=""width:20%"" scope=""col"">To</th>
                <th style=""width:20%"" scope=""col""></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 31 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
             foreach (var res in Model)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
                 if (res.Expired)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"text-danger\">\r\n                        <th style=\"display:none\" scope=\"row\">");
#nullable restore
#line 36 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
                                                        Write(res.ReservationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 37 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
                       Write(res.TableId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
                       Write(res.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
                       Write(res.TimeFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
                       Write(res.TimeTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td></td>\r\n                    </tr>\r\n");
#nullable restore
#line 43 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th style=\"display:none\" scope=\"row\">");
#nullable restore
#line 47 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
                                                        Write(res.ReservationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 48 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
                       Write(res.TableId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
                       Write(res.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 50 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
                       Write(res.TimeFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 51 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
                       Write(res.TimeTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "162b1430621ff2f6a3c65026d8ff6ddbc457885011630", async() => {
                WriteLiteral("\r\n                                <button style=\"font-size:12.5px;\" type=\"submit\" class=\"btn btn-danger p-1 m-0\">\r\n                                    Delete\r\n                                </button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
                                                                                             WriteLiteral(res.ReservationId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 60 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "162b1430621ff2f6a3c65026d8ff6ddbc457885015258", async() => {
                WriteLiteral("\r\n        <button type=\"submit\" class=\"btn btn-primary\">\r\n            New\r\n        </button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 69 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>You have not made any reservations yet.</p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "162b1430621ff2f6a3c65026d8ff6ddbc457885017260", async() => {
                WriteLiteral("\r\n        <button type=\"submit\" class=\"btn btn-primary\">\r\n            Make one\r\n        </button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 78 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\MyReservations.cshtml"
}

#line default
#line hidden
#nullable disable
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
