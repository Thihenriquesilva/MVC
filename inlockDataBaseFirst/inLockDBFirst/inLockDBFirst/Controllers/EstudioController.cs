using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inLockDBFirst.Domains;
using inLockDBFirst.Interfaces;
using inLockDBFirst.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace inLockDBFirst.Controllers
{   [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EstudioController : ControllerBase
    {
        private IEstudioRepository _estudioRepository;

        public EstudioController()
        {
            _estudioRepository = new EstudioRepository();
        }


       [HttpGet]
       public IActionResult Get()
        {
            return Ok(_estudioRepository.Listar());
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            return Ok(_estudioRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post(Estudios novosEstudios)
        {
            // Faz a chamada para o método
            _estudioRepository.Cadastrar(novosEstudios);

            // Retorna um status code
            return StatusCode(201);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete (int id)
        {
            _estudioRepository.Deletar(id);

            return Ok("Objeto deletado com sucesso");
        }

        [HttpPut("{id}")]

        public IActionResult Atualizar(int id, Estudios estudioAtualizado)
        {

            _estudioRepository.Atualizar(id,estudioAtualizado);
            return Ok("Objeto atualizado com sucesso");
        }
    }

    
}