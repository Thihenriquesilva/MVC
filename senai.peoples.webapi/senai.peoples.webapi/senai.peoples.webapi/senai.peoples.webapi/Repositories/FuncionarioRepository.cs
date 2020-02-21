using senai.peoples.webapi.Domains;
using senai.peoples.webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.peoples.webapi.Repositories
{
    public class FuncionarioRepository :IFuncionarioRepository 
    {
        private string  stringConexao = "Data Source=LAPTOP-OMA8SO3J\\SQLEXPRESS; initial catalog=M_Peoples; user Id=sa; pwd=thi@132";
        //private string StringConexao = "Data Source=DEV1201\\SQLEXPRESS; initial catalog=M_Peoples; user Id=sa; pwd=sa@132";

        public List<FuncionariosDomain> Listar()
        {
            List<FuncionariosDomain> funcionarios = new List<FuncionariosDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryView = "SELECT IdFuncionario, Nome, Sobrenome FROM TBL_Funcionario;";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryView, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        FuncionariosDomain f = new FuncionariosDomain
                        {
                            IdFuncionario = Convert.ToInt32(rdr[0]),
                            Nome = rdr["Nome"].ToString(),
                            SobreNome = rdr["Sobrenome"].ToString()
                        };

                        funcionarios.Add(f);
                    }
                }
            }
            return funcionarios;
        }

        public  void AdicionarFuncionario(FuncionariosDomain fu)
        {

            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string queryAdd = "INSERT INTO TBL_Funcionario(Nome, Sobrenome VALUES (@Nome, @Sobrenome)";

                try
                {
                    SqlCommand cmd = new SqlCommand(queryAdd, con);
                    cmd.Parameters.AddWithValue("@Nome", fu.Nome);
                    cmd.Parameters.AddWithValue("@Sobrenome", fu.SobreNome);
                    con.Open();
                    cmd.ExecuteNonQuery();

                }
                catch(Exception e)
                {
                    Console.WriteLine("============================");
                    Console.WriteLine("O erro é : " + e);
                    Console.WriteLine("============================");
                }
            }


        }









    }
}
