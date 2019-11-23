namespace Presentacion
{
    partial class frmEstablecimientosABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstablecimientosABM));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMarco = new System.Windows.Forms.Panel();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panelBaja = new System.Windows.Forms.Panel();
            this.lblCausa = new System.Windows.Forms.Label();
            this.lblFechabaja = new System.Windows.Forms.Label();
            this.txtCausabaja = new System.Windows.Forms.TextBox();
            this.txtFechabaja = new System.Windows.Forms.TextBox();
            this.chkBaja = new System.Windows.Forms.CheckBox();
            this.btnUp = new System.Windows.Forms.PictureBox();
            this.btnDown = new System.Windows.Forms.PictureBox();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelContenedor.SuspendLayout();
            this.panelMarco.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelBaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDown)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(85)))), ((int)(((byte)(65)))));
            this.panelContenedor.Controls.Add(this.panelMarco);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(504, 230);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelMarco
            // 
            this.panelMarco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(186)))), ((int)(((byte)(189)))));
            this.panelMarco.Controls.Add(this.panelDatos);
            this.panelMarco.Controls.Add(this.panelBotones);
            this.panelMarco.Controls.Add(this.panelBaja);
            this.panelMarco.Controls.Add(this.panelBarraTitulo);
            this.panelMarco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMarco.Location = new System.Drawing.Point(0, 0);
            this.panelMarco.Name = "panelMarco";
            this.panelMarco.Size = new System.Drawing.Size(504, 230);
            this.panelMarco.TabIndex = 0;
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(230)))), ((int)(((byte)(223)))));
            this.panelDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatos.Controls.Add(this.lblDescrip);
            this.panelDatos.Controls.Add(this.txtDescrip);
            this.panelDatos.Location = new System.Drawing.Point(10, 38);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(481, 100);
            this.panelDatos.TabIndex = 13;
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrip.Location = new System.Drawing.Point(10, 9);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(69, 15);
            this.lblDescrip.TabIndex = 12;
            this.lblDescrip.Text = "Descripcion";
            this.lblDescrip.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDescrip
            // 
            this.txtDescrip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrip.Location = new System.Drawing.Point(13, 27);
            this.txtDescrip.MaxLength = 50;
            this.txtDescrip.Multiline = true;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(455, 57);
            this.txtDescrip.TabIndex = 0;
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(230)))), ((int)(((byte)(223)))));
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Controls.Add(this.btnVolver);
            this.panelBotones.Location = new System.Drawing.Point(10, 179);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(484, 41);
            this.panelBotones.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(230)))), ((int)(((byte)(223)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(148)))), ((int)(((byte)(217)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(230)))), ((int)(((byte)(223)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(275, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 30);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "   &Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
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
            this.btnVolver.Location = new System.Drawing.Point(376, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(92, 30);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "   &Volver";
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // panelBaja
            // 
            this.panelBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(183)))), ((int)(((byte)(153)))));
            this.panelBaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBaja.Controls.Add(this.lblCausa);
            this.panelBaja.Controls.Add(this.lblFechabaja);
            this.panelBaja.Controls.Add(this.txtCausabaja);
            this.panelBaja.Controls.Add(this.txtFechabaja);
            this.panelBaja.Controls.Add(this.chkBaja);
            this.panelBaja.Controls.Add(this.btnUp);
            this.panelBaja.Controls.Add(this.btnDown);
            this.panelBaja.Location = new System.Drawing.Point(10, 146);
            this.panelBaja.Name = "panelBaja";
            this.panelBaja.Size = new System.Drawing.Size(481, 22);
            this.panelBaja.TabIndex = 9;
            // 
            // lblCausa
            // 
            this.lblCausa.AutoSize = true;
            this.lblCausa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCausa.ForeColor = System.Drawing.Color.Black;
            this.lblCausa.Location = new System.Drawing.Point(10, 80);
            this.lblCausa.Name = "lblCausa";
            this.lblCausa.Size = new System.Drawing.Size(64, 15);
            this.lblCausa.TabIndex = 15;
            this.lblCausa.Text = "Causa Baja";
            this.lblCausa.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblFechabaja
            // 
            this.lblFechabaja.AutoSize = true;
            this.lblFechabaja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechabaja.ForeColor = System.Drawing.Color.Black;
            this.lblFechabaja.Location = new System.Drawing.Point(10, 32);
            this.lblFechabaja.Name = "lblFechabaja";
            this.lblFechabaja.Size = new System.Drawing.Size(63, 15);
            this.lblFechabaja.TabIndex = 14;
            this.lblFechabaja.Text = "Fecha Baja";
            this.lblFechabaja.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCausabaja
            // 
            this.txtCausabaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCausabaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCausabaja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCausabaja.Location = new System.Drawing.Point(13, 98);
            this.txtCausabaja.Multiline = true;
            this.txtCausabaja.Name = "txtCausabaja";
            this.txtCausabaja.Size = new System.Drawing.Size(455, 54);
            this.txtCausabaja.TabIndex = 5;
            // 
            // txtFechabaja
            // 
            this.txtFechabaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechabaja.Enabled = false;
            this.txtFechabaja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechabaja.Location = new System.Drawing.Point(13, 50);
            this.txtFechabaja.Multiline = true;
            this.txtFechabaja.Name = "txtFechabaja";
            this.txtFechabaja.Size = new System.Drawing.Size(131, 23);
            this.txtFechabaja.TabIndex = 4;
            // 
            // chkBaja
            // 
            this.chkBaja.AutoSize = true;
            this.chkBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBaja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBaja.ForeColor = System.Drawing.Color.Black;
            this.chkBaja.Location = new System.Drawing.Point(13, 1);
            this.chkBaja.Name = "chkBaja";
            this.chkBaja.Size = new System.Drawing.Size(45, 19);
            this.chkBaja.TabIndex = 3;
            this.chkBaja.Text = "Baja";
            this.chkBaja.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Location = new System.Drawing.Point(230, 1);
            this.btnUp.Name = "btnUp";
            this.btnUp.Padding = new System.Windows.Forms.Padding(2);
            this.btnUp.Size = new System.Drawing.Size(20, 20);
            this.btnUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnUp.TabIndex = 8;
            this.btnUp.TabStop = false;
            this.btnUp.Visible = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(230, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Padding = new System.Windows.Forms.Padding(2);
            this.btnDown.Size = new System.Drawing.Size(20, 20);
            this.btnDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnDown.TabIndex = 7;
            this.btnDown.TabStop = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(75)))), ((int)(((byte)(114)))));
            this.panelBarraTitulo.Controls.Add(this.lblTitulo);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(504, 30);
            this.panelBarraTitulo.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(9, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(171, 17);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "SAI - Nueva Establecimiento";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(474, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnCerrar_MouseEnter);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            // 
            // frmEstablecimientosABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 230);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstablecimientosABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCarrerasABM";
            this.panelContenedor.ResumeLayout(false);
            this.panelMarco.ResumeLayout(false);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.panelBaja.ResumeLayout(false);
            this.panelBaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDown)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelMarco;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panelBaja;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox btnDown;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label lblCausa;
        private System.Windows.Forms.Label lblFechabaja;
        private System.Windows.Forms.TextBox txtCausabaja;
        private System.Windows.Forms.TextBox txtFechabaja;
        private System.Windows.Forms.CheckBox chkBaja;
        private System.Windows.Forms.PictureBox btnUp;
    }
}