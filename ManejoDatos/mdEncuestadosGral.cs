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
    public class mdEncuestadosGral
    {
        #region INSERTART EncuestadosGral
        AccesoDatosClass oAccesoDatos = new AccesoDatosClass();


        public Int32 InsertarEncuestadosGral(EncuestadosGral oEncuestadosGral)
        {
            StringBuilder query = new StringBuilder();

            query.Append("INSERT INTO ");
            query.Append("EncuestadosGral ");

            query.Append("(IdEncuestado,IdEncuesta,FechaAltaInsEnc,Edad,IdGenero,Cp,IdColegio,Idorientacion,Pase,IdTipoEstablecimiento,IdCarrera,Comentarios) ");
            query.Append("VALUES ( ");
            query.Append("'" + oEncuestadosGral.IdEncuestado + "',");
            query.Append("'" + oEncuestadosGral.IdEncuesta + "',");
            query.Append("'" + oEncuestadosGral.FechaAltaInstEnc + "',");
            query.Append("'" + oEncuestadosGral.Edad + "',");
            query.Append("'" + oEncuestadosGral.IdGenero + "',");
            query.Append("'" + oEncuestadosGral.Cp + "',");
            query.Append("'" + oEncuestadosGral.IdColegio + "',");
            query.Append("'" + oEncuestadosGral.IdOrientacion + "',");
            query.Append("'" + oEncuestadosGral.Pase + "',");
            query.Append("'" + oEncuestadosGral.IdTipoEstablecimiento + "',");
            query.Append("'" + oEncuestadosGral.IdCarrera + "',");
            query.Append("'" + oEncuestadosGral.Comentarios + "'");
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

        #region LISTAR EncuestadosGral

        public List<EncuestadosGral> ListarEncuestadosGral(String id = "")
        {
            List<EncuestadosGral> Lista = new List<EncuestadosGral>();
            IDataReader reader = null;

            StringBuilder query = new StringBuilder();
            query.Append("SELECT ");
            query.Append("IdEncuestado,");
            query.Append("IdEncuesta, ");
            query.Append("FechaAltaInstEnc, ");
            query.Append("Edad, ");
            query.Append("IdGenero, ");
            query.Append("Cp, ");
            query.Append("IdColegio, ");
            query.Append("IdOrientacion, ");
            query.Append("Pase, ");
            query.Append("IdTipoEstablecimiento, ");
            query.Append("IdCarrera, ");
            query.Append("Comentarios, ");
            query.Append("FROM ");
            query.Append("EncuestadosGral");

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
                    EncuestadosGral ous = new EncuestadosGral
                    {
                        IdEncuestado = Convert.ToInt32(reader["IdEncuestado"].ToString()),
                        IdEncuesta = Convert.ToInt32(reader["IdEncuesta"].ToString()),
                        FechaAltaInstEnc = Convert.ToDateTime(reader["FechaAltaInstEnC"].ToString()),
                        Edad = Convert.ToInt32(reader["Edad"].ToString()),
                        IdGenero = Convert.ToInt32(reader["IdGenero"].ToString()),
                        Cp = reader["Cp"].ToString(),
                        IdColegio = Convert.ToInt32(reader["IdColegio"].ToString()),
                        IdOrientacion = Convert.ToInt32(reader["IdOrientacion"].ToString()),
                        Pase = Convert.ToBoolean(reader["Pase"].ToString()),
                        IdTipoEstablecimiento = Convert.ToInt32(reader["IdTipoEstablecimiento"].ToString()),
                        IdCarrera = Convert.ToInt32(reader["IdCarrera"].ToString()),
                        Comentarios = reader["Comentarios"].ToString(),

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

        #region ACTUALIZAR ENCUESTAGRAL

        public Int32 ActualizarEncuestaGRAL(EncuestadosGral oEncuestados)
        {
            StringBuilder query = new StringBuilder();

            query.Append("UPDATE ");
            query.Append("EncuestadosGral ");
            query.Append("SET ");

            query.Append("idEncuesta ='" + oEncuestados.IdEncuesta + "',");
            query.Append("FechaAltaInstEnc ='" + oEncuestados.FechaAltaInstEnc + "',");
            query.Append("Edad ='" + oEncuestados.Edad + "',");
            query.Append("idGenero ='" + oEncuestados.IdEncuesta + "',");
            query.Append("Cp ='" + oEncuestados.Cp + "',");
            query.Append("idColegio ='" + oEncuestados.IdColegio + "',");
            query.Append("idorientacion ='" + oEncuestados.IdOrientacion + "',");
            query.Append("Pase ='" + oEncuestados.Pase + "',");
            query.Append("IdTipoEstablecimiento ='" + oEncuestados.IdTipoEstablecimiento + "',");
            query.Append("idCarrera ='" + oEncuestados.IdCarrera + "',");
            query.Append("Comentarios ='" + oEncuestados.Comentarios + "',");


            query.Append("WHERE ");
            query.Append("IdEncuestado ='" + oEncuestados.IdEncuestado + "'");

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