#pragma checksum "D:\.net\college mis system.web\Views\faculty\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9578c02455ffed5bd454be5e911939a44a1fe0bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_faculty_Index), @"mvc.1.0.view", @"/Views/faculty/Index.cshtml")]
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
#line 1 "D:\.net\college mis system.web\Views\_ViewImports.cshtml"
using college_mis_system.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.net\college mis system.web\Views\_ViewImports.cshtml"
using college_mis_system.web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9578c02455ffed5bd454be5e911939a44a1fe0bd", @"/Views/faculty/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8373c236e2885df42659b2dec3cd660f73ffad1e", @"/Views/_ViewImports.cshtml")]
    public class Views_faculty_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FacultyModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Faculties</h1>\r\n\r\n<table class=\" table table-striped\">\r\n     <thead>\r\n         <tr>\r\n             \r\n           <th>Name</th>\r\n           <th>Seats</th>\r\n           <th>Fee</th>\r\n\r\n         </tr>\r\n     </thead>\r\n     <tbody>\r\n");
#nullable restore
#line 16 "D:\.net\college mis system.web\Views\faculty\Index.cshtml"
          foreach(FacultyModel f in Model)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <tr>\r\n             <td>");
#nullable restore
#line 19 "D:\.net\college mis system.web\Views\faculty\Index.cshtml"
            Write(f.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 20 "D:\.net\college mis system.web\Views\faculty\Index.cshtml"
            Write(f.Seats);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 21 "D:\.net\college mis system.web\Views\faculty\Index.cshtml"
            Write(f.TotalFee);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         </tr>\r\n");
#nullable restore
#line 23 "D:\.net\college mis system.web\Views\faculty\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("     </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FacultyModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
