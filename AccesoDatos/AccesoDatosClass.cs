using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesoDatosClass
    {

        #region VARIABLES Y PROPIEDADES

        private string cadena = string.Empty;

        public OdbcConnection oConexion { get; set; }

        public OdbcCommand oComando { get; set; }

        public OdbcDataReader Lector { get; set; }
                
        #endregion

        #region CONSTRUCTORES

        public AccesoDatosClass()
        {
            
            cadena = "DSN=BDSAI;UID=postgres;PWD=" + "lecbas09" + ";";

            oConexion = new OdbcConnection();

            oComando = new OdbcCommand();

        }

        #endregion

        #region METODOS

        public void Abrir()
        {
            if (oConexion.State == ConnectionState.Open)
            {
                return;
            }

            oConexion.ConnectionString = cadena;

            try
            {
                oConexion.Open();
            }
            catch
            {
                throw;
            }
        }

        public void Cerrar()
        {
            if (oConexion.State == ConnectionState.Closed)
            {
                return;
            }

            oConexion.Close();
        }

        public int EjecutarCUD(CommandType TipoComando, string Consulta)
        {

            oComando.Connection = oConexion;

            oComando.CommandType = TipoComando;

            oComando.CommandText = Consulta;

            int Retorno = 0;

            try
            {
                Retorno = oComando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }

            return Retorno;
        }

        public OdbcDataReader EjecutarConsulta(CommandType TipoComando, string Consulta)
        {

            Lector = null;

            oComando.Connection = oConexion;

            oComando.CommandType = TipoComando;

            oComando.CommandText = Consulta;

            try
            {
                Lector = oComando.ExecuteReader();
            }
            catch
            {
                throw;
            }

            return Lector;
        }

        #endregion

    }

}

