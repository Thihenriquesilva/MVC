using senai.peoples.webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.peoples.webapi.Interfaces
{
    interface IFuncionarioRepository
    {
        List<FuncionariosDomain> Listar();
    }
}
