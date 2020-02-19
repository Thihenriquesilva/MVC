using senai.filmes.webapi.Domains;
using senai.filmes.webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.filmes.webapi.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {   //Adiciona o Banco de Dados e define qual Banco usar
        //integrated security= true : usar em casa
        private string StringConexao = "Data Source=DEV1201\\SQLEXPRESS; initial catalog=Filmes; user Id=sa; pwd=sa@132";

        //private string StringConexao = "Data Source=LAPTOP-OMA8SO3J\\SQLEXPRESS; initial catalog=Filmes; user Id=sa; pwd=thi@132";
        public List<GeneroDomain> Listar()
        {
            List<GeneroDomain> generos = new List<GeneroDomain>();

            //só sera feita quando for necessario
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string query = " SELECT IdGenero, Genero FROM Genero";

                con.Open();

                SqlDataReader rdr;

                //  query que vou utilizar e qual a conexao vou utilizar
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    rdr = cmd.ExecuteReader();

                    //Enquanto tiver linhas para ler eu vou:
                    while (rdr.Read())
                    {   //Criar generos
                        GeneroDomain genero = new GeneroDomain
                        {
                            IdGenero = Convert.ToInt32(rdr[0]),
                            Nome = rdr["Genero"].ToString()
                        };

                        //adicionar na lista 'generos'
                        generos.Add(genero);
                    }
                }
            }

            return generos;
        }

        public GeneroDomain BuscarPorId(int id)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string selectById = "SELECT IdGenero, Genero FROM Genero WHERE IdGenero= @ID";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(selectById, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        GeneroDomain genero = new GeneroDomain
                        {
                            IdGenero = Convert.ToInt32(rdr["IdGenero"]),
                            Nome = rdr["Genero"].ToString()
                        };
                        return genero;
                    }
                    return null;
                }  
            }
        }


        public void Add(GeneroDomain ge)
        {
            //GeneroDomain g = new GeneroDomain();

            //List<GeneroDomain> addgeneros = new List<GeneroDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string insert = "INSERT INTO Genero(Genero) VALUES(@Genero)";


                try
                {
                    SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@Genero", ge.Nome);
                    con.Open();
                    cmd.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine("============================");
                    Console.WriteLine("O erro é : " + e);
                    Console.WriteLine("============================");
                }


            }
        }

        public void AtualizarIdCorpo(GeneroDomain genero)
        {
            // Declara a conexão passando a string de conexão
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                // Declara a query que será executada
                string queryUpdate = "UPDATE Genero SET Genero = @Nome WHERE IdGenero = @ID";

                // Declara o SqlCommand passando o comando a ser executado e a conexão
                using (SqlCommand cmd = new SqlCommand(queryUpdate, con))
                {
                    // Passa os valores dos parâmetros
                    cmd.Parameters.AddWithValue("@ID", genero.IdGenero);
                    cmd.Parameters.AddWithValue("@Nome", genero.Nome);

                    // Abre a conexão com o banco de dados
                    con.Open();

                    // Executa o comando
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AtualizarIdUrl(int id, GeneroDomain genero)
        {
            // Declara a conexão passando a string de conexão
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                // Declara a query que será executada
                string queryUpdate = "UPDATE Genero SET Genero = @Nome WHERE IdGenero = @ID";

                // Declara o SqlCommand passando o comando a ser executado e a conexão
                using (SqlCommand cmd = new SqlCommand(queryUpdate, con))
                {
                    // Passa os valores dos parâmetros
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Nome", genero.Nome);

                    // Abre a conexão com o banco de dados
                    con.Open();

                    // Executa o comando
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(int Id)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string delete = "DELETE FROM Genero WHERE IdGenero = @Id";

                using (SqlCommand cmd = new SqlCommand(delete, con))
                {
                    cmd.Parameters.AddWithValue("@Id",Id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

            }
        }

    }
}
