using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Domain.Entity.Tipo
{
    public class TipoSaida : TipoRegistro
    {
       
        public TipoSaida()
        {
            base.ID = 0;
            base.Tipo = "Saida";
        }
        public override string DescricaoTipo()
        {
            return "Saída";
        }
    }
}
