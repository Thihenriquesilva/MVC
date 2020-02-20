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
{   [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        // GET: api/Filmes

        private IFilmeRepository _filmeRepository { get; set;}
        public FilmesController()
        {
            _filmeRepository = new FilmeRepository();
        }
        [HttpGet]
        public IEnumerable<FilmeDomain> Get()
        {
            return _filmeRepository.ListarFilmes();
        }

        // GET: api/Filmes/5
        [HttpGet("{id}")]
        public IActionResult GetByIDFilme(int id)
        {
            FilmeDomain filmeBuscado = _filmeRepository.BuscarFilmePorId(id);

            if(filmeBuscado == null)
            {
                return NotFound("Não encontrado");
            }

            return Ok(filmeBuscado);
        }

        // POST: api/Filmes
        [HttpPost]
        public IActionResult Post (FilmeDomain fil)
        {
            _filmeRepository.Add(fil);

            return Ok();
        }
        

        // PUT: api/Filmes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
