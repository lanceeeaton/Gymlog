#pragma checksum "C:\Users\lance\Documents\Programs\Gymlog\Gymlog\Gymlog\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddcf1b927fedf639c30c57cecf9909c1e65d54a3"
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
#line 1 "C:\Users\lance\Documents\Programs\Gymlog\Gymlog\Gymlog\Views\_ViewImports.cshtml"
using Gymlog;

#line default
#line hidden
#line 2 "C:\Users\lance\Documents\Programs\Gymlog\Gymlog\Gymlog\Views\_ViewImports.cshtml"
using Gymlog.Models;

#line default
#line hidden
#line 1 "C:\Users\lance\Documents\Programs\Gymlog\Gymlog\Gymlog\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddcf1b927fedf639c30c57cecf9909c1e65d54a3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"221afc43e64317c4f1fa0904c7b9307c191dcbcb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(146, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\lance\Documents\Programs\Gymlog\Gymlog\Gymlog\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(193, 24, true);
            WriteLiteral("\r\n<h1>Gymlog-Home</h1>\r\n");
            EndContext();
#line 11 "C:\Users\lance\Documents\Programs\Gymlog\Gymlog\Gymlog\Views\Home\Index.cshtml"
 if (_signInManager.IsSignedIn(User))
 {

#line default
#line hidden
            BeginContext(260, 14, true);
            WriteLiteral("    <h2>Hello ");
            EndContext();
            BeginContext(275, 30, false);
#line 13 "C:\Users\lance\Documents\Programs\Gymlog\Gymlog\Gymlog\Views\Home\Index.cshtml"
         Write(_userManager.GetUserName(User));

#line default
#line hidden
            EndContext();
            BeginContext(305, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 14 "C:\Users\lance\Documents\Programs\Gymlog\Gymlog\Gymlog\Views\Home\Index.cshtml"
 }

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> _signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
