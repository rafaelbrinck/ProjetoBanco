using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Data.Repository
{
    interface IRepositorio<T>
    {
        void Adicionar(T item);
        T ObterporId(int id);
        IEnumerable<T> ObterTodos();
        IEnumerable<T> ObterPor(Func<T, bool> predicate);
        void Atualizar(T item);
        void Deletar(int id);
    }
}
