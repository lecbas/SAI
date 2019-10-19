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
    public class mdUsuarios
    {
        #region VARIABLES Y PROPIEDADES

        AccesoDatosClass oAccesoDatos = new AccesoDatosClass();

        #endregion

        #region ACTUALIZAR USUARIO

        public Int32 ActualizarUsuario(eUsuarios oUsuario)
        {
            StringBuilder query = new StringBuilder();

            query.Append("UPDATE ");
            query.Append("Usuarios ");
            query.Append("SET ");
            query.Append("IdTipoDoc ='" + oUsuario.IdTipoDoc + "',");
            query.Append("NroDoc ='" + oUsuario.NroDoc + "',");
            query.Append("Clave ='" + oUsuario.Clave + "',");
            query.Append("Baja ='" + oUsuario.Baja + "',");
            query.Append("FechaBaja ='" + oUsuario.FechaBaja + "',");
            query.Append("CausaBaja ='" + oUsuario.CausaBaja + "',");
            query.Append("WHERE ");
            query.Append("usua_idusuario ='" + oUsuario.User + "'");

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

        #region LISTAR USUARIOS

        public List<eUsuariosVista> ListarUsuarios(string User = "")
        {
            List<eUsuariosVista> Lista = new List<eUsuariosVista>();
            IDataReader reader = null;

            StringBuilder query = new StringBuilder();
            query.Append("SELECT ");
            query.Append("User,");
            query.Append("IdTipoDoc, ");
            query.Append("NroDoc, ");
            query.Append("Apellido, ");
            query.Append("Nombre, ");
            query.Append("Clave, ");
            query.Append("Baja, ");
            query.Append("FechaBaja, ");
            query.Append("CausaBaja, ");
            query.Append("FROM ");
            query.Append("UsuariosVista");

            if (User != "")
            {
                query.Append(" WHERE User='" + User + "'");
            }

            try
            {
                oAccesoDatos.Abrir();
                reader = oAccesoDatos.EjecutarConsulta(CommandType.Text, query.ToString());

                while (reader.Read())
                {
                    eUsuariosVista ous = new eUsuariosVista
                    {
                        User = reader["User"].ToString(),
                        IdTipoDoc = Convert.ToInt32(reader["IdTipoDoc"].ToString()),
                        NroDoc = Convert.ToInt32(reader["NroDoc"].ToString()),
                        Apellido = reader["Apellido"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Clave = reader["Clave"].ToString(),
                        Baja=Convert.ToBoolean(reader["Baja"].ToString()),
                        FechaBaja = Convert.ToDateTime(reader["FechaBaja"].ToString()),
                        CausaBaja = reader["CausaBaja"].ToString()
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
    }
}

