using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Domain.CustomExeception
{
    public class RegistroInvalidoException : Exception
    {
        public RegistroInvalidoException(string message) : base(message)
        {
        }
    }
}
