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
                            Genero = rdr["Titulo"].Equals();

                            
                            
                        };

                        filmes.Add(filme);
                    }
                }
            }

            return filmes;
        }

    }
}
