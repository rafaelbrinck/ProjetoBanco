using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Domain.CustomExeception
{
    public class ValorInvalidoException : ArgumentException
    {
        public ValorInvalidoException() : base("O valor do registro não pode ser negativo.")
        {

        }
    }
}
