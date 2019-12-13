using System;
using RoletopMVC.Enums;

namespace RoletopMVC.Models
{
    public class Pedido
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}
        public Evento Evento {get;set;}
        public Servicos Servicos {get;set;}
        public string FormaPagamento {get;set;}
        public string FormadoEvento {get;set;}
        public uint NumeroParticipantes {get;set;}
        public DateTime DataDoEvento {get;set;}

        public DateTime AgendamentoEvento {get;set;}

        public uint Status {get;set;}

        public Pedido(){
            this.Cliente = new Cliente();
            this.Evento = new Evento();
            this.Servicos = new Servicos();
            this.Id = 0;
            this.Status = (uint) StatusPedido.PENDENTE;
        }
    }
}