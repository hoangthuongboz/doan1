#pragma checksum "D:\.NET\WebApp\WebClient\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42384380f00412df1727ea11f03f0e35de3e9be7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42384380f00412df1727ea11f03f0e35de3e9be7", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13f4b7fc62913b65abf405431ce3e09d1e5ab3cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Orders>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\.NET\WebApp\WebClient\Views\Order\Index.cshtml"
  
    
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Đơn hàng</h1>

<table>
    <thead>
        <tr>
            <th>Mã đơn hàng</th>
            <th>Ngày đặt</th>
            <th>Người giao hàng</th>
            <th>Số điện thoại người giao</th>
            <th>Trạng thái đơn hàng</th>
            <th></th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "D:\.NET\WebApp\WebClient\Views\Order\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "D:\.NET\WebApp\WebClient\Views\Order\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\.NET\WebApp\WebClient\Views\Order\Index.cshtml"
               Write(item.CreateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "D:\.NET\WebApp\WebClient\Views\Order\Index.cshtml"
               Write(item.HOTEN_DL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "D:\.NET\WebApp\WebClient\Views\Order\Index.cshtml"
               Write(item.SDT_DL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "D:\.NET\WebApp\WebClient\Views\Order\Index.cshtml"
               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a href=\"#\">Chi tiết đơn hàng</a></td>\r\n");
#nullable restore
#line 31 "D:\.NET\WebApp\WebClient\Views\Order\Index.cshtml"
                 if (item.Status_code == "P")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><a href=\"#\">Hủy đơn hàng</a></td>\r\n");
#nullable restore
#line 34 "D:\.NET\WebApp\WebClient\Views\Order\Index.cshtml"
                }else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><a href=\"#\">Đặt hàng lại</a></td>\r\n");
#nullable restore
#line 36 "D:\.NET\WebApp\WebClient\Views\Order\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n            </tr>\r\n");
#nullable restore
#line 39 "D:\.NET\WebApp\WebClient\Views\Order\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    \r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Orders>> Html { get; private set; }
    }
}
#pragma warning restore 1591