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
    public partial class frmColegiosABM : Form
    {
        public frmColegiosABM()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            panelBaja.Height = 22;
            frmColegiosABM.ActiveForm.Height = 352;
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

        private void btnDown_Click(object sender, EventArgs e)
        {
            frmColegiosABM.ActiveForm.Height = 497;
            panelBaja.Height = 167;
            btnDown.Visible = false;
            btnUp.Visible = true;
        }
    }
}
