using ProjetoBanco.Domain.CustomExeception;
using ProjetoBanco.Domain.Entity.Registro;
using System;
using System.Collections.Generic;

namespace ProjetoBanco.Domain.Entity.Extratos
{
    public class Extrato
    {
        public int ID { get; set; }
        public string NumeroConta { get; set; }
        public string NomeTitular { get; set; }
        public List<Transacao> Registros { get; private set; }

        public Extrato(int id, string numeroConta, string nomeTitular)
        {
            ID = id;
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Registros = new List<Transacao>();
        }

        public void ValidarNumeroConta()
        {
            if (string.IsNullOrEmpty(NumeroConta))
            {
                throw new ExtratoInvalidoException("O número da conta é inválido.", nameof(NumeroConta));
            }
        }

        public void AdicionarTransacao(Transacao transacao)
        {
            transacao.ValidarValor();
            ValidarTransacao(transacao);

            if (transacao.Extrato.ID != ID)
            {
                throw new RegistroSemExtratoException();
            }

            Registros.Add(transacao);
        }

        public void ValidarTransacao(Transacao transacao)
        {
            ExtratoTransacoes ExtratoTrans = new ExtratoTransacoes();
            ExtratoTrans.PopulaLista(Registros);
            decimal ValorTotal = ExtratoTrans.CalcularSaldo();
            if(ValorTotal > transacao.Valor)
            {
                throw new TransacaoNaoPermitidaException();
            }
        }

        public virtual void ImprimirExtrato()
        {
            Console.WriteLine($"Extrato ID: {ID}, Conta: {NumeroConta}");
        }
    }
}
