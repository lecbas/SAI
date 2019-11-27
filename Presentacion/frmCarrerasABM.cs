using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmCarrerasABM : Form
    {
        int idCarrera = -1;
        private Negocio.CarrerasNeg carrerasNeg = new Negocio.CarrerasNeg();
        CheckBox formAreas = new CheckBox();

        public frmCarrerasABM()
        {
            InitializeComponent();
            cmbTipocarrera.DataSource = carrerasNeg.obtenerTipos();
            cmbTipocarrera.DisplayMember = "Descripcion";
            cmbTipocarrera.ValueMember = "IdTipoCarrera";
        }

        public frmCarrerasABM(CheckBox referencia)
        {
            InitializeComponent();
            formAreas = referencia;
            cmbTipocarrera.DataSource = carrerasNeg.obtenerTipos();
            cmbTipocarrera.DisplayMember = "Descripcion";
            cmbTipocarrera.ValueMember = "IdTipoCarrera";
        }

        public void cargarCampos(int id, int idTipo, String descipcion, String codigo,bool estado, String fechaBaja, String causaBaja)
        {
            idCarrera = id;
            cmbTipocarrera.SelectedValue = idTipo;
            txtNombre.Text = descipcion;
            txtCodigo.Text = codigo;
            chkBaja.Checked = estado;
            txtFechabaja.Text = fechaBaja;
            txtCausabaja.Text = causaBaja;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            frmCarrerasABM.ActiveForm.Height = 423;
            panelBaja.Height = 162;
            btnDown.Visible = false;
            btnUp.Visible = true;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            panelBaja.Height = 22;
            frmCarrerasABM.ActiveForm.Height = 282;
            btnUp.Visible = false;
            btnDown.Visible = true;
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
            this.Close();
            this.Dispose();
        }

        private void GuardarCarrera(object sender, EventArgs e)
        {
            String fecha = "", causa = "";
            if (chkBaja.Checked == true) { fecha = txtFechabaja.Text; causa = txtCausabaja.Text; }
            bool resultado;
            if (idCarrera == -1)
            {
                resultado = Negocio.CarrerasNeg.AgregarCarrera(Int32.Parse(cmbTipocarrera.SelectedValue.ToString()), txtNombre.Text, txtCodigo.Text, chkBaja.Checked, fecha, causa);
            }
            else
            {
                resultado = Negocio.CarrerasNeg.ModificarCarrera(idCarrera,Int32.Parse(cmbTipocarrera.SelectedValue.ToString()), txtNombre.Text, txtCodigo.Text, chkBaja.Checked, fecha, causa);
            }
            if (resultado)
            {
                formAreas.Checked = !formAreas.Checked;
                this.Close();
                this.Dispose();
            }
        }

        private void ChkBaja_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBaja.Checked == true)
            {
                txtFechabaja.ReadOnly = false;
                txtCausabaja.ReadOnly = false;
            }
            else
            {
                txtFechabaja.ReadOnly = true;
                txtCausabaja.ReadOnly = true;
            }
        }
    }
}
