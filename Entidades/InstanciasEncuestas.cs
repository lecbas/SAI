using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class InstanciasEncuestas
    {
        public int IdEncuesta { get; set; }
        public DateTime FechaAltaInstEnc { get; set; }
        public int IdCurso { get; set; }
        public int IdMateria { get; set; }
        public int Legajo { get; set; }
        public DateTime FechaCarga { get; set; }
        public DateTime FechaRealizacion { get; set; }
        
    }
}
