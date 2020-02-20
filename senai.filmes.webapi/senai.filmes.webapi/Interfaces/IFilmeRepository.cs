﻿using senai.filmes.webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.filmes.webapi.Interfaces
{
    interface IFilmeRepository
    {
        List<FilmeDomain> ListarFilmes();

        FilmeDomain BuscarFilmePorId(int id);

        void Add(FilmeDomain fil);
    }
}
