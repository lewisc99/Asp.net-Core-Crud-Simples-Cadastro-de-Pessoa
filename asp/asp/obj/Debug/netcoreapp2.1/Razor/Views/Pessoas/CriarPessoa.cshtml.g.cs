#pragma checksum "C:\Users\Pichau\Desktop\crud\asp\asp\Views\Pessoas\CriarPessoa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e6bd99f047efe333474ced7ec6fe37221d26843"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoas_CriarPessoa), @"mvc.1.0.view", @"/Views/Pessoas/CriarPessoa.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pessoas/CriarPessoa.cshtml", typeof(AspNetCore.Views_Pessoas_CriarPessoa))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e6bd99f047efe333474ced7ec6fe37221d26843", @"/Views/Pessoas/CriarPessoa.cshtml")]
    public class Views_Pessoas_CriarPessoa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<crud.Models.Pessoa>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Pichau\Desktop\crud\asp\asp\Views\Pessoas\CriarPessoa.cshtml"
  
    ViewData["Title"] = "CriarPessoa";

#line default
#line hidden
#line 6 "C:\Users\Pichau\Desktop\crud\asp\asp\Views\Pessoas\CriarPessoa.cshtml"
  
    //Layout  = "_Layout";
    Layout = "/Views/Shared/_Layout.cshtml";


#line default
#line hidden
            BeginContext(159, 420, true);
            WriteLiteral(@"
<h2>Criar Pessoa</h2>

<h4>Pessoa</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label for=""nome"" class=""form-label"">Nome</label>
                <input type=""text"" name=""name"" class=""form-control"" id=""nome"" placeholder=""Digite um nome""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 579, "\"", 598, 1);
#line 22 "C:\Users\Pichau\Desktop\crud\asp\asp\Views\Pessoas\CriarPessoa.cshtml"
WriteAttributeValue("", 587, Model.Name, 587, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(599, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(619, 82, false);
#line 23 "C:\Users\Pichau\Desktop\crud\asp\asp\Views\Pessoas\CriarPessoa.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(701, 260, true);
            WriteLiteral(@"

            </div>
            <div class=""form-group"">
                <label for=""Sobrenome"" class=""form-label"">Sobrenome</label>
                <input type=""text"" name=""sobrenome"" class=""form-control"" id=""Sobrenome"" placeholder=""Digite um Sobrenome""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 961, "\"", 985, 1);
#line 28 "C:\Users\Pichau\Desktop\crud\asp\asp\Views\Pessoas\CriarPessoa.cshtml"
WriteAttributeValue("", 969, Model.SobreNome, 969, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(986, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(1006, 87, false);
#line 29 "C:\Users\Pichau\Desktop\crud\asp\asp\Views\Pessoas\CriarPessoa.cshtml"
           Write(Html.ValidationMessageFor(model => model.SobreNome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 230, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"CPF\" class=\"form-label\">CPF</label>\r\n                <input type=\"text\" name=\"cpf\" class=\"form-control\" id=\"CPF\" placeholder=\"Digite um CPF\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1323, "\"", 1341, 1);
#line 34 "C:\Users\Pichau\Desktop\crud\asp\asp\Views\Pessoas\CriarPessoa.cshtml"
WriteAttributeValue("", 1331, Model.CPF, 1331, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1342, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(1362, 81, false);
#line 35 "C:\Users\Pichau\Desktop\crud\asp\asp\Views\Pessoas\CriarPessoa.cshtml"
           Write(Html.ValidationMessageFor(model => model.CPF, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1443, 239, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"idade\" class=\"form-label\">Idade</label>\r\n                <input type=\"text\" name=\"idade\" class=\"form-control\" id=\"idade\" placeholder=\"Digite uma Idade\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1682, "\"", 1702, 1);
#line 39 "C:\Users\Pichau\Desktop\crud\asp\asp\Views\Pessoas\CriarPessoa.cshtml"
WriteAttributeValue("", 1690, Model.Idade, 1690, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1703, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(1723, 83, false);
#line 40 "C:\Users\Pichau\Desktop\crud\asp\asp\Views\Pessoas\CriarPessoa.cshtml"
           Write(Html.ValidationMessageFor(model => model.Idade, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1806, 253, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"Telefone\" class=\"form-label\">Telefone</label>\r\n                <input type=\"text\" name=\"telefone\" class=\"form-control\" id=\"Telefone\" placeholder=\"Digite um Telefone\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2059, "\"", 2082, 1);
#line 44 "C:\Users\Pichau\Desktop\crud\asp\asp\Views\Pessoas\CriarPessoa.cshtml"
WriteAttributeValue("", 2067, Model.Telefone, 2067, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2083, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(2103, 86, false);
#line 45 "C:\Users\Pichau\Desktop\crud\asp\asp\Views\Pessoas\CriarPessoa.cshtml"
           Write(Html.ValidationMessageFor(model => model.Telefone, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2189, 266, true);
            WriteLiteral(@"

            </div>
            <div class=""form-group"">
                <button type=""submit"" class=""btn btn-dark"">Salvar</button>
            </div>
        </form>
    </div>
</div>

<div>
    <a  href=""/pessoas/index"">Voltar a lista</a>
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
