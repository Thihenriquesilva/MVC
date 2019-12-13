#pragma checksum "C:\Users\47490086809\Desktop\MVC\RoletopMVC\Views\Administrador\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83505fc3208e1ed9956e86012d0dc5e21bf08c03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Dashboard), @"mvc.1.0.view", @"/Views/Administrador/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Dashboard.cshtml", typeof(AspNetCore.Views_Administrador_Dashboard))]
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
#line 1 "C:\Users\47490086809\Desktop\MVC\RoletopMVC\Views\_ViewImports.cshtml"
using RoletopMVC;

#line default
#line hidden
#line 2 "C:\Users\47490086809\Desktop\MVC\RoletopMVC\Views\_ViewImports.cshtml"
using RoletopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83505fc3208e1ed9956e86012d0dc5e21bf08c03", @"/Views/Administrador/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fcde6f443f8ee695eebee3c09673a46bc68798b", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoletopMVC.ViewModels.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 319, true);
            WriteLiteral(@"    <main>
        <h2 style=""text-align: center; font-size: 18px;"">Dashboard</h2>
        <section id=""status-pedidos"">
            <h3>Status dos pedidos</h3>
            <div id=""painel"">
                <div class=""box-status-pedidos aprovados"">
                    <h4>Aprovados</h4>
                    <p>");
            EndContext();
            BeginContext(369, 22, false);
#line 9 "C:\Users\47490086809\Desktop\MVC\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                  Write(Model.PedidosAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(391, 153, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"box-status-pedidos pendentes\">\r\n                    <h4>Pendentes</h4>\r\n                    <p>");
            EndContext();
            BeginContext(545, 21, false);
#line 13 "C:\Users\47490086809\Desktop\MVC\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                  Write(Model.PedidosPendente);

#line default
#line hidden
            EndContext();
            BeginContext(566, 155, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"box-status-pedidos reprovados\">\r\n                    <h4>Reprovados</h4>\r\n                    <p>");
            EndContext();
            BeginContext(722, 23, false);
#line 17 "C:\Users\47490086809\Desktop\MVC\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                  Write(Model.PedidosReprovados);

#line default
#line hidden
            EndContext();
            BeginContext(745, 1100, true);
            WriteLiteral(@"</p>
                </div>
            </div>
        </section>

        <section id=""lista-pedidos"">
            <h3>Lista de pedidos</h3>
            <table>
                <thead>
                    <tr>
                        <th rowspan=""2"">Nome</th>
                        <th rowspan=""2"">Email</th>
                        <th rowspan=""2"">Eventos</th>
                        <th rowspan=""2"">Serviços </th>
                        <th rowspan=""2"">Nº participantes</th>
                        <th rowspan=""2"">Forma do evento</th>
                        <th rowspan=""2"">Data do evento</th>
                        <th rowspan=""2"">Pagamento</th>
                        <th colspan=""2"" rowspan=""2"">Aprovar</th>
                    </tr>
                    <!-- <tr>
                        
                        <th></th>
                        <th></th>
                    </tr> -->
                </thead>
                <tfoot>
                    <tr>
                    ");
            WriteLiteral("    <td colspan=\"6\">\r\n                            <p>Pedidos atualizados em ");
            EndContext();
            BeginContext(1846, 12, false);
#line 46 "C:\Users\47490086809\Desktop\MVC\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                                                 Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(1858, 115, true);
            WriteLiteral("</p>\r\n                        </td>\r\n                    </tr>\r\n                </tfoot>\r\n                <tbody>\r\n");
            EndContext();
#line 51 "C:\Users\47490086809\Desktop\MVC\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                     foreach(var pedido in Model.Pedidos )
                    {

#line default
#line hidden
            BeginContext(2056, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(2119, 19, false);
#line 54 "C:\Users\47490086809\Desktop\MVC\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(pedido.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2138, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2178, 20, false);
#line 55 "C:\Users\47490086809\Desktop\MVC\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(pedido.Cliente.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2198, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2238, 18, false);
#line 56 "C:\Users\47490086809\Desktop\MVC\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(pedido.Evento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2256, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2296, 20, false);
#line 57 "C:\Users\47490086809\Desktop\MVC\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(pedido.Servicos.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2316, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2356, 26, false);
#line 58 "C:\Users\47490086809\Desktop\MVC\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(pedido.NumeroParticipantes);

#line default
#line hidden
            EndContext();
            BeginContext(2382, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2422, 24, false);
#line 59 "C:\Users\47490086809\Desktop\MVC\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(pedido.AgendamentoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2446, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2486, 20, false);
#line 60 "C:\Users\47490086809\Desktop\MVC\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(pedido.FormadoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2506, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2546, 21, false);
#line 61 "C:\Users\47490086809\Desktop\MVC\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                           Write(pedido.FormaPagamento);

#line default
#line hidden
            EndContext();
            BeginContext(2567, 71, true);
            WriteLiteral("</td>\r\n                            \r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2638, "\'", 2700, 1);
#line 63 "C:\Users\47490086809\Desktop\MVC\RoletopMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2645, Url.Action("Aprovar", "Pedido", new {id = @pedido.Id}), 2645, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2701, 74, true);
            WriteLiteral("><i class=\"fas fa-check\"></i></a></td>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2775, "\'", 2838, 1);
#line 64 "C:\Users\47490086809\Desktop\MVC\RoletopMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2782, Url.Action("Reprovar", "Pedido", new {id = @pedido.Id}), 2782, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2839, 71, true);
            WriteLiteral("><i class=\"fas fa-times\"></i></a></td>\r\n                        </tr>\r\n");
            EndContext();
#line 66 "C:\Users\47490086809\Desktop\MVC\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                    }

#line default
#line hidden
            BeginContext(2933, 81, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </section>\r\n\r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoletopMVC.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
