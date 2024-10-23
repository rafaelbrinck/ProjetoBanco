using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBanco.Domain.Entity;

namespace ProjetoBanco.Data.Repository
{
    class RepositorioExtrato : IRepositorio<T>
    {
        private List<Extrato> extratos = new List<Extrato>();

        public void Adicionar(Extrato item)
        {
            extratos.Add(item);
        }

        public void Atualizar(Extrato item)
        {

        }

        public Extrato ObterPorId(int id)
        {
            foreach(var extrato in extratos)
            {
                if(extrato.ID == id)
                {
                    return extrato;
                }
            }
        }

        public void Deletar(int id)
        {
            foreach(var extrato in extratos)
            {
                if(extrato.ID == id)
                {
                    extratos.Remove(extrato);
                }
            }
        }

    }
}
