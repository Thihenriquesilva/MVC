using System.Collections.Generic;
using RoletopMVC.Models;

namespace RoletopMVC.ViewModels
{
    public class PedidoViewModel : BaseViewModel
    {
        public List <Evento> Eventos {get;set;}
        public List <Servicos> Servicos{get;set;}
        public string NomeUsuario {get;set;}
        public Cliente Cliente {get;set;}
        public Pedido Pedido {get;set;}


        public PedidoViewModel(){
            this.Eventos = new List<Evento>();
            this.Servicos = new List<Servicos>();
            this.NomeUsuario = "Senhor(a)";
            this.Cliente = new Cliente();
            this.Pedido = new Pedido();
        }
    }
}