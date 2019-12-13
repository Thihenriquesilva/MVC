using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Enums;
using RoletopMVC.Repositories;
using RoletopMVC.ViewModels;

namespace RoletopMVC.Controllers
{
    public class AdministradorController : AbstractController
    {
        PedidoRepository pedidoRepository = new PedidoRepository();

        public IActionResult Dashboard(){

            var ninguemLogado = string.IsNullOrEmpty(UsuarioTipoSession());
            if(!ninguemLogado && (uint) TiposDeUsuario.ADMINISTRADOR == uint.Parse(UsuarioTipoSession())){
                
                var pedidos = pedidoRepository.ObterTodos();
                DashboardViewModel dashboardViewModel = new DashboardViewModel();
                foreach (var pedido in pedidos)
                {
                    switch(pedido.Status){
                        case (uint) StatusPedido.APROVADO:
                            dashboardViewModel.PedidosAprovados ++;
                        break;
                        case (uint) StatusPedido.REPROVADO:
                            dashboardViewModel.PedidosReprovados ++;
                        break;
                        default:
                            dashboardViewModel.PedidosPendente ++;
                            dashboardViewModel.Pedidos.Add(pedido);
                        break;
                    }
                }
                dashboardViewModel.NomedaView = "Dashboard";
                dashboardViewModel.EmailUser = UsuarioEmailSession();

                return View(dashboardViewModel);

            }
            return View("Erro", new RespostaViewModel(){
                NomedaView = "Dashboard",
                Mensagem = "Acesso negado."
            });
        }
    }
}