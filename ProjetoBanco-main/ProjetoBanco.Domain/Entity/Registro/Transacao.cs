using ProjetoBanco.Domain.CustomExeception;
using System;
using ProjetoBanco.Domain.Entity.Tipo;
using ProjetoBanco.Domain.Entity.Extratos;

namespace ProjetoBanco.Domain.Entity.Registro
{
    public class Transacao
    {
        public int ID { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataTransacao { get; set; }
        public TipoRegistro Tipo { get; protected set; }
        public Extrato Extrato { get; private set; }

        public Transacao(int id, decimal valor, Extrato _extrato)
        {
            ValidarValor();
            Extrato = _extrato;
            ID = id;
            Valor = valor;
            DataTransacao = DateTime.Now;
        }

        public void ValidarValor()
        {
            if (Valor < 0)
            {
                throw new ValorInvalidoException();
            }
        }
        public void ValidarTipoRegistro(TipoRegistro tipo)
        {
            if (!(tipo is TipoEntrada) && !(tipo is TipoSaida))
            {
                throw new TipoRegistroInvalidoException();
            }
        }

        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"ID: {ID}, Valor: {Valor}, Data: {DataTransacao}");
        }
    }
}
