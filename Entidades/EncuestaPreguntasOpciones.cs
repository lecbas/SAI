using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EncuestaPreguntasOpciones
    {
        public int IdOpcionPregunta { get; set; }
        public int idPregunta { get; set; }
        public int Orden { get; set; }
        public String Opcion { get; set; }
        public bool RequiereOtros { get; set; }
        public bool Baja { get; set; }
        public DateTime FechaBaja { get; set; }
        public int CausaBaja { get; set; }
    }
}
