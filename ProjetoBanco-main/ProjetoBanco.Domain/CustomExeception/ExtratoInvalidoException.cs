using System;

namespace ProjetoBanco.Domain.CustomExeception
{
    public class ExtratoInvalidoException : ArgumentException
    {
        public ExtratoInvalidoException(string message, string paramName) : base(message, paramName)
        {
        }
    }
}
