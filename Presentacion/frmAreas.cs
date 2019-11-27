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
        private Negocio.AreasNeg areasNeg = new Negocio.AreasNeg();
        private int vista = 2;
        private String texto = "";
        private int filaSelecionada = 0;

        public frmAreas()
        {
            InitializeComponent();
            Negocio.AreasNeg.Areas();
            cargarLista();
        }

        private void cargarLista()
        {
            dataGridView1.DataSource = areasNeg.ObtenerAreas(vista, texto);
            dataGridView1.Rows[0].Selected = true;
        }

        private void VerTodos(object sender, EventArgs e)
        {
            vista = 2;
            cargarLista();
        }

        private void VerActivos(object sender, EventArgs e)
        {
            vista = 1;
            cargarLista();
        }

        private void VerInactivos(object sender, EventArgs e)
        {
            vista = 0;
            cargarLista();
        }

        private void BuscarTexto(object sender, EventArgs e)
        {
            if (!toolStripTextBox1.Text.Equals("Buscar..."))
            {
                texto = toolStripTextBox1.Text;
                cargarLista();
            }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void CrearArea(object sender, EventArgs e)
        {
            frmAreasABM abm = new frmAreasABM(Referencia);
            abm.Show();
        }

        private void ModificarArea(object sender, EventArgs e)
        {
            if (filaSelecionada != -1) {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                frmAreasABM abm = new frmAreasABM(Referencia);
                abm.cargarCampos((int)dt.Rows[filaSelecionada]["IdArea"], (String)dt.Rows[filaSelecionada]["Descripcion"],(bool)dt.Rows[filaSelecionada]["Baja"],(String)dt.Rows[filaSelecionada]["FechaBaja"], (String)dt.Rows[filaSelecionada]["CausaBaja"]);
                abm.Show();
            }
        }

        private void EliminarArea(object sender, EventArgs e)
        {
            //areasNeg.EliminarArea((int)((DataTable)dataGridView1.DataSource).Rows[filaSelecionada]["IdArea"]);
            Negocio.AreasNeg.EliminarArea((int)((DataTable)dataGridView1.DataSource).Rows[filaSelecionada]["IdArea"]);
            cargarLista();
        }

        private void Seleccion(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                filaSelecionada = e.RowIndex;
                dataGridView1.Rows[filaSelecionada].Selected = true;
            }
        }

        private void ToolStripTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (toolStripTextBox1.Text.Equals("Buscar..."))
            {
                toolStripTextBox1.Text = "";
            }
        }

        private void Referencia_CheckedChanged(object sender, EventArgs e)
        {
            cargarLista();
        }
    }
}
