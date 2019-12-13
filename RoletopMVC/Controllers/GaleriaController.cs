using Microsoft.AspNetCore.Mvc;
using RoletopMVC.ViewModels;

namespace RoletopMVC.Controllers
{
    public class GaleriaController:AbstractController
    {
        public IActionResult Index(){
            return View(new BaseViewModel(){
                NomedaView = "Galeria",
                EmailUser = UsuarioEmailSession(),
                UserName = UsuarioNomeSession()
            });
        }
    }
}