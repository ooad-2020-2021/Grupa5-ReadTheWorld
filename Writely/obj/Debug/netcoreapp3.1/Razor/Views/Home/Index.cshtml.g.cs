#pragma checksum "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed267c814d7bd48a691e2519d9957030dbcfa2a3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5394ab40db42e66fbec1c0105d508b1418d9ee66", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d62dacfa5f250d85f49326da7207ac7f881b0c83", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Rad>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Rad", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        background-repeat: no-repeat;
        background-attachment: fixed;
        font-family: Perpetua;
    }
    .container {
        display: flex;
        flex-direction: row;
        flex-wrap: wrap;
        justify-content: space-around;
        align-items: baseline;
        align-content: flex-start;
        
       
    }
    .customcard {
        width: 100%;
        padding-bottom: 75%;
    
    }
    .cardcontent {
        position: absolute;
        width: 100%;
    }
    card {
        margin: 20px;
        width: 100%;
        padding-bottom: 15%;
        background-color: rgba(219,199,175,0.59);
        border-radius: 12px;
        position: relative;
        flex-grow: 0;
    }
    .card {
            margin: 20px;
            width: 100%;
            padding-bottom: 25%;
            backg");
            WriteLiteral(@"round-color: rgba(219,199,175,0.59);
            border-radius: 12px;
            position: relative;
            flex-grow: 0;
        }
    img {
        max-width: 100%;
        padding-bottom: 75%;
    }
    .custom_container {
        display: flex;
        flex-direction: row;
        flex-wrap: wrap;
        justify-content: center;
        align-content: space-around;
        grid-template-columns: 1fr 1fr 1fr;
        grid-template-rows: 25%;
        padding: 40px;
        flex-grow: 1;
    }
    .grid-container {
            display: grid;
            grid-gap: 16px;
            grid-template-columns: repeat(3, 1fr);
            margin-bottom: 300px;
        }
    .topnav {
        overflow: hidden;
        background-color: burlywood;
    }
        /* Style the search box inside the navigation bar */
        .topnav input[type=text] {
            float: left;
            padding: 6px;
            border: none;
            margin-top: 4px;
            margin-botto");
            WriteLiteral("m: 4px;\r\n            margin-left: 4px;\r\n            font-size: 17px;\r\n        }\r\n</style>\r\n\r\n");
            WriteLiteral("\r\n<div class=\"grid-container\">\r\n");
#nullable restore
#line 77 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {
    

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2438, "\"", 2534, 2);
#nullable restore
#line 80 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
WriteAttributeValue("", 1921, "window.location.href='" + @Url.Action("Details", "Rad", new {id = item.id}) + "'", 1921, 85, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2533, ";", 2533, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            \r\n");
#nullable restore
#line 82 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
             if (item.id % 5 == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card-header\" style=\"background-color: rgba(161,87,82,0.98); size: A3\"></div>\r\n");
#nullable restore
#line 85 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
             if (item.id % 5 == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card-header\" style=\"background-color: rgba(99,144,131,0.98)\"></div>\r\n");
#nullable restore
#line 90 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
             if (item.id % 5 == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card-header\" style=\"background-color: rgba(144,108,134,0.98)\"></div>\r\n");
#nullable restore
#line 94 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
             if (item.id % 5 == 3)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card-header\" style=\"background-color: rgba(95,104,144,0.98)\"></div>\r\n");
#nullable restore
#line 98 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
             if (item.id % 5 == 4)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card-header\" style=\"background-color: rgba(93,144,105,0.98)\"></div>\r\n");
#nullable restore
#line 102 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card-body\">\r\n                <h2 style=\"font-weight: bold\">");
#nullable restore
#line 104 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
                                         Write(item.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 105 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
                 if (item.Sadr??aj.Length > 200)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p style=\"margin-top: 10px; font-size: 18px\">");
#nullable restore
#line 107 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
                                                            Write(item.Sadr??aj.Substring(0,200));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed267c814d7bd48a691e2519d9957030dbcfa2a310099", async() => {
                WriteLiteral("...");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
                                                                       WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </p>\r\n");
#nullable restore
#line 110 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
                 if  (item.Sadr??aj.Length <= 200){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p style=\"margin-top: 10px; font-size: 18px\">");
#nullable restore
#line 112 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
                                                            Write(item.Sadr??aj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 113 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n                \r\n            </div>\r\n\r\n\r\n        </div>\r\n");
#nullable restore
#line 120 "C:\Users\Hp\source\repos\Grupa5-ReadTheWorld\Writely\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Rad>> Html { get; private set; }
    }
}
#pragma warning restore 1591
