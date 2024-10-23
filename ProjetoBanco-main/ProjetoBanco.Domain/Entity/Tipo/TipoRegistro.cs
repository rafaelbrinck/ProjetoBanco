using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Domain.Entity.Tipo
{
    public abstract class TipoRegistro
    {
        public int ID { get; set; }
        public abstract string DescricaoTipo();
        public string Tipo { get; set; }
    }
}
