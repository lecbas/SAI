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
    public class mdEncuestasPreguntasOpciones
    {
        #region INSERTART EncuestaPreguntasOpciones
        AccesoDatosClass oAccesoDatos = new AccesoDatosClass();


        public Int32 InsertarEncuestaPreguntasOpciones(EncuestaPreguntasOpciones oEncuestaPreguntasOpciones)
        {
            StringBuilder query = new StringBuilder();

            query.Append("INSERT INTO ");
            query.Append("EncuestaPreguntasOpciones ");

            query.Append("(IdOpcionPregunta,IdPregunta,Orden,Opcion,RequiereOtros,Baja,FechaBaja,CausaBaja) ");
            query.Append("VALUES ( ");
            query.Append("'" + oEncuestaPreguntasOpciones.IdOpcionPregunta + "',");
            query.Append("'" + oEncuestaPreguntasOpciones.idPregunta + "',");
            query.Append("'" + oEncuestaPreguntasOpciones.Orden + "',");
            query.Append("'" + oEncuestaPreguntasOpciones.RequiereOtros + "',");
            query.Append("'" + oEncuestaPreguntasOpciones.Baja + "'");
            
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

        #region LISTAR EncuestaPreguntasOpciones

        public List<EncuestaPreguntasOpciones> ListarEncuestaPreguntasOpciones(String id = "")
        {
            List<EncuestaPreguntasOpciones> Lista = new List<EncuestaPreguntasOpciones>();
            IDataReader reader = null;

            StringBuilder query = new StringBuilder();
            query.Append("SELECT ");
            query.Append("IdOpcionPregunta,");
            query.Append("IdPregunta, ");
            query.Append("Orden, ");
            query.Append("Opcion, ");
            query.Append("RequiereOtros, ");
            query.Append("Baja, ");
            query.Append("FechaBaja, ");
            query.Append("CausaBaja, ");
            query.Append("FROM ");
            query.Append("EncuestaPreguntasOpciones");

            if (id != "")
            {
                query.Append(" WHERE IdOpcionPregunta='" + id + "'");
            }

            try
            {
                oAccesoDatos.Abrir();
                reader = oAccesoDatos.EjecutarConsulta(CommandType.Text, query.ToString());

                while (reader.Read())
                {
                    EncuestaPreguntasOpciones ous = new EncuestaPreguntasOpciones
                    {
                        IdOpcionPregunta = Convert.ToInt32(reader["IdOpcionPregunta"].ToString()),
                        idPregunta = Convert.ToInt32(reader["idPregunta"].ToString()),
                        Orden = Convert.ToInt32(reader["Orden"].ToString()),
                        Opcion = reader["Opcion"].ToString(),
                        RequiereOtros = Convert.ToBoolean(reader["RequiereOtros"].ToString()),
                        Baja = Convert.ToBoolean(reader["Baja"].ToString()),
                        FechaBaja = Convert.ToDateTime(reader["FechaBaja"].ToString()),
                        CausaBaja = Convert.ToInt32(reader["CausaBaja"].ToString()),

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


        #region ACTUALIZAR Encuesta Pregunta Opciones

        public Int32 ActualizarEncuestaPreguntasOpciones(EncuestaPreguntasOpciones oOpciones)
        {
            StringBuilder query = new StringBuilder();

            query.Append("UPDATE ");
            query.Append("EncustaPreguntasOpciones ");
            query.Append("SET ");

            query.Append("idPregunta ='" + oOpciones.idPregunta + "',");
            query.Append("Orden ='" + oOpciones.Orden + "',");
            query.Append("Opcion ='" + oOpciones.Opcion + "',");
            query.Append("RequiereOtros ='" + oOpciones.RequiereOtros + "',");
            query.Append("Baja ='" + oOpciones.Baja + "',");
            query.Append("FechaBaja ='" + oOpciones.FechaBaja + "',");
            query.Append("CausaBaja ='" + oOpciones.CausaBaja + "',");

            query.Append("WHERE ");
            query.Append("idOpcionPreguna ='" + oOpciones.IdOpcionPregunta + "',");
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

        #region BAJA Encuesta Pregunta Opciones

        public Int32 BajaEncuestaPreguntasOpciones(EncuestaPreguntasOpciones oEncuestaPreguntasOpciones)
        {
            StringBuilder query = new StringBuilder();

            query.Append("UPDATE ");
            query.Append("EncuestaPreguntasOpciones ");
            query.Append("SET ");
            query.Append("Baja ='" + oEncuestaPreguntasOpciones.Baja + "',");
            query.Append("FechaBaja ='" + oEncuestaPreguntasOpciones.FechaBaja + "',");
            query.Append("CausaBaja ='" + oEncuestaPreguntasOpciones.CausaBaja + "'");
            query.Append("WHERE ");
            query.Append("IdOpcionPregunta ='" + oEncuestaPreguntasOpciones.IdOpcionPregunta + "'");

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
