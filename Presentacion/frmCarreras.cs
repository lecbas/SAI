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
    public partial class frmCarreras : Form
    {
        private Negocio.CarrerasNeg carrerasNeg = new Negocio.CarrerasNeg();
        private int vista = 2;
        private String texto = "";
        private int filaSelecionada = 0;
        private int filtro = 1;

        public frmCarreras()
        {
            InitializeComponent();
            Negocio.CarrerasNeg.Carreras();
            cargarLista();
        }

        private void cargarLista()
        {
            dataGridView1.DataSource = carrerasNeg.ObtenerAreas(vista, texto, filtro);
            if(dataGridView1.Rows.Count > 0)dataGridView1.Rows[0].Selected = true;
        }

        private void filtrarDescripcion(object sender, EventArgs e)
        {
            filtro = 1;
            cargarLista();
        }

        private void filtrarCodigoInterno(object sender, EventArgs e)
        {
            filtro = 2;
            cargarLista();
        }

        private void filtrarTipo(object sender, EventArgs e)
        {
            filtro = 3;
            cargarLista();
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sdsdasda");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            msg();

        }

        private void frmCarreras_KeyDown(object sender, KeyEventArgs e)
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

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msg();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msg();
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

        private void CrearCarrera(object sender, EventArgs e)
        {
            frmCarrerasABM abm = new frmCarrerasABM(Referencia);
            abm.Show();
        }

        private void ModificarCarrera(object sender, EventArgs e)
        {
            if (filaSelecionada != -1)
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                frmCarrerasABM abm = new frmCarrerasABM(Referencia);
                abm.cargarCampos((int)dt.Rows[filaSelecionada]["IdCarrera"], (int)dt.Rows[filaSelecionada]["IdTipoCarrera"], (String)dt.Rows[filaSelecionada]["Descripcion"], (String)dt.Rows[filaSelecionada]["CodigoInterno"], (bool)dt.Rows[filaSelecionada]["Baja"], (String)dt.Rows[filaSelecionada]["FechaBaja"], (String)dt.Rows[filaSelecionada]["CausaBaja"]);
                abm.Show();
            }
        }

        private void EliminarCarrera(object sender, EventArgs e)
        {
            Negocio.CarrerasNeg.EliminarCarrera((int)((DataTable)dataGridView1.DataSource).Rows[filaSelecionada]["IdCarrera"]);
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
