#pragma checksum "C:\Users\micha\source\repos\StockExchange\stock Exchange.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c960faebdfa183e668ebe7c8d761b348e6bb3f6"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c960faebdfa183e668ebe7c8d761b348e6bb3f6", @"/Views/Home/Index.cshtml")]
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
            BeginContext(67, 55, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        ");
            EndContext();
            BeginContext(123, 65, false);
#line 7 "C:\Users\micha\source\repos\StockExchange\stock Exchange.Web\Views\Home\Index.cshtml"
   Write(Html.Partial("~/Views/ActionRates/Index.cshtml",Model.StockRates));

#line default
#line hidden
            EndContext();
            BeginContext(188, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 9 "C:\Users\micha\source\repos\StockExchange\stock Exchange.Web\Views\Home\Index.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
            BeginContext(250, 44, true);
            WriteLiteral("        <div class=\"col-md-6\">\r\n            ");
            EndContext();
            BeginContext(295, 70, false);
#line 12 "C:\Users\micha\source\repos\StockExchange\stock Exchange.Web\Views\Home\Index.cshtml"
       Write(Html.Partial("~/Views/UserWallet/UserWallet.cshtml", Model.UserWallet));

#line default
#line hidden
            EndContext();
            BeginContext(365, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 14 "C:\Users\micha\source\repos\StockExchange\stock Exchange.Web\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(390, 8, true);
            WriteLiteral("</div>\r\n");
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
