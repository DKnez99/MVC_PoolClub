#pragma checksum "E:\Programming\Random Stuff\PoolClub\Views\Reservations\ReservationNotFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f010acebbe079e5948f0b5c5c0be0266c9deeeab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_ReservationNotFound), @"mvc.1.0.view", @"/Views/Reservations/ReservationNotFound.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f010acebbe079e5948f0b5c5c0be0266c9deeeab", @"/Views/Reservations/ReservationNotFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d48c2b91f1995c7ddab87f4847bc9c9ae7b8b5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservations_ReservationNotFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\ReservationNotFound.cshtml"
  
    ViewData["Title"] = "Error 404";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-danger mt-1 mb-1\">\r\n    <h1>");
#nullable restore
#line 6 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\ReservationNotFound.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <hr />\r\n    <h5>Reservation with id ");
#nullable restore
#line 8 "E:\Programming\Random Stuff\PoolClub\Views\Reservations\ReservationNotFound.cshtml"
                       Write(Model.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" does not exist.</h5>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
