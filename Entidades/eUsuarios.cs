using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eUsuarios
    {
        public string User { get; set; }
        public Int32 IdTipoDoc { get; set; }
        public Int32 NroDoc { get; set; }
        public string Clave { get; set; }
        public Boolean Baja { get; set; }
        public DateTime FechaBaja { get; set; }
        public string CausaBaja { get; set; }

    }
}
