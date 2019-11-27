using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CarrerasNeg
    {
        public static DataTable dt = new DataTable();
        static int contador = 5;

        public static void Carreras()
        {
            dt = new DataTable();
            dt.Columns.Add("IdCarrera", typeof(int));
            dt.Columns.Add("IdTipoCarrera", typeof(int));
            dt.Columns.Add("Descripcion", typeof(String));
            dt.Columns.Add("CodigoInterno", typeof(String));
            dt.Columns.Add("Baja", typeof(bool));
            dt.Columns.Add("FechaBaja", typeof(String));
            dt.Columns.Add("CausaBaja", typeof(String));
            dt.Rows.Add(1, 1, "Ingenieria Aeronautica", "A1", false, "", "");
            dt.Rows.Add(2, 1, "Ingenieria Quimica", "A2", false, "", "");
            dt.Rows.Add(3, 1, "Ingenieria Civil", "A3", true, "", "");
        }

        private DataTable copyTable()
        {
            DataTable carreras = new DataTable();
            carreras.Columns.Add("IdCarrera", typeof(int));
            carreras.Columns.Add("IdTipoCarrera", typeof(int));
            carreras.Columns.Add("Descripcion", typeof(String));
            carreras.Columns.Add("CodigoInterno", typeof(String));
            carreras.Columns.Add("Baja", typeof(bool));
            carreras.Columns.Add("FechaBaja", typeof(String));
            carreras.Columns.Add("CausaBaja", typeof(String));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                carreras.Rows.Add((int)dt.Rows[i]["IdCarrera"], (int)dt.Rows[i]["IdTipoCarrera"], (String)dt.Rows[i]["Descripcion"], (String)dt.Rows[i]["CodigoInterno"], (bool)dt.Rows[i]["Baja"], (String)dt.Rows[i]["FechaBaja"], (String)dt.Rows[i]["CausaBaja"]);
            }
            return carreras;
        }

        public DataTable ObtenerAreas(int estado, String fragmento, int filtro)
        {
            DataTable carreras = copyTable();
            for (int i = carreras.Rows.Count - 1; i >= 0; i--)
            {
                switch (filtro)
                {
                    case 1:
                        {
                            if (!((estado == 2 || ((bool)carreras.Rows[i]["Baja"]) == (estado == 0)) && ((String)carreras.Rows[i]["Descripcion"]).IndexOf(fragmento) != -1))
                            {
                                carreras.Rows.Remove(carreras.Rows[i]);
                            }
                            break;
                        }
                    case 2:
                        {
                            if (!((estado == 2 || ((bool)carreras.Rows[i]["Baja"]) == (estado == 0)) && ((String)carreras.Rows[i]["CodigoInterno"]).IndexOf(fragmento) != -1))
                            {
                                carreras.Rows.Remove(carreras.Rows[i]);
                            }
                            break;
                        }
                    case 3:
                        {
                            int value = 0;
                            if (!((estado == 2 || ((bool)carreras.Rows[i]["Baja"]) == (estado == 0)) && (!Int32.TryParse(fragmento, out value) || ((int)carreras.Rows[i]["IdTipoCarrera"]) == Int32.Parse(fragmento))))
                            {
                                carreras.Rows.Remove(carreras.Rows[i]);
                            }
                            break;
                        }
                }

                
            }
            return carreras;
        }

        public DataTable obtenerTipos()
        {
            DataTable ds = new DataTable();
            ds.Columns.Add("IdTipoCarrera", typeof(int));
            ds.Columns.Add("Descripcion", typeof(String));
            ds.Rows.Add(1, "De grado");
            ds.Rows.Add(2, "Posgrado");
            ds.Rows.Add(3, "Tecnicaturas");
            return ds;
        }

        public static bool AgregarCarrera(int idTipo,String Descripcion,String codigoInterno, bool estado, String fechaBaja, String causaBaja)
        {
            if (!Descripcion.Equals(String.Empty))
            {
                dt.Rows.Add(contador, idTipo, Descripcion,codigoInterno, estado, fechaBaja, causaBaja);
                contador++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ModificarCarrera(int id, int idTipo, String Descripcion, String codigoInterno, bool estado, String fechaBaja, String causaBaja)
        {
            if (!Descripcion.Equals(String.Empty) && !codigoInterno.Equals(String.Empty))
            {
                dt.Rows[id - 1]["IdTipoCarrera"] = idTipo;
                dt.Rows[id - 1]["Baja"] = estado;
                dt.Rows[id - 1]["CodigoInterno"] = codigoInterno;
                dt.Rows[id - 1]["Descripcion"] = Descripcion;
                dt.Rows[id - 1]["FechaBaja"] = fechaBaja;
                dt.Rows[id - 1]["CausaBaja"] = causaBaja;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool EliminarCarrera(int id)
        {
            dt.Rows[id - 1]["Baja"] = true;
            return true;
        }
    }
}
