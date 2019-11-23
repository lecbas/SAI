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
    public partial class frmAreas : Form
    {
        public frmAreas()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {


        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_MouseEnter(object sender, EventArgs e)
        {
            btnVolver.FlatAppearance.BorderSize = 1;
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.FlatAppearance.BorderSize = 0;

        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(212, 61, 55);
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(44, 75, 114);
        }

        private void btnMaximizar_MouseEnter(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(95, 148, 217);
        }

        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(44, 75, 114);
        }

        private void btnRestaurar_MouseEnter(object sender, EventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(95, 148, 217);
        }

        private void btnRestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(44, 75, 114);
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(95, 148, 217);
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(44, 75, 114);
        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
