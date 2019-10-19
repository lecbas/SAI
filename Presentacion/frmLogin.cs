using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class frmLogin : Form
    {
        #region VARIABLES Y PROPIEDADES

        nLogin oNLogin = new nLogin();
        
        #endregion

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(212, 61, 55);

        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(44, 75, 114);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnIniciar_MouseEnter(object sender, EventArgs e)
        {
            btnIniciar.FlatAppearance.BorderSize = 1;
        }

        private void btnIniciar_MouseLeave(object sender, EventArgs e)
        {
            btnIniciar.FlatAppearance.BorderSize = 0;

        }

        #region MOVER FORMULARIO

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //VALIDO DATOS A ENVIAR--------------------------------------------------------
            string strValidar = ValidarCampos();
            if (strValidar != "TRUE")
            {
                MessageBox.Show(strValidar, "Información");
                return;
            }

            //REALIZO LA VALIDACION DEL USUARIO--------------------------------------------
            string valido = oNLogin.ValidarUser(txtUsuario.Text, txtClave.Text);

            if (valido == "TRUE")
            {
                //CARGO DATOS DE USUARIOS---------------------------------------------------
                clsGlobal.User = oNLogin.ListarUsuariosPorUser(txtUsuario.Text.ToString());

                //CARGO PERMISOS DE USUARIO-----------------------------------------------
                //Class_Global.PERMISOS = oNLogin.LeerPermisosUsuario(Class_Global.USUARIO.Idusuario);

                //CARGO SUBCUENTAS DE USUARIO---------------------------------------------
                //Class_Global.SUBCUENTAS = oNLogin.ListarDatosUsuariosSubCuentas(Class_Global.USUARIO.Idusuario);

                //CARGO EL FORMULARIO PRINCIPAL-------------------------------------------
                this.Hide();
                clsGlobal.Instancia = new frmPrincipal();
                clsGlobal.Instancia.Show();

            }
            else
            {
                MessageBox.Show(valido, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        #region VALIDAR CAMPOS

        private string ValidarCampos()
        {
            string strValidar = "TRUE";

            if (txtUsuario.Text == "USUARIO")
            {
                strValidar = "Debe Ingresar un Nombre de Usuario ...";
                return strValidar;
            }
            else if (txtClave.Text == "CONTRASEÑA")
            {
                strValidar = "Debe Ingresar una Contraseña ...";
                return strValidar;
            }

            return strValidar;
        }

        #endregion

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtUsuario.ForeColor = Color.LightGray;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "CONTRASEÑA")
            {
                txtClave.Text = "";
                txtClave.ForeColor = Color.LightGray;
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.UseSystemPasswordChar = false;
                txtClave.Text = "CONTRASEÑA";
                txtClave.ForeColor = Color.Silver;
            }
        }
    }
}
