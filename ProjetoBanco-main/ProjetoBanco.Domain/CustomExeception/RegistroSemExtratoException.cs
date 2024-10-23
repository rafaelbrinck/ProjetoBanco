using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Domain.CustomExeception
{
    public class RegistroSemExtratoException : Exception
    {
        public RegistroSemExtratoException() : base("ID de extrato invalido") { }
    }
}
