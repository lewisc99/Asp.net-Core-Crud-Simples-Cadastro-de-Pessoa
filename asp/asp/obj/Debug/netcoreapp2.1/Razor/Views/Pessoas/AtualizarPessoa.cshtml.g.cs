#pragma checksum "C:\Users\Pichau\Desktop\crud\asp\asp\Views\Pessoas\AtualizarPessoa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a81aca1bdbe499230508e529f5ed1ce66517570"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoas_AtualizarPessoa), @"mvc.1.0.view", @"/Views/Pessoas/AtualizarPessoa.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pessoas/AtualizarPessoa.cshtml", typeof(AspNetCore.Views_Pessoas_AtualizarPessoa))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a81aca1bdbe499230508e529f5ed1ce66517570", @"/Views/Pessoas/AtualizarPessoa.cshtml")]
    public class Views_Pessoas_AtualizarPessoa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<crud.Models.Pessoa>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Pichau\Desktop\crud\asp\asp\Views\Pessoas\AtualizarPessoa.cshtml"
  
    ViewData["Title"] = "AtualizarPessoa";

#line default
#line hidden
#line 6 "C:\Users\Pichau\Desktop\crud\asp\asp\Views\Pessoas\AtualizarPessoa.cshtml"
  
    //Layout  = "_Layout";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(140, 1880, true);
            WriteLiteral(@"
<h2>AtualizarPessoa</h2>

<h4>Pessoa</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""AtualizarPessoa"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SobreNome"" class=""control-label""></label>
                <input asp-for=""SobreNome"" class=""form-control"" />
                <span asp-validation-for=""SobreNome"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CPF"" class=""control-label""></label>
                <input asp-for=""CPF"" class=""form-control"" />
                <span asp-v");
            WriteLiteral(@"alidation-for=""CPF"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Idade"" class=""control-label""></label>
                <input asp-for=""Idade"" class=""form-control"" />
                <span asp-validation-for=""Idade"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Telefone"" class=""control-label""></label>
                <input asp-for=""Telefone"" class=""form-control"" />
                <span asp-validation-for=""Telefone"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<crud.Models.Pessoa> Html { get; private set; }
    }
}
#pragma warning restore 1591