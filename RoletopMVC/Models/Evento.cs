using System;

namespace RoletopMVC.Models
{
    public class Evento
    {
        public string Nome {get;set;}
        
        public Evento (){

        }

        public Evento(string nome){
            this.Nome =nome;
        }

    }
}