using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Domain.Entity.Tipo
{
    public class TipoEntrada : TipoRegistro
    {
        public TipoEntrada()
        {
            base.ID = 1;
            base.Tipo = "Entrada";
        }
        public override string DescricaoTipo()
        {
            return "Entrada";
        }
    }
}
