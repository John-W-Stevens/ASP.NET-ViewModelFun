#pragma checksum "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/ViewModelFun/Views/Home/User.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfe68361ceef577420cdfd679eedfa48d302cef8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_User), @"mvc.1.0.view", @"/Views/Home/User.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/User.cshtml", typeof(AspNetCore.Views_Home_User))]
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
#line 1 "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/ViewModelFun/Views/_ViewImports.cshtml"
using ViewModelFun;

#line default
#line hidden
#line 4 "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/ViewModelFun/Views/Home/User.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe68361ceef577420cdfd679eedfa48d302cef8", @"/Views/Home/User.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_User : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/ViewModelFun/Views/Home/User.cshtml"
  
    ViewData["Title"] = "Individual User Page";

#line default
#line hidden
            BeginContext(97, 84, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Here is a User!</h1>\r\n    <p>");
            EndContext();
            BeginContext(182, 15, false);
#line 9 "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/ViewModelFun/Views/Home/User.cshtml"
  Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(197, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(199, 14, false);
#line 9 "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/ViewModelFun/Views/Home/User.cshtml"
                   Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(213, 14, true);
            WriteLiteral("</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
