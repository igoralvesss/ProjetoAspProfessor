#pragma checksum "C:\Users\ialvesdesou2\OneDrive - DXC Production\Desktop\Projeto Asp.net\CadastroProfessor\CadastroProfessor\Controllers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dd9dbdb2789eb25aba612af3904896932722769"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Controllers_Index), @"mvc.1.0.view", @"/Controllers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Controllers/Index.cshtml", typeof(AspNetCore.Controllers_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dd9dbdb2789eb25aba612af3904896932722769", @"/Controllers/Index.cshtml")]
    public class Controllers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CadastroProfessor.Models.Professor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ialvesdesou2\OneDrive - DXC Production\Desktop\Projeto Asp.net\CadastroProfessor\CadastroProfessor\Controllers\Index.cshtml"
  
	ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 167, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n\t<a asp-action=\"CriarProfessor\" class=\"btn btn-success\">Criar novo Professor</a>\r\n</p>\r\n<table class=\"table\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(264, 40, false);
#line 16 "C:\Users\ialvesdesou2\OneDrive - DXC Production\Desktop\Projeto Asp.net\CadastroProfessor\CadastroProfessor\Controllers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(304, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(330, 39, false);
#line 19 "C:\Users\ialvesdesou2\OneDrive - DXC Production\Desktop\Projeto Asp.net\CadastroProfessor\CadastroProfessor\Controllers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(369, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(395, 46, false);
#line 22 "C:\Users\ialvesdesou2\OneDrive - DXC Production\Desktop\Projeto Asp.net\CadastroProfessor\CadastroProfessor\Controllers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Disciplina));

#line default
#line hidden
            EndContext();
            BeginContext(441, 56, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th></th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
            EndContext();
#line 28 "C:\Users\ialvesdesou2\OneDrive - DXC Production\Desktop\Projeto Asp.net\CadastroProfessor\CadastroProfessor\Controllers\Index.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
            BeginContext(534, 24, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(559, 39, false);
#line 32 "C:\Users\ialvesdesou2\OneDrive - DXC Production\Desktop\Projeto Asp.net\CadastroProfessor\CadastroProfessor\Controllers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(598, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(627, 38, false);
#line 35 "C:\Users\ialvesdesou2\OneDrive - DXC Production\Desktop\Projeto Asp.net\CadastroProfessor\CadastroProfessor\Controllers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cpf));

#line default
#line hidden
            EndContext();
            BeginContext(665, 28, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(694, 45, false);
#line 38 "C:\Users\ialvesdesou2\OneDrive - DXC Production\Desktop\Projeto Asp.net\CadastroProfessor\CadastroProfessor\Controllers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Disciplina));

#line default
#line hidden
            EndContext();
            BeginContext(739, 51, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 44 "C:\Users\ialvesdesou2\OneDrive - DXC Production\Desktop\Projeto Asp.net\CadastroProfessor\CadastroProfessor\Controllers\Index.cshtml"
		}

#line default
#line hidden
            BeginContext(795, 19, true);
            WriteLiteral("\t</tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CadastroProfessor.Models.Professor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
