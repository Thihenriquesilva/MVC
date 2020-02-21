using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.peoples.webapi.Domains;
using senai.peoples.webapi.Interfaces;
using senai.peoples.webapi.Repositories;

namespace senai.peoples.webapi.Controllers
{   [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        private IFuncionarioRepository _funcRepository { get; set; }

        public FuncionariosController()
        {
            _funcRepository = new FuncionarioRepository();
        }

        [HttpGet]
        public IEnumerable<FuncionariosDomain> Get()
        {
            return _funcRepository.Listar();
        }

        [HttpPost]
        public IActionResult Post(FuncionariosDomain fu)
        {
            _funcRepository.AdicionarFuncionario(fu);

            return Ok("Cadastrado com Sucesso");
        }
    }
}