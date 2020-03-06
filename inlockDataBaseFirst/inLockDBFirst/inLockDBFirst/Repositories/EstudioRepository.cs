using inLockDBFirst.Domains;
using inLockDBFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inLockDBFirst.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {
        InLockContext ctx = new InLockContext();

        public List<Estudios> Listar()
        {
            return ctx.Estudios.ToList();
        }

        public Estudios BuscarPorId(int id)
        {
            return ctx.Estudios.FirstOrDefault(e => e.IdEstudio == id);
        }

        public void Cadastrar (Estudios novosEstudios)
        {
            ctx.Estudios.Add(novosEstudios);

            ctx.SaveChanges();
        }


        public void Deletar(int id)
        {
            Estudios es = new Estudios();

            es = ctx.Estudios.FirstOrDefault(e => e.IdEstudio == id);
            ctx.Estudios.Remove(es);
            ctx.SaveChanges();
        }

        public void Atualizar(int id, Estudios estudioAtualizado)
        { Estudios est = new Estudios();
            est = ctx.Estudios.FirstOrDefault(e => e.IdEstudio == id);

            //est.IdEstudio = estudioAtualizado.IdEstudio;
            est.NomeEstudio = estudioAtualizado.NomeEstudio;


            ctx.Estudios.Update(est);
            ctx.SaveChanges();
        }
    }
}
