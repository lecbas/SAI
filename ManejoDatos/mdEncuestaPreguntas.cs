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
    public class mdEncuestaPreguntas
    {
        #region INSERTART EncuestaPreguntas
        AccesoDatosClass oAccesoDatos = new AccesoDatosClass();


        public Int32 InsertarEncuestaPreguntas(EncuestaPreguntas oEncuestaPreguntas)
        {
            StringBuilder query = new StringBuilder();

            query.Append("INSERT INTO ");
            query.Append("EncuestaPreguntas ");

            query.Append("(IdPregunta,IdEncuesta,Pregunta,Orden,Baja) ");
            query.Append("VALUES ( ");
            query.Append("'" + oEncuestaPreguntas.IdPregunta + "',");
            query.Append("'" + oEncuestaPreguntas.IdEncuesta + "',");
            query.Append("'" + oEncuestaPreguntas.Pregunta + "',");
            query.Append("'" + oEncuestaPreguntas.Orden + "',");
            query.Append("'" + oEncuestaPreguntas.Baja + "'");

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

        #region LISTAR EncuestaPreguntas

        public List<EncuestaPreguntas> ListarEncuestaPreguntas(String id = "")
        {
            List<EncuestaPreguntas> Lista = new List<EncuestaPreguntas>();
            IDataReader reader = null;

            StringBuilder query = new StringBuilder();
            query.Append("SELECT ");
            query.Append("IdPregunta,");
            query.Append("IdEncuesta, ");
            query.Append("Pregunta, ");
            query.Append("Orden, ");
            query.Append("Baja, ");
            query.Append("FechaBaja, ");
            query.Append("CausaBaja, ");
            query.Append("FROM ");
            query.Append("EncuestaPreguntas");

            if (id != "")
            {
                query.Append(" WHERE IdPregunta='" + id + "'");
            }

            try
            {
                oAccesoDatos.Abrir();
                reader = oAccesoDatos.EjecutarConsulta(CommandType.Text, query.ToString());

                while (reader.Read())
                {
                    EncuestaPreguntas ous = new EncuestaPreguntas
                    {
                        IdPregunta = Convert.ToInt32(reader["IdPregunta"].ToString()),
                        IdEncuesta = Convert.ToInt32(reader["IdEncuesta"].ToString()),
                        Pregunta = reader["Pregunta"].ToString(),
                        Orden = Convert.ToInt32(reader["Orden"].ToString()),
                        Baja = Convert.ToBoolean(reader["Baja"].ToString()),
                        FechaBaja = Convert.ToDateTime(reader["FechaBaja"].ToString()),
                        CausaBaja = reader["CausaBaja"].ToString(),

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

        #region ACTUALIZAR ENCUESTA PREGUNTAS

        public Int32 ActualizarEncuentaPreguntas(EncuestaPreguntas oPreguntas)
        {
            StringBuilder query = new StringBuilder();

            query.Append("UPDATE ");
            query.Append("EncuestaPreguntas ");
            query.Append("SET ");

            query.Append("idEncuesta ='" + oPreguntas.IdEncuesta + "',");
            query.Append("Pregunta ='" + oPreguntas.Pregunta + "',");
            query.Append("Orden ='" + oPreguntas.Orden + "',");


            query.Append("WHERE ");
            query.Append("IdPregunta ='" + oPreguntas.IdPregunta + "',");

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

        #region BAJA ENCUESTA PREGUNTAS

        public Int32 BajaEncuestaPreguntas(EncuestaPreguntas oPreguntas)
        {
            StringBuilder query = new StringBuilder();

            query.Append("UPDATE ");
            query.Append("EncuestaPreguntas ");
            query.Append("SET ");

            query.Append("Baja ='" + oPreguntas.Baja + "',");
            query.Append("FechaBaja ='" + oPreguntas.FechaBaja + "',");
            query.Append("CausaBaja ='" + oPreguntas.CausaBaja + "'");


            query.Append("WHERE ");
            query.Append("IdPregunta ='" + oPreguntas.IdPregunta + "'");

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
