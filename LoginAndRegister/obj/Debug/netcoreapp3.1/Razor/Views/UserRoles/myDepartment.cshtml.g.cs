#pragma checksum "C:\Users\windows\Desktop\nadine\LoginAndRegister\LoginAndRegister\Views\UserRoles\myDepartment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7698bf4e12f8aeaed2b8bdb9c6cfe8db4bd780d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserRoles_myDepartment), @"mvc.1.0.view", @"/Views/UserRoles/myDepartment.cshtml")]
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
#line 1 "C:\Users\windows\Desktop\nadine\LoginAndRegister\LoginAndRegister\Views\_ViewImports.cshtml"
using LoginAndRegister;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\windows\Desktop\nadine\LoginAndRegister\LoginAndRegister\Views\_ViewImports.cshtml"
using LoginAndRegister.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7698bf4e12f8aeaed2b8bdb9c6cfe8db4bd780d9", @"/Views/UserRoles/myDepartment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40f47f04fab4e0a377030f647bfe69804f9bc976", @"/Views/_ViewImports.cshtml")]
    public class Views_UserRoles_myDepartment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\windows\Desktop\nadine\LoginAndRegister\LoginAndRegister\Views\UserRoles\myDepartment.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>My Department</h1>\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>First Name</th>\r\n            <th>Email</th>\r\n            <th>Roles</th>\r\n        \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\windows\Desktop\nadine\LoginAndRegister\LoginAndRegister\Views\UserRoles\myDepartment.cshtml"
         foreach (var user in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\windows\Desktop\nadine\LoginAndRegister\LoginAndRegister\Views\UserRoles\myDepartment.cshtml"
           Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\windows\Desktop\nadine\LoginAndRegister\LoginAndRegister\Views\UserRoles\myDepartment.cshtml"
           Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 22 "C:\Users\windows\Desktop\nadine\LoginAndRegister\LoginAndRegister\Views\UserRoles\myDepartment.cshtml"
             foreach (var role in @user.Roles){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 23 "C:\Users\windows\Desktop\nadine\LoginAndRegister\LoginAndRegister\Views\UserRoles\myDepartment.cshtml"
           Write(role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>");
#nullable restore
#line 23 "C:\Users\windows\Desktop\nadine\LoginAndRegister\LoginAndRegister\Views\UserRoles\myDepartment.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("          \r\n        </tr>\r\n");
#nullable restore
#line 26 "C:\Users\windows\Desktop\nadine\LoginAndRegister\LoginAndRegister\Views\UserRoles\myDepartment.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
