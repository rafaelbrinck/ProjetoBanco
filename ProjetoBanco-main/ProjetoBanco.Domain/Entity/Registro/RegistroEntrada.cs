using ProjetoBanco.Domain.Entity.Tipo;
using ProjetoBanco.Domain.Entity.Extratos;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Domain.Entity.Registro
{
    public class RegistroEntrada : Transacao
    {
        public RegistroEntrada(int id, decimal valor, Extrato _extrato) : base(id, valor, _extrato)
        {
            Tipo = new TipoEntrada();
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine("Transação de Entrada");
            base.ExibirDetalhes();
        }
    }

}
