using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using ManejoDatos;

namespace Negocio
{
    public class nLogin
    {
        #region VARIABLES Y PROPIEDADES

        //AGREGO LOS MANEJADORES DE DATOS-----------------------------------
        mdUsuarios oMDUsuarios = new mdUsuarios();
        //MD_UsuariosPermisos oMDUsuariosPermisos = new MD_UsuariosPermisos();
        //MD_UsuariosSubCuentas oMDUsuariosSubCuentas = new MD_UsuariosSubCuentas();
        //------------------------------------------------------------------

        #endregion

        #region METODOS

        public Int32 ActualizarUsuario(eUsuarios oUsuario)
        {
            return oMDUsuarios.ActualizarUsuario(oUsuario);
        }

        public eUsuariosVista ListarUsuariosPorUser(string user)
        {
            var usuario = oMDUsuarios.ListarUsuarios(User: user).
                Where(x => x.User.ToString() == user).LastOrDefault();
            return usuario;
        }

        //public List<Entidad_tUsuariosPermisos> LeerPermisosUsuario(string IdUsuario)
        //{
        //    return oMDUsuariosPermisos.ListarUsuariosPermisos(IdUsuario);
        //}

        //public List<Entidad_tSubCuentas> ListarDatosUsuariosSubCuentas(string IdUsuario)
        //{
        //    return oMDUsuariosSubCuentas.ListarDatosUsuariosSubCuentas(IdUsuario);
        //}

        public string ValidarUser(string user, string clave)
        {
            #region VARIABLES Y PROPIEDADES

            eUsuariosVista oUsuario = new eUsuariosVista { };
            eUsuarios oUsuarioAct = new eUsuarios { };
            string validar = "TRUE";

            #endregion

            try
            {
                oUsuario = ListarUsuariosPorUser(user);

                //CONTROL DE USUARIO EXISTENTE-------------------------------
                if (oUsuario == null)
                {
                    validar = "Usuario o Clave Incorrecta...";
                    return validar;
                }
                //SI NO TIENE CLAVE MD5 GENERO UNA---------------------------
                else if (oUsuario.Clave == "")
                {
                    oUsuario.Clave = CrearHash(clave);
                    oUsuarioAct.IdTipoDoc =oUsuario.IdTipoDoc;
                    oUsuarioAct.NroDoc =oUsuario.NroDoc;
                    oUsuarioAct.Clave =oUsuario.Clave;
                    oUsuarioAct.Baja =oUsuario.Baja;
                    oUsuarioAct.FechaBaja =oUsuario.FechaBaja;
                    oUsuarioAct.CausaBaja =oUsuario.CausaBaja;
                    int ActClave = ActualizarUsuario(oUsuarioAct);
                    if (ActClave == 0)
                    {
                        validar = "No se pudo Actualizar la Clave...";
                        return validar;
                    }
                }

                //CONTROL DE CONTRASEÑA CORRECTA-------------------------------
                if (CrearHash(clave.ToUpper()) != oUsuario.Clave)
                {
                    validar = "Usuario o Clave Incorrecta...";
                }

                return validar;
            }
            catch
            {
                throw;
            }
        }

        //GENERA LA CLAVE MD5------------------------------------------------------
        public string CrearHash(string Source)
        {
            byte[] byHash;
            UnicodeEncoding uEncode = new UnicodeEncoding();

            try
            {
                //ALMACENAR LA CADENA ORIGINAL EN UNA MATRIZ DE BYTES--------------
                byte[] bySource = uEncode.GetBytes(Source);
                SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

                //CREAR EL HASH----------------------------------------------------
                byHash = sha1.ComputeHash(bySource);

                //DEVOLVER COMO UNA CADENA CODIFICADA EN BASE64--------------------
                return Convert.ToBase64String(byHash);
            }
            catch
            {
                throw;
            }


        }

        #endregion
    }
}
