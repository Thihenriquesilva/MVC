using senai.filmes.webapi.Domains;
using senai.filmes.webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.filmes.webapi.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {

        private string stringConexao = "Data Source=DEV1201\\SQLEXPRESS; initial catalog=Filmes; user Id=sa; pwd=sa@132";

        //private string stringConexao = "Data Source=LAPTOP-OMA8SO3J\\SQLEXPRESS; initial catalog=Filmes; user Id=sa; pwd=thi@132";


        public List<FilmeDomain> ListarFilmes()
        {
            List<FilmeDomain> filmes = new List<FilmeDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                //string queryLer = "SELECT IdFilme, Titulo, IdGenero FROM Filmes";
                string queryLer = "SELECT IdFilme, Titulo, Genero.IdGenero, Genero FROM Filmes INNER JOIN Genero ON Genero.IdGenero = Filmes.IdGenero";

                con.Open();

                SqlDataReader rdr;

                using(SqlCommand cmd = new SqlCommand(queryLer, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        FilmeDomain filme = new FilmeDomain
                        {
                            IdFilme = Convert.ToInt32(rdr[0]),
                            Titulo = rdr["Titulo"].ToString(),
                            IdGenero = Convert.ToInt32(rdr[2]),
                            Genero = new GeneroDomain {
                                Nome = rdr["Genero"].ToString()
                            }                                                                                
                            
                        };

                        filmes.Add(filme);
                    }
                }
            }

            return filmes;
        }

        public FilmeDomain BuscarFilmePorId(int id)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string selectById = "SELECT IdFilme, Titulo, Genero.IdGenero FROM Filmes INNER JOIN Genero ON Genero.IdGenero = Filmes.IdGenero WHERE IdFilme =@ID";

                con.Open();

                SqlDataReader rdr;

                using(SqlCommand cmd = new SqlCommand(selectById, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        FilmeDomain filme = new FilmeDomain
                        {
                            IdFilme = Convert.ToInt32(rdr["IdFilme"]),
                            Titulo = rdr["Titulo"].ToString(),
                            IdGenero = Convert.ToInt32(rdr["IdGenero"]),
                            

                        };

                        return filme;
                    }
                    return null;

                }
            }
        }


        public void Add (FilmeDomain fil)
        {
                using(SqlConnection con = new SqlConnection(stringConexao))
            {
                string insert = "INSERT INTO Filmes(Titulo, IdGenero) VALUES(@Titulo, @IdGenero)";

                try
                {
                    SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@Titulo", fil.Titulo);
                    cmd.Parameters.AddWithValue("@IdGenero", fil.IdGenero);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    Console.WriteLine("===========================");
                    Console.WriteLine("O erro é: " + e);
                    Console.WriteLine("===========================");
                }
            }
        }
    }
}
