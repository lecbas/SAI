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
    public partial class frmMateriasABM : Form
    {
        public frmMateriasABM()
        {
            InitializeComponent();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            frmMateriasABM.ActiveForm.Height = 423;
            panelBajaMatABM.Height = 162;
            btnDownMatABM.Visible = false;
            btnUpMatABM.Visible = true;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            panelBajaMatABM.Height = 22;
            frmMateriasABM.ActiveForm.Height = 282;
            btnUpMatABM.Visible = false;
            btnDownMatABM.Visible = true;
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrarMatABM.BackColor = Color.FromArgb(212, 61, 55);
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarMatABM.BackColor = Color.FromArgb(44, 75, 114);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
