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
    public partial class frmMaterias : Form
    {
        public frmMaterias()
        {
            InitializeComponent();
        }


        private void toolStripButton1Mat_Click(object sender, EventArgs e)
        {
            msg();

        }

        private void frmMaterias_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyData==( Keys.Alt | Keys.B))
            //{
            //    msg();
            //}
        }
        private void msg()
        {
            MessageBox.Show("buscar ");
        }

        private void buscarToolStripMenuItemMat_Click(object sender, EventArgs e)
        {
            msg();
        }

        private void toolStripSplitButton1Mat_ButtonClick(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItemMat_Click(object sender, EventArgs e)
        {
            msg();
        }

        private void btnVolverMat_MouseEnter(object sender, EventArgs e)
        {
            btnVolverMat.FlatAppearance.BorderSize = 1;
        }

        private void btnVolverMat_MouseLeave(object sender, EventArgs e)
        {
            btnVolverMat.FlatAppearance.BorderSize = 0;

        }

        private void btnCerrarMat_MouseEnter(object sender, EventArgs e)
        {
            btnCerrarMat.BackColor = Color.FromArgb(212, 61, 55);
        }

        private void btnCerrarMat_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarMat.BackColor = Color.FromArgb(44, 75, 114);
        }

        private void btnMaximizarMat_MouseEnter(object sender, EventArgs e)
        {
            btnMaximizarMat.BackColor = Color.FromArgb(95, 148, 217);
        }

        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizarMat.BackColor = Color.FromArgb(44, 75, 114);
        }

        private void btnRestaurar_MouseEnter(object sender, EventArgs e)
        {
            btnRestaurarMat.BackColor = Color.FromArgb(95, 148, 217);
        }

        private void btnRestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnRestaurarMat.BackColor = Color.FromArgb(44, 75, 114);
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            btnMinimizarMat.BackColor = Color.FromArgb(95, 148, 217);
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizarMat.BackColor = Color.FromArgb(44, 75, 114);
        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
