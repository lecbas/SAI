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
    public partial class frmAreasABM : Form
    {
        int idArea = -1;
        private Negocio.AreasNeg areasNeg = new Negocio.AreasNeg();
        CheckBox formAreas = new CheckBox();

        public frmAreasABM()
        {
            InitializeComponent();
        }

        public frmAreasABM(CheckBox referencia)
        {
            InitializeComponent();
            formAreas = referencia;
        }

        public void cargarCampos(int id, String descipcion, bool estado, String fechaBaja, String causaBaja)
        {
            idArea = id;
            txtDescrip.Text = descipcion;
            chkBaja.Checked = estado;
            txtFechabaja.Text = fechaBaja;
            txtCausabaja.Text = causaBaja;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            frmAreasABM.ActiveForm.Height = 371;
            panelBaja.Height = 162;
            btnDown.Visible = false;
            btnUp.Visible = true;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            panelBaja.Height = 22;
            frmAreasABM.ActiveForm.Height = 230;
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

        private void GuardarArea(object sender, EventArgs e)
        {
            String fecha = "", causa = "";
            if(chkBaja.Checked == true) { fecha = txtFechabaja.Text; causa = txtCausabaja.Text;}
            bool resultado;
            if(idArea == -1)
            {
                //areasNeg.AgregarArea(txtDescrip.Text, chkBaja.Checked, txtFechabaja.Text, txtCausabaja.Text);
                resultado = Negocio.AreasNeg.AgregarArea(txtDescrip.Text, chkBaja.Checked, fecha, causa);
            }
            else
            {
                //areasNeg.ModificarArea(idArea, txtDescrip.Text, chkBaja.Checked, txtFechabaja.Text, txtCausabaja.Text);
                resultado = Negocio.AreasNeg.ModificarArea(idArea,txtDescrip.Text, chkBaja.Checked, fecha, causa);
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
            if(chkBaja.Checked == true)
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
