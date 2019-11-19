using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace ManejoDatos
{
    public class mdInstanciasEncuestas
    {
        #region INSERTART InstanciasEncuestas
        AccesoDatosClass oAccesoDatos = new AccesoDatosClass();


        public Int32 InsertarInstanciasEncuestas(InstanciasEncuestas oInstanciasEncuestas)
        {
            StringBuilder query = new StringBuilder();

            query.Append("INSERT INTO ");
            query.Append("InstanciasEncuestas ");

            query.Append("(IdEncuesta,FechaAltaInsEnc,IdCurso,IdMateria,Legajo,FechaCarga,FechaRealizacion) ");
            query.Append("VALUES ( ");
            query.Append("'" + oInstanciasEncuestas.IdEncuesta + "',");
            query.Append("'" + oInstanciasEncuestas.FechaAltaInstEnc + "',");
            query.Append("'" + oInstanciasEncuestas.IdCurso + "',");
            query.Append("'" + oInstanciasEncuestas.IdMateria + "',");
            query.Append("'" + oInstanciasEncuestas.Legajo + "',");
            query.Append("'" + oInstanciasEncuestas.FechaCarga + "',");
            query.Append("'" + oInstanciasEncuestas.FechaRealizacion + "'");
            query.Append(") ");
            try
            {
                oAccesoDatos.Abrir();

                int guardo = oAccesoDatos.EjecutarCUD(CommandType.Text, query.ToString());
                return guardo;
            }
            catch
            {
                throw;
            }
            finally
            {
                oAccesoDatos.Cerrar();
            }
        }
        #endregion


        #region LISTAR InstanciasEncuestas

        public List<InstanciasEncuestas> ListarInstanciasEncuestas(DateTime fechaAlta, String id = "")
        {
            List<InstanciasEncuestas> Lista = new List<InstanciasEncuestas>();
            IDataReader reader = null;

            StringBuilder query = new StringBuilder();
            query.Append("SELECT ");
            query.Append("IdEncuesta,");
            query.Append("FechaAltaInstEnc, ");
            query.Append("IdCurso, ");
            query.Append("IdMateria, ");
            query.Append("Legajo, ");
            query.Append("FechaCarga, ");
            query.Append("FechaRealizacion, ");
            query.Append("FROM ");
            query.Append("InstanciasEncuestas");

            if (id != "")
            {
                query.Append(" WHERE IdEncuesta='" + id + "'" + "AND FechaAltaInstEnc='" + fechaAlta + "'");
            }

            try
            {
                oAccesoDatos.Abrir();
                reader = oAccesoDatos.EjecutarConsulta(CommandType.Text, query.ToString());

                while (reader.Read())
                {
                    InstanciasEncuestas ous = new InstanciasEncuestas
                    {
                        IdEncuesta = Convert.ToInt32(reader["IdEncuesta"].ToString()),
                        FechaAltaInstEnc = Convert.ToDateTime(reader["FechaAltaInstEnc"].ToString()),
                        IdCurso = Convert.ToInt32(reader["Descripcion"].ToString()),
                        IdMateria = Convert.ToInt32(reader["IdMateria"].ToString()),
                        Legajo = Convert.ToInt32(reader["Legajo"].ToString()),
                        FechaCarga = Convert.ToDateTime(reader["FechaCarga"].ToString()),
                        FechaRealizacion = Convert.ToDateTime(reader["FechaRealizacion"].ToString()),

                    };

                    Lista.Add(ous);
                }

                reader.Close();
                return Lista;
            }
            catch
            {
                throw;
            }
            finally
            {
                oAccesoDatos.Cerrar();
            }
        }

        #endregion

        #region ACTUALIZAR InstanciasEncuentas

        public Int32 ActualizarEncuesta(InstanciasEncuestas oInstancias)
        {
            StringBuilder query = new StringBuilder();

            query.Append("UPDATE ");
            query.Append("InstanciasEncuentas ");
            query.Append("SET ");

            query.Append("IdCurso ='" + oInstancias.IdCurso + "',");
            query.Append("IdMateria ='" + oInstancias.IdMateria + "',");
            query.Append("Legajo ='" + oInstancias.Legajo + "',");
            query.Append("FechaCarga ='" + oInstancias.FechaCarga + "',");
            query.Append("FechaRealizacion ='" + oInstancias.FechaRealizacion + "'");

            query.Append("WHERE ");
            query.Append("IdEncuesta ='" + oInstancias.IdEncuesta + "'");
            query.Append("AND FechaAltaInstEnc = " + oInstancias.FechaRealizacion + "'");


            try
            {
                oAccesoDatos.Abrir();

                int guardo = oAccesoDatos.EjecutarCUD(CommandType.Text, query.ToString());
                return guardo;
            }
            catch
            {
                throw;
            }
            finally
            {
                oAccesoDatos.Cerrar();
            }

        }

        #endregion

    }
}
