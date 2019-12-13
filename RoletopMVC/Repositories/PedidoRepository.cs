using System;
using System.Collections.Generic;
using System.IO;
using RoletopMVC.Models;

namespace RoletopMVC.Repositories
{
    public class PedidoRepository : RepositoryBase
    {
        private const string PATH = "Database/Pedido.csv";

        public PedidoRepository(){
            if(!File.Exists (PATH)){
                File.Create (PATH).Close();
            }
        }
        public bool Inserir(Pedido pedido){
            var quantidadePedidos = File.ReadAllLines(PATH).Length;
            pedido.Id = (ulong) ++quantidadePedidos;
            var linha = new string[] {RegistroArmazenadoCSV (pedido)};
            File.AppendAllLines (PATH, linha);
            return true;
        }

        public List<Pedido> ObterTodosPorCliente(string emailCliente){
                var pedidos = ObterTodos();
                List<Pedido> pedidosCliente = new List<Pedido>();
                foreach (var pedido in pedidos)
                {
                    if(pedido.Cliente.Email.Equals(emailCliente)){
                        pedidosCliente.Add(pedido);
                    }
                }

                return pedidosCliente;
        }


        public Pedido ObterPor(ulong id){
            var pedidosTotais = ObterTodos();
            foreach (var pedido in pedidosTotais)
            {
                if(pedido.Id == id)
                {
                    return pedido;
                }
            }
            return null;
        }

        public List<Pedido> ObterTodos(){
            var linhas = File.ReadAllLines(PATH);
            List<Pedido> pedidos = new List<Pedido>();

            foreach (var linha in linhas)
            {
                Pedido pedido = new Pedido();

                pedido.Id = ulong.Parse(ExtrairValor("id",linha));
                pedido.Status = uint.Parse(ExtrairValor("status_pedido",linha));
                pedido.Cliente.Nome = ExtrairValor("cliente_nome", linha);
                pedido.Cliente.CPF = ExtrairValor("cliente_cpf",linha);
                pedido.Cliente.Telefone = ExtrairValor("cliente_telefone",linha);
                pedido.Cliente.Email = ExtrairValor("cliente_email",linha);
                pedido.Evento.Nome = ExtrairValor("evento_nome",linha);
                pedido.Servicos.Nome = ExtrairValor("servicos_nome",linha);
                pedido.NumeroParticipantes = uint.Parse(ExtrairValor("numero_participantes",linha));
                pedido.FormaPagamento = ExtrairValor("forma_pagamento",linha);
                pedido.FormadoEvento = ExtrairValor("forma_evento",linha);
                pedido.DataDoEvento = DateTime.Parse(ExtrairValor("data_pedido",linha));
                pedido.AgendamentoEvento = DateTime.Parse(ExtrairValor("agendamento_evento",linha));

                pedidos.Add(pedido);

            }
            return pedidos;
        }

        public bool Atualizar (Pedido pedido){
            var pedidosTotais = File.ReadAllLines(PATH);
            var pedidosCSV = RegistroArmazenadoCSV (pedido);
            var linhaPedido = -1;
            var resultado = false;

            for(int i = 0; i < pedidosTotais.Length; i++){
                    var idConvertido = ulong.Parse(ExtrairValor("id",pedidosTotais[i]));
                    if(pedido.Id.Equals(idConvertido)){
                        linhaPedido = i;
                        resultado = true;
                        break;
                    }
            }

            if(resultado){
                pedidosTotais[linhaPedido] = pedidosCSV;
                File.WriteAllLines(PATH, pedidosTotais);
            }

            return resultado;
        }

        private string RegistroArmazenadoCSV (Pedido pedido){
            Cliente c = pedido.Cliente;
            Evento ev = pedido.Evento;
            Servicos serv = pedido.Servicos;

            return $"id={pedido.Id};status_pedido={pedido.Status};cliente_nome={pedido.Cliente.Nome};cliente_cpf={pedido.Cliente.CPF};cliente_telefone={pedido.Cliente.Telefone};cliente_email={pedido.Cliente.Email};evento_nome={pedido.Evento.Nome};servicos_nome={pedido.Servicos.Nome};numero_participantes={pedido.NumeroParticipantes};agendamento_evento={pedido.AgendamentoEvento};forma_pagamento={pedido.FormaPagamento};forma_evento={pedido.FormadoEvento};data_pedido={pedido.DataDoEvento}";
        }
    }
}