#pragma checksum "C:\Users\spenc\WebDev\NoteCapture\NoteCapture\Views\Auth\SuccessRegistration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5c70468a380422de245712203e390af319e309f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_SuccessRegistration), @"mvc.1.0.view", @"/Views/Auth/SuccessRegistration.cshtml")]
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
#line 1 "C:\Users\spenc\WebDev\NoteCapture\NoteCapture\Views\_ViewImports.cshtml"
using NoteCapture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\spenc\WebDev\NoteCapture\NoteCapture\Views\_ViewImports.cshtml"
using NoteCapture.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5c70468a380422de245712203e390af319e309f", @"/Views/Auth/SuccessRegistration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efe370d427852aa7ad47e69f0386dac02e4549a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_SuccessRegistration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\spenc\WebDev\NoteCapture\NoteCapture\Views\Auth\SuccessRegistration.cshtml"
  
    Layout = "_AuthLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Registration Success</h1>\r\n\r\n<p>\r\n    Please check your email for the verification action. Once you verify, you will be able to log into your account.\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
