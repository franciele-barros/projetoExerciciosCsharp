#pragma checksum "C:\Users\fbcru\Downloads\Exercicios (5)\Pages\Operadores\Exercicio3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9323ae076ea27e602d648c47b90a352af6133d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Exercicios.Pages.Operadores.Pages_Operadores_Exercicio3), @"mvc.1.0.razor-page", @"/Pages/Operadores/Exercicio3.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9323ae076ea27e602d648c47b90a352af6133d5", @"/Pages/Operadores/Exercicio3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d781c43244cf55f64e4cbd9656915ce33337bec3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Operadores_Exercicio3 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\fbcru\Downloads\Exercicios (5)\Pages\Operadores\Exercicio3.cshtml"
  
    ViewData["Title"] = "OP. Mat - Exerc.03";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center display-4""> Operadores Matemáticos</h1>
<h2 class=""text-center display-4""> Exercício 3</h2>
<p>
    O custo ao consumidor de um carro novo, é a soma do custo de fábrica com a percentagem do revendedor e
    com o custo dos impostos (aplicados ao custo de fábrica). Supondo que a percentagem do revendedor seja de
    25% do custo de fábrica e que os impostos custam 45 % do custo de fábrica, faça um algoritmo que leia o valor
    de custo de fábrica e determine o preço final do automóvel (custo ao consumidor). 
</p>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9323ae076ea27e602d648c47b90a352af6133d54137", async() => {
                WriteLiteral(@"
    <div class=""form-group"">
        <label for=""Nome""> Informe o Valor do custo de fábrica do automóvel</label>
        <input type=""text"" class=""form-control"" id=""custo"" name=""custo"" placeholder=""Valor do Custo de Fábrica"" required>
    </div>
    <button type=""submit"" class=""btn btn-primary""> Calcular o Custo final ao consumidor</button>
    <p class=""mt-3 text-center"">");
#nullable restore
#line 21 "C:\Users\fbcru\Downloads\Exercicios (5)\Pages\Operadores\Exercicio3.cshtml"
                           Write(ViewData["Resultado"]);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exercicios.Pages.Operadores.Exercicio3Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Exercicios.Pages.Operadores.Exercicio3Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Exercicios.Pages.Operadores.Exercicio3Model>)PageContext?.ViewData;
        public Exercicios.Pages.Operadores.Exercicio3Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
