using inLockDBFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inLockDBFirst.Interfaces
{
    interface IEstudioRepository
    {

        List<Estudios> Listar();

        Estudios BuscarPorId(int id);

        void Cadastrar(Estudios novosEstudios);

        void Deletar(int id);

        void Atualizar(int id, Estudios estudioAtualizado);
    }
}
