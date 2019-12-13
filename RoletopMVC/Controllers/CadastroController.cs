using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Models;
using RoletopMVC.Repositories;
using RoletopMVC.ViewModels;

namespace RoletopMVC.Controllers
{
    public class CadastroController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index (){
            return View(new BaseViewModel(){
                NomedaView = "Cadastro",
                EmailUser = UsuarioEmailSession(),
                UserName = UsuarioNomeSession()
            });
        }


        public IActionResult CadastrarCliente(IFormCollection form){

            ViewData["Action"] ="Cadastro";

            try{
                Cliente cliente = new Cliente(
                    form["nome"],
                    form["email"],
                    form["senha"],
                    form["cpf"],
                    form["telefone"],
                    DateTime.Parse(form["data-nascimento"]));
                
                clienteRepository.Inserir(cliente);

                return View("Sucesso", new RespostaViewModel(){
                    NomedaView = "Cadastro",
                    EmailUser = UsuarioEmailSession(),
                    UserName = UsuarioNomeSession()
                });
            }
            catch(Exception e){
                Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel(){
                    NomedaView = "Cadastro",
                    EmailUser = UsuarioEmailSession(),
                    UserName = UsuarioNomeSession()
                });
            }

        }
    }
}