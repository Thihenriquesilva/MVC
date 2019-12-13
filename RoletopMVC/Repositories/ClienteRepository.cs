using System;
using System.IO;
using RoletopMVC.Models;

namespace RoletopMVC.Repositories
{
    public class ClienteRepository : RepositoryBase
    {
        private const string PATH = "Database/Cliente.csv";

        public ClienteRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Cliente cliente){
            var linha = new string[]{RegistroArmazenadoCSV(cliente)};
            File.AppendAllLines(PATH, linha);

            return true;
        }

        public Cliente ObterPor (string email)
        {
            var linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas){
                if(ExtrairValor("email",item).Equals(email)){

                    Cliente cl = new Cliente();
                    cl.Nome = ExtrairValor("nome", item);
                    cl.Email = ExtrairValor("email", item);
                    cl.Senha = ExtrairValor("senha", item);
                    cl.CPF = ExtrairValor("cpf", item);
                    cl.Telefone = ExtrairValor("telefone", item);
                    cl.DataNascimento = DateTime.Parse(ExtrairValor("data_nascimento", item));
                    cl.TipoDeUsuario = uint.Parse(ExtrairValor("tipo_usuario",item));

                    return cl;
                }
            }
                return null;
        }

        private string RegistroArmazenadoCSV(Cliente cliente){
            return $"tipo_usuario={cliente.TipoDeUsuario};nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};cpf={cliente.CPF};telefone={cliente.Telefone};data_nascimento={cliente.DataNascimento}";
        }
    }
}