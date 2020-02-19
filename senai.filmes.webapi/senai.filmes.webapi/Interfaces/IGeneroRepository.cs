using senai.filmes.webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.filmes.webapi.Interfaces
{
    interface IGeneroRepository
    {
        /// <summary>
        /// Lista todos os gêneros
        /// </summary>
        /// <returns>Retorna uma lista de gêneros</returns>
        List<GeneroDomain> Listar();
        void Add(GeneroDomain ge);

        GeneroDomain BuscarPorId(int id);

        void Deletar(int Id);

        void AtualizarIdCorpo(GeneroDomain genero);

        void AtualizarIdUrl(int id, GeneroDomain genero);
    }
}
