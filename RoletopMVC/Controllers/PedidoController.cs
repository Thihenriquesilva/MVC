using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Enums;
using RoletopMVC.Models;
using RoletopMVC.Repositories;
using RoletopMVC.ViewModels;

namespace RoletopMVC.Controllers
{
    public class PedidoController: AbstractController
    {   PedidoRepository pedidoRepository = new PedidoRepository();
        EventoRepository eventoRepository = new EventoRepository();
        ServicosRepository servicosRepository = new ServicosRepository();
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index(){
            
            PedidoViewModel pvm = new PedidoViewModel();
            pvm.Eventos = eventoRepository.ObterTodos();
            pvm.Servicos = servicosRepository.ObterTodos();

            var usuarioLogado = UsuarioEmailSession();
            var nomeUsuarioLogado =UsuarioNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuarioLogado)){
                pvm.NomeUsuario = nomeUsuarioLogado;
            }
            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            if(clienteLogado != null){
                pvm.Cliente = clienteLogado;
            }

            pvm.NomedaView = "Pedido";
            pvm.EmailUser = usuarioLogado;
            pvm.UserName = nomeUsuarioLogado;

            return View(pvm);
        }

        public IActionResult Registrar (IFormCollection form){
            ViewData["Action"] = "Pedido";
            Pedido pedido= new Pedido();

            var nomeServico = form["servicos"];
            Servicos servico = new Servicos();
            servico.Nome = nomeServico;

            pedido.Servicos = servico;

            var nomeEvento = form["eventos"];
            Evento eventos = new Evento();
            eventos.Nome = nomeEvento;

            pedido.Evento = eventos;


            var formaEvento = form["forma-evento"];
            pedido.FormadoEvento = formaEvento;

            var formaPagamento = form["forma-pagamento"];
            pedido.FormaPagamento = formaPagamento;

            var numeroParticipante = uint.Parse(form["pessoas"]);
            pedido.NumeroParticipantes = numeroParticipante;

            var agendamentoEvento = DateTime.Parse(form["agenda-evento"]);
            pedido.AgendamentoEvento = agendamentoEvento;

            Cliente cliente = new Cliente() {
                Nome = form["nome"],
                CPF = form["cpf"],
                Telefone = form["telefone"],
                Email = form["email"]
            };

            pedido.Cliente = cliente;
            pedido.DataDoEvento = DateTime.Now;

            if(pedidoRepository.Inserir(pedido)){
                return View ("Sucesso", new RespostaViewModel(){
                    NomedaView = "Pedido",
                    EmailUser = UsuarioEmailSession(),
                    UserName = UsuarioNomeSession()
                });
            }else{
                return View("Erro", new RespostaViewModel(){
                    NomedaView = "Pedido",
                    EmailUser = UsuarioEmailSession(),
                    UserName = UsuarioNomeSession()
                });
            }
        }

        public IActionResult Aprovar (ulong id){
            Pedido pedido = pedidoRepository.ObterPor(id);
            pedido.Status = (uint) StatusPedido.APROVADO;

            if(pedidoRepository.Atualizar(pedido)){
                return RedirectToAction("Dashboard","Administrador");
            }
            else{
                return View("Erro", new RespostaViewModel(){
                    Mensagem = "Houve um erro ao Aprovar o pedido.",
                    NomedaView = " Dashboard",
                    EmailUser = UsuarioEmailSession(),
                    UserName = UsuarioNomeSession()
                });
            }
        }

        public IActionResult Reprovar (ulong id){
            Pedido pedido = pedidoRepository.ObterPor(id);
            pedido.Status = (uint) StatusPedido.REPROVADO;

            if(pedidoRepository.Atualizar(pedido)){
                return RedirectToAction("Dashboard", "Administrador");
            }
            else{
                return View ("Erro", new RespostaViewModel(){
                    Mensagem = "Houve um erro ao Reprovar o pedido.",
                    NomedaView = " Dashboard",
                    EmailUser = UsuarioEmailSession(),
                    UserName = UsuarioNomeSession()

                });
            }
        }
    }
}