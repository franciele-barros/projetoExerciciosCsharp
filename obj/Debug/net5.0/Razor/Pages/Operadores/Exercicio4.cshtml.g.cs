#pragma checksum "C:\Users\fbcru\Downloads\Exercicios (5)\Pages\Operadores\Exercicio4.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a9605987278fc248048caa523a3e4630a915891"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Exercicios.Pages.Operadores.Pages_Operadores_Exercicio4), @"mvc.1.0.razor-page", @"/Pages/Operadores/Exercicio4.cshtml")]
namespace Exercicios.Pages.Operadores
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a9605987278fc248048caa523a3e4630a915891", @"/Pages/Operadores/Exercicio4.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d781c43244cf55f64e4cbd9656915ce33337bec3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Operadores_Exercicio4 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\fbcru\Downloads\Exercicios (5)\Pages\Operadores\Exercicio4.cshtml"
  
    ViewData["Title"] = "OP. Mat - Exerc.04";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center display-4""> Operadores Matemáticos</h1>
<h2 class=""text-center display-4""> Exercício 4</h2>
<p>
    Considerando que para um consórcio, sabe-se o número total de prestações, a quantidade de prestações pagas
    e o valor atual da prestação, escreva um algoritmo que determine o total pago pelo consorciado e o saldo
    devedor. 
</p>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a9605987278fc248048caa523a3e4630a9158913952", async() => {
                WriteLiteral(@"
    <div class=""form-group"">
        <label for=""Nome"">Digite o Número total de prestações</label>
        <input type=""text"" class=""form-control"" id=""nr_prestacoes"" name=""nr_prestacoes"" placeholder=""Informe nº de prestações"" required>
    </div>
        <div class=""form-group"">
        <label for=""Nota1""> Digite a quantidade de prestações pagas</label>
        <input type=""text"" class=""form-control"" nr_pagas=""b"" name=""nr_pagas"" placeholder=""Quantidade de prestacoes pagas"">
    </div>
           <div class=""form-group"">
        <label for=""Nota1""> Valor atual da prestacao</label>
        <input type=""text"" class=""form-control"" id=""valor_prestacao"" name=""valor_prestacao"" placeholder=""Informe o Valor da prestacao"">
    </div>
    <button type=""submit"" class=""btn btn-primary""> Calcular</button>
    <p class=""mt-3 text-center"">");
#nullable restore
#line 28 "C:\Users\fbcru\Downloads\Exercicios (5)\Pages\Operadores\Exercicio4.cshtml"
                           Write(ViewData["Resultado"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p class=\"mt-3 text-center\">");
#nullable restore
#line 29 "C:\Users\fbcru\Downloads\Exercicios (5)\Pages\Operadores\Exercicio4.cshtml"
                           Write(ViewData["Resultado1"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exercicios.Pages.Operadores.Exercicio4Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Exercicios.Pages.Operadores.Exercicio4Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Exercicios.Pages.Operadores.Exercicio4Model>)PageContext?.ViewData;
        public Exercicios.Pages.Operadores.Exercicio4Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
