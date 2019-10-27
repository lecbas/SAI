namespace Presentacion
{
    partial class frmEncuestas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEncuestas));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMarco = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tmEncuesta = new System.Windows.Forms.ToolStrip();
            this.buscarToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.buscarToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.descripcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.verToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.verTodasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verActivasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInactivasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPorAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.agregarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.modificarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.eliminarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.agregarInstanciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInstanciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encuestasDataGridView = new System.Windows.Forms.DataGridView();
            this.CodigoEncuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CausaBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.lblEncuestas = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.panelContenedor.SuspendLayout();
            this.panelMarco.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tmEncuesta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encuestasDataGridView)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(85)))), ((int)(((byte)(65)))));
            this.panelContenedor.Controls.Add(this.panelMarco);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(688, 334);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelMarco
            // 
            this.panelMarco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(186)))), ((int)(((byte)(189)))));
            this.panelMarco.Controls.Add(this.btnVolver);
            this.panelMarco.Controls.Add(this.panel1);
            this.panelMarco.Controls.Add(this.encuestasDataGridView);
            this.panelMarco.Controls.Add(this.panelBarraTitulo);
            this.panelMarco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMarco.Location = new System.Drawing.Point(0, 0);
            this.panelMarco.Name = "panelMarco";
            this.panelMarco.Size = new System.Drawing.Size(688, 334);
            this.panelMarco.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(230)))), ((int)(((byte)(223)))));
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(148)))), ((int)(((byte)(217)))));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(230)))), ((int)(((byte)(223)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(581, 290);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(92, 30);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "   &Volver";
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.MouseEnter += new System.EventHandler(this.btnVolver_MouseEnter);
            this.btnVolver.MouseLeave += new System.EventHandler(this.btnVolver_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(230)))), ((int)(((byte)(223)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tmEncuesta);
            this.panel1.Location = new System.Drawing.Point(10, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 28);
            this.panel1.TabIndex = 4;
            // 
            // tmEncuesta
            // 
            this.tmEncuesta.AutoSize = false;
            this.tmEncuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(230)))), ((int)(((byte)(223)))));
            this.tmEncuesta.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tmEncuesta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripTextBox,
            this.buscarToolStripButton,
            this.toolStripSeparator1,
            this.verToolStripButton,
            this.toolStripSeparator2,
            this.agregarToolStripButton,
            this.modificarToolStripButton,
            this.eliminarToolStripButton,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator4,
            this.toolStripSplitButton1});
            this.tmEncuesta.Location = new System.Drawing.Point(0, 0);
            this.tmEncuesta.Name = "tmEncuesta";
            this.tmEncuesta.Size = new System.Drawing.Size(662, 25);
            this.tmEncuesta.TabIndex = 7;
            this.tmEncuesta.TabStop = true;
            this.tmEncuesta.Text = "toolStrip1";
            // 
            // buscarToolStripTextBox
            // 
            this.buscarToolStripTextBox.Name = "buscarToolStripTextBox";
            this.buscarToolStripTextBox.Size = new System.Drawing.Size(200, 25);
            this.buscarToolStripTextBox.Text = "Buscar ...";
            // 
            // buscarToolStripButton
            // 
            this.buscarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buscarToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descripcionToolStripMenuItem,
            this.codigoToolStripMenuItem});
            this.buscarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("buscarToolStripButton.Image")));
            this.buscarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buscarToolStripButton.Name = "buscarToolStripButton";
            this.buscarToolStripButton.Size = new System.Drawing.Size(29, 22);
            this.buscarToolStripButton.Text = "Buscar";
            // 
            // descripcionToolStripMenuItem
            // 
            this.descripcionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("descripcionToolStripMenuItem.Image")));
            this.descripcionToolStripMenuItem.Name = "descripcionToolStripMenuItem";
            this.descripcionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.descripcionToolStripMenuItem.Text = "Descripcion";
            // 
            // codigoToolStripMenuItem
            // 
            this.codigoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("codigoToolStripMenuItem.Image")));
            this.codigoToolStripMenuItem.Name = "codigoToolStripMenuItem";
            this.codigoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.codigoToolStripMenuItem.Text = "Codigo ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // verToolStripButton
            // 
            this.verToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.verToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verTodasToolStripMenuItem,
            this.verActivasToolStripMenuItem,
            this.verInactivasToolStripMenuItem,
            this.verPorAreaToolStripMenuItem});
            this.verToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("verToolStripButton.Image")));
            this.verToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.verToolStripButton.Name = "verToolStripButton";
            this.verToolStripButton.Size = new System.Drawing.Size(29, 22);
            this.verToolStripButton.Text = "Ver";
            // 
            // verTodasToolStripMenuItem
            // 
            this.verTodasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verTodasToolStripMenuItem.Image")));
            this.verTodasToolStripMenuItem.Name = "verTodasToolStripMenuItem";
            this.verTodasToolStripMenuItem.ShortcutKeyDisplayString = "Alt+T";
            this.verTodasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.verTodasToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.verTodasToolStripMenuItem.Text = "Ver Todas";
            // 
            // verActivasToolStripMenuItem
            // 
            this.verActivasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verActivasToolStripMenuItem.Image")));
            this.verActivasToolStripMenuItem.Name = "verActivasToolStripMenuItem";
            this.verActivasToolStripMenuItem.ShortcutKeyDisplayString = "Alt+A";
            this.verActivasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.verActivasToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.verActivasToolStripMenuItem.Text = "Ver Activas";
            // 
            // verInactivasToolStripMenuItem
            // 
            this.verInactivasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verInactivasToolStripMenuItem.Image")));
            this.verInactivasToolStripMenuItem.Name = "verInactivasToolStripMenuItem";
            this.verInactivasToolStripMenuItem.ShortcutKeyDisplayString = "Alt+I";
            this.verInactivasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.verInactivasToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.verInactivasToolStripMenuItem.Text = "Ver Inactivas";
            // 
            // verPorAreaToolStripMenuItem
            // 
            this.verPorAreaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verPorAreaToolStripMenuItem.Image")));
            this.verPorAreaToolStripMenuItem.Name = "verPorAreaToolStripMenuItem";
            this.verPorAreaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
            this.verPorAreaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.verPorAreaToolStripMenuItem.Text = "Ver por Area";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // agregarToolStripButton
            // 
            this.agregarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.agregarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("agregarToolStripButton.Image")));
            this.agregarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.agregarToolStripButton.Name = "agregarToolStripButton";
            this.agregarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.agregarToolStripButton.Text = "Nuevo";
            // 
            // modificarToolStripButton
            // 
            this.modificarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.modificarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripButton.Image")));
            this.modificarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modificarToolStripButton.Name = "modificarToolStripButton";
            this.modificarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.modificarToolStripButton.Text = "Modificar";
            // 
            // eliminarToolStripButton
            // 
            this.eliminarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eliminarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripButton.Image")));
            this.eliminarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eliminarToolStripButton.Name = "eliminarToolStripButton";
            this.eliminarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.eliminarToolStripButton.Text = "Eliminar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.toolStripSeparator5,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.toolStripSeparator6,
            this.agregarInstanciaToolStripMenuItem,
            this.verInstanciaToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(54, 22);
            this.toolStripSplitButton1.Text = "Menu";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(196, 6);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripMenuItem.Image")));
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(196, 6);
            // 
            // agregarInstanciaToolStripMenuItem
            // 
            this.agregarInstanciaToolStripMenuItem.Name = "agregarInstanciaToolStripMenuItem";
            this.agregarInstanciaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.agregarInstanciaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.agregarInstanciaToolStripMenuItem.Text = "Agregar Instancia";
            // 
            // verInstanciaToolStripMenuItem
            // 
            this.verInstanciaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verInstanciaToolStripMenuItem.Image")));
            this.verInstanciaToolStripMenuItem.Name = "verInstanciaToolStripMenuItem";
            this.verInstanciaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.verInstanciaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.verInstanciaToolStripMenuItem.Text = "Ver Instancias";
            // 
            // encuestasDataGridView
            // 
            this.encuestasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.encuestasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoEncuesta,
            this.Area,
            this.Descripcion,
            this.FechaBaja,
            this.CausaBaja});
            this.encuestasDataGridView.Location = new System.Drawing.Point(10, 67);
            this.encuestasDataGridView.Name = "encuestasDataGridView";
            this.encuestasDataGridView.Size = new System.Drawing.Size(664, 214);
            this.encuestasDataGridView.TabIndex = 2;
            // 
            // CodigoEncuesta
            // 
            this.CodigoEncuesta.HeaderText = "CodigoEncuesta";
            this.CodigoEncuesta.Name = "CodigoEncuesta";
            // 
            // Area
            // 
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 150;
            // 
            // FechaBaja
            // 
            this.FechaBaja.HeaderText = "FechaBaja";
            this.FechaBaja.Name = "FechaBaja";
            // 
            // CausaBaja
            // 
            this.CausaBaja.HeaderText = "CausaBaja";
            this.CausaBaja.Name = "CausaBaja";
            this.CausaBaja.Width = 150;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.panelBarraTitulo.Controls.Add(this.lblEncuestas);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(688, 30);
            this.panelBarraTitulo.TabIndex = 1;
            this.panelBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBarraTitulo_Paint);
            // 
            // lblEncuestas
            // 
            this.lblEncuestas.AutoSize = true;
            this.lblEncuestas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncuestas.ForeColor = System.Drawing.Color.White;
            this.lblEncuestas.Location = new System.Drawing.Point(9, 7);
            this.lblEncuestas.Name = "lblEncuestas";
            this.lblEncuestas.Size = new System.Drawing.Size(96, 17);
            this.lblEncuestas.TabIndex = 9;
            this.lblEncuestas.Text = "SAI - Encuestas";
            this.lblEncuestas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEncuestas.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(635, 5);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Padding = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMaximizar.TabIndex = 8;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.MouseEnter += new System.EventHandler(this.btnMaximizar_MouseEnter);
            this.btnMaximizar.MouseLeave += new System.EventHandler(this.btnMaximizar_MouseLeave);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Location = new System.Drawing.Point(635, 5);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Padding = new System.Windows.Forms.Padding(2);
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnRestaurar.TabIndex = 7;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.MouseEnter += new System.EventHandler(this.btnRestaurar_MouseEnter);
            this.btnRestaurar.MouseLeave += new System.EventHandler(this.btnRestaurar_MouseLeave);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(657, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnCerrar_MouseEnter);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(613, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Padding = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.MouseEnter += new System.EventHandler(this.btnMinimizar_MouseEnter);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.btnMinimizar_MouseLeave);
            // 
            // frmEncuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 334);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEncuestas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCarreras";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCarreras_KeyDown);
            this.panelContenedor.ResumeLayout(false);
            this.panelMarco.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tmEncuesta.ResumeLayout(false);
            this.tmEncuesta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encuestasDataGridView)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelMarco;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label lblEncuestas;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.DataGridView encuestasDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip tmEncuesta;
        private System.Windows.Forms.ToolStripTextBox buscarToolStripTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton agregarToolStripButton;
        private System.Windows.Forms.ToolStripButton modificarToolStripButton;
        private System.Windows.Forms.ToolStripButton eliminarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ToolStripDropDownButton verToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem verTodasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verActivasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInactivasToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton buscarToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem descripcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPorAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem agregarInstanciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInstanciaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoEncuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn CausaBaja;
    }
}