using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AreasNeg
    {
        public static DataTable dt = new DataTable();
        static int contador = 5;

        public static void Areas()
        {
            dt = new DataTable();
            dt.Columns.Add("IdArea", typeof(int));
            dt.Columns.Add("Descripcion", typeof(String));
            dt.Columns.Add("Baja", typeof(bool));
            dt.Columns.Add("FechaBaja", typeof(String));
            dt.Columns.Add("CausaBaja", typeof(String));
            dt.Rows.Add(1, "Mecanica", true, "", "");
            dt.Rows.Add(2, "Hidraulica", true, "", "");
            dt.Rows.Add(3, "Electrica", true, "", "");
            dt.Rows.Add(4, "Aeronautica", false, "", "");
        }

        private DataTable copyTable()
        {
            DataTable areas = new DataTable();
            areas.Columns.Add("IdArea", typeof(int));
            areas.Columns.Add("Descripcion", typeof(String));
            areas.Columns.Add("Baja", typeof(bool));
            areas.Columns.Add("FechaBaja", typeof(String));
            areas.Columns.Add("CausaBaja", typeof(String));
            for (int i=0; i<dt.Rows.Count; i++)
            {
                areas.Rows.Add((int)dt.Rows[i]["IdArea"], (String)dt.Rows[i]["Descripcion"], (bool)dt.Rows[i]["Baja"], (String)dt.Rows[i]["FechaBaja"], (String)dt.Rows[i]["CausaBaja"]);
            }
            return areas;
        }
        
        public DataTable ObtenerAreas(int estado, String fragmento)
        {
            DataTable areas = copyTable();
            for (int i = areas.Rows.Count - 1; i >= 0; i--)
            {
                if (!((estado == 2 || ((bool)areas.Rows[i]["Baja"]) == (estado == 0)) && ((String)areas.Rows[i]["Descripcion"]).IndexOf(fragmento) != -1))
                {
                    areas.Rows.Remove(areas.Rows[i]);
                }
            }
            return areas;
        }

        public static bool AgregarArea(String Descripcion, bool estado, String fechaBaja, String causaBaja)
        {
            if (!Descripcion.Equals(String.Empty))
            {
                dt.Rows.Add(contador, Descripcion, estado, fechaBaja, causaBaja);
                contador++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ModificarArea(int id,String Descripcion, bool estado, String fechaBaja, String causaBaja)
        {
            if (!Descripcion.Equals(String.Empty))
            {
                dt.Rows[id-1]["Baja"] =estado;
                dt.Rows[id-1]["Descripcion"] = Descripcion;
                dt.Rows[id-1]["FechaBaja"] = fechaBaja;
                dt.Rows[id-1]["CausaBaja"] = causaBaja;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool EliminarArea(int id)
        {
            dt.Rows[id-1]["Baja"] = true;
            return true;
        }


    }
}
