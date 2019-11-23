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
    public partial class frmGeneros : Form
    {
        public frmGeneros()
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
        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }
        private void msg()
        {
            MessageBox.Show("buscar ");
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msg();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msg();
        }

        private void btnVolver_MouseEnter(object sender, EventArgs e)
        {
            btnVolverGen.FlatAppearance.BorderSize = 1;
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolverGen.FlatAppearance.BorderSize = 0;

        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrarGen.BackColor = Color.FromArgb(212, 61, 55);
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarGen.BackColor = Color.FromArgb(44, 75, 114);
        }

        private void btnMaximizar_MouseEnter(object sender, EventArgs e)
        {
            btnMaximizarGen.BackColor = Color.FromArgb(95, 148, 217);
        }

        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizarGen.BackColor = Color.FromArgb(44, 75, 114);
        }

        private void btnRestaurar_MouseEnter(object sender, EventArgs e)
        {
            btnRestaurarGen.BackColor = Color.FromArgb(95, 148, 217);
        }

        private void btnRestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnRestaurarGen.BackColor = Color.FromArgb(44, 75, 114);
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            btnMinimizarGen.BackColor = Color.FromArgb(95, 148, 217);
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizarGen.BackColor = Color.FromArgb(44, 75, 114);
        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
