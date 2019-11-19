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
    public class mdEncuestadosRespuestas
    {
        #region INSERTART EncuestadosRespuestas
        AccesoDatosClass oAccesoDatos = new AccesoDatosClass();


        public Int32 InsertarEncuestadosRespuestas(EncuestadosRespuestas oEncuestadosRespuestas)
        {
            StringBuilder query = new StringBuilder();

            query.Append("INSERT INTO ");
            query.Append("EncuestadosRespuestas ");

            query.Append("(IdEncunestado,IdOpcionPregunta,Otros) ");
            query.Append("VALUES ( ");
            query.Append("'" + oEncuestadosRespuestas.IdEncuestado + "',");
            query.Append("'" + oEncuestadosRespuestas.IdOpcionPregunta + "',");
            query.Append("'" + oEncuestadosRespuestas.Otros + "'");
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

        #region LISTAR EncuestadosRespuestas

        public List<EncuestadosRespuestas> ListarEncuestadosRespuestas(String id = "")
        {
            List<EncuestadosRespuestas> Lista = new List<EncuestadosRespuestas>();
            IDataReader reader = null;

            StringBuilder query = new StringBuilder();
            query.Append("SELECT ");
            query.Append("IdEncuestado,");
            query.Append("IdOpcionPregunta, ");
            query.Append("Otros, ");

            if (id != "")
            {
                query.Append(" WHERE IdEncuestado='" + id + "'");
            }

            try
            {
                oAccesoDatos.Abrir();
                reader = oAccesoDatos.EjecutarConsulta(CommandType.Text, query.ToString());

                while (reader.Read())
                {
                    EncuestadosRespuestas ous = new EncuestadosRespuestas
                    {
                        IdEncuestado = Convert.ToInt32(reader["IdEncuestado"].ToString()),
                        IdOpcionPregunta = Convert.ToInt32(reader["IdOpcionPregunta"].ToString()),
                        Otros = reader["Otros"].ToString(),

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

        #region ACTUALIZAR EncuestadosRespuesta

        public Int32 ActualizarEncuestadosRespuesta(EncuestadosRespuestas oRespuestas)
        {
            StringBuilder query = new StringBuilder();

            query.Append("UPDATE ");
            query.Append("EncuestadosRespuestas ");
            query.Append("SET ");

            query.Append("Otros ='" + oRespuestas.Otros + "',");



            query.Append("WHERE ");
            query.Append("idEncuestado ='" + oRespuestas.IdEncuestado + "'");
            query.Append("AND idOpcionPregunta = " + oRespuestas.IdOpcionPregunta + "'");

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
