using ProjetoBanco.Domain.Entity.Registro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Domain.Entity.Extratos
{
    public class ExtratoTransacoes
    {
        private List<Transacao> transacoes = new List<Transacao>();

        public void AdicionarTransacao(Transacao transacao)
        {
            transacao.ValidarValor();
            transacoes.Add(transacao);
        }

        public decimal CalcularSaldo()
        {
            var entrada = new List<RegistroEntrada>();
            var saida = new List<RegistroSaida>();

            foreach (var transacao in transacoes)
            {
                if (transacao is RegistroEntrada)
                    entrada.Add(transacao as RegistroEntrada);
                else
                    saida.Add(transacao as RegistroSaida);
            }

            return entrada.Sum(a => a.Valor) - saida.Sum(a => a.Valor);
        }

        public void PopulaLista(List<Transacao> ListaT)
        {
            transacoes = ListaT;
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo total: {CalcularSaldo()}");
        }
    }
}

