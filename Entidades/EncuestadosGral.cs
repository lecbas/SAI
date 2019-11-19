using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EncuestadosGral
    {
        public int IdEncuestado { get; set; }
        public int IdEncuesta { get; set; }
        public DateTime FechaAltaInstEnc { get; set; }
        public int Edad { get; set; }
        public int IdGenero { get; set; }
        public String Cp { get; set; }
        public int IdColegio { get; set; }
        public int IdOrientacion { get; set; }
        public bool Pase { get; set; }
        public int IdTipoEstablecimiento { get; set; }
        public int IdCarrera { get; set; }
        public String Comentarios { get; set; }
      

    }
}
