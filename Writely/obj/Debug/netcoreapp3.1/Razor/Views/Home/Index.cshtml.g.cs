#pragma checksum "C:\Users\CpuInfotech\RiderProjects\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e31539b69697acf9409463aa857e292923425a7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\CpuInfotech\RiderProjects\Grupa5-ReadTheWorld\Writely\Views\_ViewImports.cshtml"
using Writely;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CpuInfotech\RiderProjects\Grupa5-ReadTheWorld\Writely\Views\_ViewImports.cshtml"
using Writely.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e31539b69697acf9409463aa857e292923425a7a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d62dacfa5f250d85f49326da7207ac7f881b0c83", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Rad>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\CpuInfotech\RiderProjects\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n \r\n");
            WriteLiteral(@"
<style>
    body {
        background-image: url(https://images.pexels.com/photos/3747490/pexels-photo-3747490.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940);
    }
    .grid-container {
        display: flow;
        grid-gap: 16px;
        grid-template-columns: repeat(3, 1fr);
     
    }
    .cardcontainer {
        padding-top: 12%;
        background: #D2B48C;
        border-radius: 8px;
        position: relative;
    } 
  .cardcontent {
    position: absolute;
    width: 100%;
  }
    card {
        padding-top: 12%;
        background: #D2B48C;
        border-radius: 8px;
        position: relative;
    }
  img {
      max-width: 100%;
      max-height: 100%;
  }
  
</style>


<div class=""text-center"">
    <h1 class=""display-4"" style=""font-family: Perpetua"">Writely</h1>
</div>
<div class=""grid-container"">
");
#nullable restore
#line 46 "C:\Users\CpuInfotech\RiderProjects\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <card>
            <div class=""cardcontent"">
                <div class=""card-img"">
                    <img src=""https://i.pinimg.com/564x/75/35/20/753520b079783e156451a10e8e1c6bc0.jpg"" style=""width: 100%"" height=""150""/>
                </div>
                <div class=""card-header"" style=""font-family: Perpetua"">
                    <h2>");
#nullable restore
#line 54 "C:\Users\CpuInfotech\RiderProjects\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
                   Write(item.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n                <div class=\"card-body\" style=\"font-family: Perpetua\">\r\n                    <article>\r\n                        ");
#nullable restore
#line 58 "C:\Users\CpuInfotech\RiderProjects\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
                   Write(item.Sadržaj);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </article>\r\n                </div>\r\n            </div>\r\n        </card>\r\n");
#nullable restore
#line 63 "C:\Users\CpuInfotech\RiderProjects\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    \r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Rad>> Html { get; private set; }
    }
}
#pragma warning restore 1591
