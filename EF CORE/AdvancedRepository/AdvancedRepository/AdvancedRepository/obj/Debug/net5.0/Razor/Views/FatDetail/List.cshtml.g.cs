#pragma checksum "C:\301Sabah\15-EF CORE\AdvancedRepository\AdvancedRepository\AdvancedRepository\Views\FatDetail\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de29209146b86947b4541ea384b15eb47a1d47a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FatDetail_List), @"mvc.1.0.view", @"/Views/FatDetail/List.cshtml")]
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
#line 1 "C:\301Sabah\15-EF CORE\AdvancedRepository\AdvancedRepository\AdvancedRepository\Views\_ViewImports.cshtml"
using AdvancedRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\301Sabah\15-EF CORE\AdvancedRepository\AdvancedRepository\AdvancedRepository\Views\_ViewImports.cshtml"
using AdvancedRepository.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de29209146b86947b4541ea384b15eb47a1d47a7", @"/Views/FatDetail/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5375d1ec7ee915ddf63588b5726041bff0309f1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_FatDetail_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdvancedRepository.Models.Classes.FatDetail>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\301Sabah\15-EF CORE\AdvancedRepository\AdvancedRepository\AdvancedRepository\Views\FatDetail\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>FatDetail List</h1>


<table class=""table"">
    <thead>
        <tr>
            <th>
                Id
            </th>

            <th>
                Product Id
            </th>
            <th>Product Name</th>
            <th>
                UnitPrice
            </th>
            <th>
                Amount
            </th>



        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 34 "C:\301Sabah\15-EF CORE\AdvancedRepository\AdvancedRepository\AdvancedRepository\Views\FatDetail\List.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 36 "C:\301Sabah\15-EF CORE\AdvancedRepository\AdvancedRepository\AdvancedRepository\Views\FatDetail\List.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\301Sabah\15-EF CORE\AdvancedRepository\AdvancedRepository\AdvancedRepository\Views\FatDetail\List.cshtml"
           Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>");
#nullable restore
#line 41 "C:\301Sabah\15-EF CORE\AdvancedRepository\AdvancedRepository\AdvancedRepository\Views\FatDetail\List.cshtml"
           Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\301Sabah\15-EF CORE\AdvancedRepository\AdvancedRepository\AdvancedRepository\Views\FatDetail\List.cshtml"
           Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\301Sabah\15-EF CORE\AdvancedRepository\AdvancedRepository\AdvancedRepository\Views\FatDetail\List.cshtml"
           Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 56 "C:\301Sabah\15-EF CORE\AdvancedRepository\AdvancedRepository\AdvancedRepository\Views\FatDetail\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdvancedRepository.Models.Classes.FatDetail>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
