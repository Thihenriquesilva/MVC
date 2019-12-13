using System;
using System.Collections.Generic;
using System.IO;
using RoletopMVC.Models;

namespace RoletopMVC.Repositories
{
    public class EventoRepository
    {
        private const string PATH = "Database/Evento.csv";

        public List<Evento> ObterTodos(){
            
            List<Evento> eventos = new List<Evento>();

            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                Evento e = new Evento();
                string[] dados = linha.Split(";");
                e.Nome = dados[0];
                eventos.Add(e);
            }

            return eventos;
        }
    }
}