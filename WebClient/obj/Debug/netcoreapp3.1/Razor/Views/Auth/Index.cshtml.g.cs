#pragma checksum "D:\.NET\WebApp\WebClient\Views\Auth\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cbf329c25a4291ba88b30a1d58dd5b792b691ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Index), @"mvc.1.0.view", @"/Views/Auth/Index.cshtml")]
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
#line 1 "D:\.NET\WebApp\WebClient\Views\_ViewImports.cshtml"
using DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cbf329c25a4291ba88b30a1d58dd5b792b691ec", @"/Views/Auth/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13f4b7fc62913b65abf405431ce3e09d1e5ab3cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Account>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\.NET\WebApp\WebClient\Views\Auth\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Your Profile</h1>\r\n<p>Username: <b>");
#nullable restore
#line 7 "D:\.NET\WebApp\WebClient\Views\Auth\Index.cshtml"
           Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n<p>Email: <b>");
#nullable restore
#line 8 "D:\.NET\WebApp\WebClient\Views\Auth\Index.cshtml"
        Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n<a href=\"/auth/change\">Change Password</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Account> Html { get; private set; }
    }
}
#pragma warning restore 1591
