using System.Collections.Generic;
using RoletopMVC.Models;

namespace RoletopMVC.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public List<Pedido> Pedidos {get;set;}
        public uint PedidosAprovados {get;set;}
        public uint PedidosReprovados {get;set;}
        public uint PedidosPendente {get;set;}

        public DashboardViewModel(){
            this.Pedidos = new List<Pedido>();
        }
    }
}