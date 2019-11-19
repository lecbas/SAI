using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EncuestaPreguntas
    {
        public int IdPregunta { get; set; }
        public int IdEncuesta { get; set; }
        public String Pregunta { get; set; }
        public int Orden { get; set; }
        public bool Baja { get; set; }
        public DateTime FechaBaja{ get; set; }
        public String CausaBaja { get; set; }
    }
}
