#pragma checksum "E:\Programming\Random Stuff\PoolClub\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3be66ffa840e284b4a3c035c4f3b0b38f7ebad9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3be66ffa840e284b4a3c035c4f3b0b38f7ebad9", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"038445053d29b781d757b4330019cc5b04ae369a", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Programming\Random Stuff\PoolClub\Views\Users\Index.cshtml"
  
    ViewData["Title"]= "Users";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "E:\Programming\Random Stuff\PoolClub\Views\Users\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<table class=""table table-striped table-hover"">
    <thead>
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">Phone Number</th>
            <th scope=""col"">Role</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 17 "E:\Programming\Random Stuff\PoolClub\Views\Users\Index.cshtml"
         foreach (var appUser in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"cursor:pointer\"");
            BeginWriteAttribute("onclick", " onclick=\"", 508, "\"", 568, 5);
            WriteAttributeValue("", 518, "window.location", 518, 15, true);
            WriteAttributeValue(" ", 533, "=", 534, 2, true);
            WriteAttributeValue(" ", 535, "\'/Users/Details/", 536, 17, true);
#nullable restore
#line 19 "E:\Programming\Random Stuff\PoolClub\Views\Users\Index.cshtml"
WriteAttributeValue("", 552, appUser.UserId, 552, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 567, "\'", 567, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <th scope=\"row\">");
#nullable restore
#line 20 "E:\Programming\Random Stuff\PoolClub\Views\Users\Index.cshtml"
                           Write(appUser.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 21 "E:\Programming\Random Stuff\PoolClub\Views\Users\Index.cshtml"
               Write(appUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "E:\Programming\Random Stuff\PoolClub\Views\Users\Index.cshtml"
                                  Write(appUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "E:\Programming\Random Stuff\PoolClub\Views\Users\Index.cshtml"
               Write(appUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "E:\Programming\Random Stuff\PoolClub\Views\Users\Index.cshtml"
               Write(appUser.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "E:\Programming\Random Stuff\PoolClub\Views\Users\Index.cshtml"
               Write(appUser.RoleId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 26 "E:\Programming\Random Stuff\PoolClub\Views\Users\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
