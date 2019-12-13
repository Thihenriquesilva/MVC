using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Enums;
using RoletopMVC.Repositories;
using RoletopMVC.ViewModels;

namespace RoletopMVC.Controllers
{
    public class ClienteController : AbstractController
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        private PedidoRepository pedidoRepository = new PedidoRepository();
    

        [HttpGet]

        public IActionResult Login(){
            return View (new BaseViewModel(){
                NomedaView = "Login",
                EmailUser = UsuarioEmailSession(),
                UserName = UsuarioNomeSession()
            });
        }

        [HttpPost]

        public IActionResult Login(IFormCollection form){
            ViewData["Action"] = "Login";
            try{
                Console.WriteLine("==================");
                Console.WriteLine(form["email"]);
                Console.WriteLine(form["senha"]);
                Console.WriteLine("==================");


                var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepository.ObterPor(usuario);

                if(cliente != null){
                    if(cliente.Senha.Equals(senha)){

                        switch(cliente.TipoDeUsuario)
                        {
                        case (uint) TiposDeUsuario.CLIENTE:
                        HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                        HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                        HttpContext.Session.SetString(SESSION_TIPO_USUARIO, cliente.TipoDeUsuario.ToString());
                        return RedirectToAction("Historico","Cliente");
                        
                        default:
                        HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                        HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                        HttpContext.Session.SetString(SESSION_TIPO_USUARIO, cliente.TipoDeUsuario.ToString());
                        return RedirectToAction("Dashboard","Administrador");
                        }
                    }
                    else{
                        return View("Erro", new RespostaViewModel("Senha Incorreta"));
                    }
                }
                else{
                    return View ("Erro", new RespostaViewModel($"Usuário {usuario} não encontrado"));
                }
            }
            catch(Exception e)
            {   Console.WriteLine("=================");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("=================");
                return View("Erro");
            }
        }

        public IActionResult Historico(){
            var emailCliente = UsuarioEmailSession();
            var eventosCliente = pedidoRepository.ObterTodosPorCliente(emailCliente);

            return View (new HistoricoViewModel(){
                PedidoEventos = eventosCliente,
                NomedaView = "Historico",
                EmailUser = UsuarioEmailSession(),
                UserName = UsuarioNomeSession()
            });
        }

        public IActionResult Logoff(){
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }

}