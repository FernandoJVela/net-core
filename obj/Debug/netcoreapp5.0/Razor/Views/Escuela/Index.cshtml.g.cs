#pragma checksum "C:\Users\anima\platzi-asp-net-core\Views\Escuela\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f38c2780c05a706a2cf77d2039d00fac1876926"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
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
#line 1 "C:\Users\anima\platzi-asp-net-core\Views\_ViewImports.cshtml"
using platzi_asp_net_core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anima\platzi-asp-net-core\Views\_ViewImports.cshtml"
using platzi_asp_net_core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f38c2780c05a706a2cf77d2039d00fac1876926", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd9c994c8a9f955e5ac98e742f2356b1925f342d", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\anima\platzi-asp-net-core\Views\Escuela\Index.cshtml"
  
    ViewData["Title"] = "Información Escuela";
    Layout = "_Simple";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Escuela</h1>\r\n<h2>Nombre: ");
#nullable restore
#line 9 "C:\Users\anima\platzi-asp-net-core\Views\Escuela\Index.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>Tipo de Escuela: ");
#nullable restore
#line 10 "C:\Users\anima\platzi-asp-net-core\Views\Escuela\Index.cshtml"
                Write(Model.TipoEscuela);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<address>\r\n    <p>Dirección: ");
#nullable restore
#line 12 "C:\Users\anima\platzi-asp-net-core\Views\Escuela\Index.cshtml"
             Write(Model.Dirección);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>País: ");
#nullable restore
#line 13 "C:\Users\anima\platzi-asp-net-core\Views\Escuela\Index.cshtml"
        Write(Model.Pais);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Ciudad: ");
#nullable restore
#line 14 "C:\Users\anima\platzi-asp-net-core\Views\Escuela\Index.cshtml"
          Write(Model.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</address>\r\n<p>Año de fundación: ");
#nullable restore
#line 16 "C:\Users\anima\platzi-asp-net-core\Views\Escuela\Index.cshtml"
                Write(Model.AñoDeCreación);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela> Html { get; private set; }
    }
}
#pragma warning restore 1591
