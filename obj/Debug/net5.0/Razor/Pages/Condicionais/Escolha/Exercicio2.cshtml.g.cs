#pragma checksum "C:\Users\fbcru\Downloads\Exercicios (5)\Pages\Condicionais\Escolha\Exercicio2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c2390f95e68691c645eb8876545316b1eabd6dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Exercicios.Pages.Condicionais.Escolha.Pages_Condicionais_Escolha_Exercicio2), @"mvc.1.0.razor-page", @"/Pages/Condicionais/Escolha/Exercicio2.cshtml")]
namespace Exercicios.Pages.Condicionais.Escolha
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
#line 1 "C:\Users\fbcru\Downloads\Exercicios (5)\Pages\_ViewImports.cshtml"
using Exercicios;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c2390f95e68691c645eb8876545316b1eabd6dc", @"/Pages/Condicionais/Escolha/Exercicio2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d781c43244cf55f64e4cbd9656915ce33337bec3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Condicionais_Escolha_Exercicio2 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-6 offset-md-3 col-sm-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\fbcru\Downloads\Exercicios (5)\Pages\Condicionais\Escolha\Exercicio2.cshtml"
  
  ViewData["Title"] = "LANCHONETE";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center display-4"">Estrutura Condicional - Switch</h1>
<h2 class=""text-center display-4"">Exercício 1</h2>

<p>
Lanchonete: O cardápio de uma lanchonete é o seguinte: </br>
<b>Código dos Produtos </b> </br>
Cachorro-quente 100 </br>
Bauru simples 101 </br>
Bauru com ovo 102  </br>
Hambúrguer 103 </br>
Cheeseburguer 104  </br>
Refrigerante 105 </br>
Informe o código e quantidade do produto desejado:
</p>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c2390f95e68691c645eb8876545316b1eabd6dc4462", async() => {
                WriteLiteral(@"
    <div class=""form-row"">
        <div class=""form-group col-md-6 col-sm-12"">
            <label for=""Produto"">Informe o código do produto: </label>
            <input type=""text"" class=""form-control"" id=""Produto"" name=""Produto"" required placeholder=""codigo do produto"">
        </div>
    <div class=""form-group col-md-6 col-sm-12"">
        <label for=""Quantidade"">Informe a quantidade do produto: </label>
        <input type=""text"" class=""form-control"" id=""Quantidade"" name=""Quantidade"" required placeholder=""Quantidade"">
    </div>
    </div>
    <button type=""submit"" class=""btn btn-primary"">Calcular</button>
    <h3 class=""mt-3 text-center"">");
#nullable restore
#line 33 "C:\Users\fbcru\Downloads\Exercicios (5)\Pages\Condicionais\Escolha\Exercicio2.cshtml"
                            Write(ViewData["Valor"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exercicios.Pages.Condicionais.Escolha.Exercicio2Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Exercicios.Pages.Condicionais.Escolha.Exercicio2Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Exercicios.Pages.Condicionais.Escolha.Exercicio2Model>)PageContext?.ViewData;
        public Exercicios.Pages.Condicionais.Escolha.Exercicio2Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591