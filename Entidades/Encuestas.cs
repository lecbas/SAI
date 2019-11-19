using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Encuestas
    {
        public int IdEncuesta { get; set; }
        public int IdArea { get; set; }
        public String Descripcion { get; set; }
        public bool Baja { get; set; }
        public DateTime FechaBaja { get; set; }
        public String CausaBaja { get; set; }
    }
}
