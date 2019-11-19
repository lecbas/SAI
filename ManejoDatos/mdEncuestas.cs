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
    public class mdEncuestas
    {

        AccesoDatosClass oAccesoDatos = new AccesoDatosClass();
        #region INSERTART ENCUESTA

        public Int32 InsertarEncuesta(Encuestas oEncuesta)
        {
            StringBuilder query = new StringBuilder();

            query.Append("INSERT INTO ");
            query.Append("Encuestas ");
            query.Append("(IdEncuesta,IdArea,Descripcion,Baja,FechaBaja,CausaBaja) ");
            query.Append("VALUES ( ");
            query.Append("'" + oEncuesta.IdEncuesta + "',");
            query.Append("'" + oEncuesta.IdArea + "',");
            query.Append("'" + oEncuesta.Descripcion + "',");
            query.Append("'" + oEncuesta.Baja + "'");

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

        #region BAJA ENCUESTA

            public Int32 BajaEncuesta(Encuestas oEncuestas)
            {
                StringBuilder query = new StringBuilder();

                query.Append("UPDATE ");
                query.Append("Encuestas ");
                query.Append("SET ");
                query.Append("Baja ='" + oEncuestas.Baja + "',");
                query.Append("FechaBaja ='" + oEncuestas.FechaBaja + "',");
                query.Append("CausaBaja ='" + oEncuestas.CausaBaja + "'");
                query.Append("WHERE ");
                query.Append("IdEncuesta ='" + oEncuestas.IdEncuesta + "'");

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

        #region ACTUALIZAR ENCUESTA

        public Int32 ActualizarEncuesta(Encuestas oEncuestas)
        {
            StringBuilder query = new StringBuilder();

            query.Append("UPDATE ");
            query.Append("Encuestas ");
            query.Append("SET ");

            query.Append("IdArea ='" + oEncuestas.IdArea + "',");
            query.Append("Descripcion ='" + oEncuestas.Descripcion + "',");
            query.Append("Baja ='" + oEncuestas.Baja + "',");
            query.Append("FechaBaja ='" + oEncuestas.FechaBaja + "',");
            query.Append("CausaBaja ='" + oEncuestas.CausaBaja + "'");
            query.Append("WHERE ");
            query.Append("IdEncuesta ='" + oEncuestas.IdEncuesta + "'");

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

