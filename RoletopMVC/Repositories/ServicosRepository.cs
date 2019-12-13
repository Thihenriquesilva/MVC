using System.Collections.Generic;
using System.IO;
using RoletopMVC.Models;

namespace RoletopMVC.Repositories
{
    public class ServicosRepository
    {
        private const string PATH = "Database/Servicos.csv";
        public List <Servicos> ObterTodos(){
            List<Servicos> servicos = new List<Servicos>();
            var linhas = File.ReadAllLines(PATH);
            
            foreach (var linha in linhas)
            {
                Servicos serv = new Servicos();
                var dados = linha.Split(";");
                serv.Nome = dados[0];

                servicos.Add(serv);
            }

            return servicos;
        }
    }
}