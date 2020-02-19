using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.filmes.webapi.Domains;
using senai.filmes.webapi.Interfaces;
using senai.filmes.webapi.Repositories;

namespace senai.filmes.webapi.Controllers
{   //qual sera a rota
    [Produces("application/json")]
    //como acessar o controlador
    [Route("api/[controller]")]
    [ApiController]
    public class GenerosController : ControllerBase
    {
        private IGeneroRepository _generoRepository { get; set; }

        public GenerosController()
        {
            _generoRepository = new GeneroRepository();
        }

        [HttpGet]
        public IEnumerable<GeneroDomain> Get()
        {
            return _generoRepository.Listar();
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            GeneroDomain generoBuscado = _generoRepository.BuscarPorId(id);

            if(generoBuscado == null)
            {
                return NotFound("Nenhum gênero encotrado");
            }

            return Ok(generoBuscado);
        }


        [HttpPost]

        //Método do professor
        public IActionResult Post(GeneroDomain ge)
        {
            _generoRepository.Add(ge);

            return Ok();
        }

        //MEu método
        //public void Add(GeneroDomain ge)
        //{
        //   _generoRepository.Add(ge);
        //}


        [HttpPut]
        public IActionResult PutIdCorpo(GeneroDomain generoAtualizado)
        {
            // Cria um objeto generoBuscado que irá receber o gênero buscado no banco de dados
            GeneroDomain generoBuscado = _generoRepository.BuscarPorId(generoAtualizado.IdGenero);

            // Verifica se algum gênero foi encontrado
            if (generoBuscado != null)
            {
                // Tenta atualizar o registro
                try
                {
                    // Faz a chamada para o método .AtualizarIdCorpo();
                    _generoRepository.AtualizarIdCorpo(generoAtualizado);

                    // Retorna um status code 204 - No Content
                    return NoContent();
                }
                // Caso ocorra algum erro
                catch (Exception erro)
                {
                    // Retorna BadRequest e o erro
                    return BadRequest(erro);
                }

            }

            // Caso não seja encontrado, retorna NotFound com uma mensagem personalizada
            // e um bool para representar que houve erro
            return NotFound
                (
                    new
                    {
                        mensagem = "Gênero não encontrado",
                        erro = true
                    }
                );
        }

        [HttpPut("{id}")]
        public IActionResult PutIdUrl(int id, GeneroDomain generoAtualizado)
        {
            // Cria um objeto generoBuscado que irá receber o gênero buscado no banco de dados
            GeneroDomain generoBuscado = _generoRepository.BuscarPorId(id);

            // Verifica se nenhum gênero foi encontrado
            if (generoBuscado == null)
            {
                // Caso não seja encontrado, retorna NotFound com uma mensagem personalizada
                // e um bool para representar que houve erro
                return NotFound
                    (
                        new
                        {
                            mensagem = "Gênero não encontrado",
                            erro = true
                        }
                    );
            }

            // Tenta atualizar o registro
            try
            {
                // Faz a chamada para o método .AtualizarIdUrl();
                _generoRepository.AtualizarIdUrl(id, generoAtualizado);

                // Retorna um status code 204 - No Content
                return NoContent();
            }
            // Caso ocorra algum erro
            catch (Exception erro)
            {
                // Retorna BadRequest e o erro
                return BadRequest(erro);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            _generoRepository.Deletar(Id);

            return Ok("Gênero deletado");
        }
    }
}