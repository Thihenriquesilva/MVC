#pragma checksum "E:\RoletopMVC\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8872c1e2bb905c261c3dad6077af3c9fd982e4f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Index), @"mvc.1.0.view", @"/Views/Pedido/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/Index.cshtml", typeof(AspNetCore.Views_Pedido_Index))]
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
#line 1 "E:\RoletopMVC\Views\_ViewImports.cshtml"
using RoletopMVC;

#line default
#line hidden
#line 2 "E:\RoletopMVC\Views\_ViewImports.cshtml"
using RoletopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8872c1e2bb905c261c3dad6077af3c9fd982e4f4", @"/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fcde6f443f8ee695eebee3c09673a46bc68798b", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoletopMVC.ViewModels.PedidoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 126, true);
            WriteLiteral("    <main>\r\n        <section class=\"formulario\">\r\n\r\n            <h2 style=\"text-align: center; font-size: 18px;\" > Por favor, ");
            EndContext();
            BeginContext(173, 17, false);
#line 5 "E:\RoletopMVC\Views\Pedido\Index.cshtml"
                                                                     Write(Model.NomeUsuario);

#line default
#line hidden
            EndContext();
            BeginContext(190, 39, true);
            WriteLiteral("! escolha sua opções</h2>\r\n            ");
            EndContext();
            BeginContext(229, 3181, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8872c1e2bb905c261c3dad6077af3c9fd982e4f44483", async() => {
                BeginContext(292, 153, true);
                WriteLiteral("\r\n                <div>\r\n                    <label for=\"nome\">Nome</label>\r\n                    <input id=\"nome\"type=\"text\" maxlength=\"20\" minlength=\"3\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 445, "\"", 472, 1);
#line 9 "E:\RoletopMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 453, Model.Cliente.Nome, 453, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(473, 216, true);
                WriteLiteral(" name=\"nome\"/>\r\n                </div>\r\n                <div>\r\n                    <label for=\"telefone\">Telefone para contato</label>\r\n                    <input id=\"telefone\" type=\"text\" placeholder=\"11 12345 6789\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 689, "\"", 720, 1);
#line 13 "E:\RoletopMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 697, Model.Cliente.Telefone, 697, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(721, 164, true);
                WriteLiteral(" name=\"telefone\"/>\r\n                </div>\r\n                <div>\r\n                    <label for=\"cpf\">CPF</label>\r\n                    <input id=\"cpf\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 885, "\"", 911, 1);
#line 17 "E:\RoletopMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 893, Model.Cliente.CPF, 893, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(912, 198, true);
                WriteLiteral(" name=\"cpf\"/>\r\n                </div>\r\n                <div>\r\n                    <label for=\"email\">E-mail</label>\r\n                    <input id=\"email\" type=\"text\" placeholder=\"example@email.com\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1110, "\"", 1138, 1);
#line 21 "E:\RoletopMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 1118, Model.Cliente.Email, 1118, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1139, 220, true);
                WriteLiteral(" name=\"email\"/>\r\n                </div>\r\n                <div>\r\n                    <label for=\"eventos\">Tipo de evento</label>\r\n                    <select id=\"eventos\" name=\"eventos\" required>\r\n                        ");
                EndContext();
                BeginContext(1359, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8872c1e2bb905c261c3dad6077af3c9fd982e4f47428", async() => {
                    BeginContext(1392, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("select", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1410, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 27 "E:\RoletopMVC\Views\Pedido\Index.cshtml"
                         foreach( var eventos in @Model.Eventos){

#line default
#line hidden
                BeginContext(1479, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1507, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8872c1e2bb905c261c3dad6077af3c9fd982e4f49830", async() => {
                    BeginContext(1536, 12, false);
#line 28 "E:\RoletopMVC\Views\Pedido\Index.cshtml"
                                                   Write(eventos.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(1548, 32, true);
                    WriteLiteral("\r\n\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 28 "E:\RoletopMVC\Views\Pedido\Index.cshtml"
                              WriteLiteral(eventos.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1589, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 31 "E:\RoletopMVC\Views\Pedido\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(1618, 247, true);
                WriteLiteral("                    </select>\r\n                </div>\r\n                <div>\r\n                    <label for=\"tipo-de-evento\">Serviços desejados</label>\r\n                    <select id=\"servicos\" name=\"servicos\" required>\r\n                        ");
                EndContext();
                BeginContext(1865, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8872c1e2bb905c261c3dad6077af3c9fd982e4f412446", async() => {
                    BeginContext(1898, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("select", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1916, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 38 "E:\RoletopMVC\Views\Pedido\Index.cshtml"
                         foreach( var servicos in @Model.Servicos){

#line default
#line hidden
                BeginContext(1987, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(2015, 116, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8872c1e2bb905c261c3dad6077af3c9fd982e4f414852", async() => {
                    BeginContext(2045, 13, false);
#line 39 "E:\RoletopMVC\Views\Pedido\Index.cshtml"
                                                    Write(servicos.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(2058, 64, true);
                    WriteLiteral("\r\n                                \r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 39 "E:\RoletopMVC\Views\Pedido\Index.cshtml"
                              WriteLiteral(servicos.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2131, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 42 "E:\RoletopMVC\Views\Pedido\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(2160, 193, true);
                WriteLiteral("                    </select>\r\n                </div>\r\n                <div>\r\n                    <label for=\"pessoas\">Nº de pessoas</label>\r\n                    <input id=\"pessoas\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2353, "\"", 2394, 1);
#line 47 "E:\RoletopMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 2361, Model.Pedido.NumeroParticipantes, 2361, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2395, 208, true);
                WriteLiteral(" name=\"pessoas\" />\r\n                </div>\r\n                <div>\r\n                    <label for=\"data\">Data do evento</label>\r\n                    <input id=\"agenda-evento\" type=\"date\"  name=\"agenda-evento\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2603, "\"", 2642, 1);
#line 51 "E:\RoletopMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 2611, Model.Pedido.AgendamentoEvento, 2611, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2643, 211, true);
                WriteLiteral("/>\r\n                </div>\r\n                <div>\r\n                    <label for=\"forma-evento\">Forma do evento</label>\r\n                    <input id=\"forma-evento\" type=\"text\" placeholder=\"Publico ou Privado\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2854, "\"", 2889, 1);
#line 55 "E:\RoletopMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 2862, Model.Pedido.FormadoEvento, 2862, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2890, 238, true);
                WriteLiteral(" name=\"forma-evento\">\r\n                </div>\r\n                <div>\r\n                    <label for=\"forma-pagamento\">Forma do pagamento</label>\r\n                    <input id=\"forma-pagamento\" type=\"text\" placeholder=\"Credito ou Debito\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3128, "\"", 3164, 1);
#line 59 "E:\RoletopMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 3136, Model.Pedido.FormaPagamento, 3136, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3165, 238, true);
                WriteLiteral(" name=\"forma-pagamento\">\r\n                </div>\r\n                <div class=\"enter\">\r\n                <input type=\"submit\" value=\"Aceitar\" />\r\n                <input type=\"submit\" value=\"Cancelar\" />\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 6 "E:\RoletopMVC\Views\Pedido\Index.cshtml"
AddHtmlAttributeValue("", 257, Url.Action("Registrar","Pedido"), 257, 33, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3410, 35, true);
            WriteLiteral("\r\n\r\n        </section>\r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoletopMVC.ViewModels.PedidoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591