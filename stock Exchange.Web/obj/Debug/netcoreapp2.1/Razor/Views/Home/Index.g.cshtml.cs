#pragma checksum "C:\Users\micha\source\repos\StockExchange\stock Exchange.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62086b3d25c340e888dc51efb7fadc8891182172"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\micha\source\repos\StockExchange\stock Exchange.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\micha\source\repos\StockExchange\stock Exchange.Web\Views\_ViewImports.cshtml"
using StockExchange.Web;

#line default
#line hidden
#line 3 "C:\Users\micha\source\repos\StockExchange\stock Exchange.Web\Views\_ViewImports.cshtml"
using StockExchange.Web.Models;

#line default
#line hidden
#line 4 "C:\Users\micha\source\repos\StockExchange\stock Exchange.Web\Views\_ViewImports.cshtml"
using StockExchange.Web.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\micha\source\repos\StockExchange\stock Exchange.Web\Views\_ViewImports.cshtml"
using StockExchange.Web.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62086b3d25c340e888dc51efb7fadc8891182172", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9281c2e084a3d21f60734ad0d1c2186fa273e4c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\micha\source\repos\StockExchange\stock Exchange.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(67, 23, true);
            WriteLiteral("<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(91, 52, false);
#line 6 "C:\Users\micha\source\repos\StockExchange\stock Exchange.Web\Views\Home\Index.cshtml"
Write(Html.Hidden("IsAuth", User.Identity.IsAuthenticated));

#line default
#line hidden
            EndContext();
            BeginContext(143, 169, true);
            WriteLiteral("\r\n    <div class=\"col-md-6\">\r\n        <div id=\"StockResults\"></div>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <div id=\"WalletResults\"></div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
