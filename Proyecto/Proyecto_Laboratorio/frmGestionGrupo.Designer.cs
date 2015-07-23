namespace Proyecto_Laboratorio
{
    partial class frmGestionGrupo
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.pnlBusquedaGrupos = new System.Windows.Forms.Panel();
            this.btnGruposNoForm = new System.Windows.Forms.Button();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.lblTituloBusquedaGrupos = new System.Windows.Forms.Label();
            this.btnListarGrupos = new System.Windows.Forms.Button();
            this.pnlBusquedaIntegrantes = new System.Windows.Forms.Panel();
            this.btnEnviarInforme = new System.Windows.Forms.Button();
            this.lblNombreGrupo = new System.Windows.Forms.Label();
            this.tbNombreGrupo = new System.Windows.Forms.TextBox();
            this.lblTituloBusquedaIntegrantes = new System.Windows.Forms.Label();
            this.btnListarIntegrantes = new System.Windows.Forms.Button();
            this.pnlEliminar = new System.Windows.Forms.Panel();
            this.lblTituloEliminar = new System.Windows.Forms.Label();
            this.lblNombreGrupoElim = new System.Windows.Forms.Label();
            this.tbNombreGrupoElim = new System.Windows.Forms.TextBox();
            this.btnEliminarGrupo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.pnlBusquedaGrupos.SuspendLayout();
            this.pnlBusquedaIntegrantes.SuspendLayout();
            this.pnlEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(124, 33);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(329, 234);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.SelectionChanged += new System.EventHandler(this.dgvDatos_SelectionChanged);
            // 
            // pnlBusquedaGrupos
            // 
            this.pnlBusquedaGrupos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBusquedaGrupos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBusquedaGrupos.Controls.Add(this.btnGruposNoForm);
            this.pnlBusquedaGrupos.Controls.Add(this.lblOpcion);
            this.pnlBusquedaGrupos.Controls.Add(this.lblBusqueda);
            this.pnlBusquedaGrupos.Controls.Add(this.tbBusqueda);
            this.pnlBusquedaGrupos.Controls.Add(this.cbxFiltro);
            this.pnlBusquedaGrupos.Controls.Add(this.lblTituloBusquedaGrupos);
            this.pnlBusquedaGrupos.Controls.Add(this.btnListarGrupos);
            this.pnlBusquedaGrupos.Location = new System.Drawing.Point(84, 282);
            this.pnlBusquedaGrupos.Name = "pnlBusquedaGrupos";
            this.pnlBusquedaGrupos.Size = new System.Drawing.Size(413, 182);
            this.pnlBusquedaGrupos.TabIndex = 5;
            // 
            // btnGruposNoForm
            // 
            this.btnGruposNoForm.Location = new System.Drawing.Point(87, 63);
            this.btnGruposNoForm.Name = "btnGruposNoForm";
            this.btnGruposNoForm.Size = new System.Drawing.Size(235, 23);
            this.btnGruposNoForm.TabIndex = 1;
            this.btnGruposNoForm.Text = "Listar Grupos que no han enviado formularios";
            this.btnGruposNoForm.UseVisualStyleBackColor = true;
            this.btnGruposNoForm.Click += new System.EventHandler(this.btnGruposNoForm_Click);
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion.Location = new System.Drawing.Point(9, 98);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(0, 13);
            this.lblOpcion.TabIndex = 6;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(9, 128);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(0, 13);
            this.lblBusqueda.TabIndex = 5;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Enabled = false;
            this.tbBusqueda.Location = new System.Drawing.Point(220, 128);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(102, 20);
            this.tbBusqueda.TabIndex = 3;
            this.tbBusqueda.TextChanged += new System.EventHandler(this.tbBusqueda_TextChanged);
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltro.Enabled = false;
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "Nombre"});
            this.cbxFiltro.Location = new System.Drawing.Point(220, 98);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(102, 21);
            this.cbxFiltro.Sorted = true;
            this.cbxFiltro.TabIndex = 2;
            this.cbxFiltro.SelectedIndexChanged += new System.EventHandler(this.cbxFiltro_SelectedIndexChanged);
            // 
            // lblTituloBusquedaGrupos
            // 
            this.lblTituloBusquedaGrupos.AutoSize = true;
            this.lblTituloBusquedaGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloBusquedaGrupos.Location = new System.Drawing.Point(122, 3);
            this.lblTituloBusquedaGrupos.Name = "lblTituloBusquedaGrupos";
            this.lblTituloBusquedaGrupos.Size = new System.Drawing.Size(151, 15);
            this.lblTituloBusquedaGrupos.TabIndex = 1;
            this.lblTituloBusquedaGrupos.Text = "Listar y Buscar Grupos";
            // 
            // btnListarGrupos
            // 
            this.btnListarGrupos.Location = new System.Drawing.Point(153, 34);
            this.btnListarGrupos.Name = "btnListarGrupos";
            this.btnListarGrupos.Size = new System.Drawing.Size(102, 23);
            this.btnListarGrupos.TabIndex = 0;
            this.btnListarGrupos.Text = "Listar Grupos";
            this.btnListarGrupos.UseVisualStyleBackColor = true;
            this.btnListarGrupos.Click += new System.EventHandler(this.btnListarGrupos_Click);
            // 
            // pnlBusquedaIntegrantes
            // 
            this.pnlBusquedaIntegrantes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBusquedaIntegrantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBusquedaIntegrantes.Controls.Add(this.btnEnviarInforme);
            this.pnlBusquedaIntegrantes.Controls.Add(this.lblNombreGrupo);
            this.pnlBusquedaIntegrantes.Controls.Add(this.tbNombreGrupo);
            this.pnlBusquedaIntegrantes.Controls.Add(this.lblTituloBusquedaIntegrantes);
            this.pnlBusquedaIntegrantes.Controls.Add(this.btnListarIntegrantes);
            this.pnlBusquedaIntegrantes.Enabled = false;
            this.pnlBusquedaIntegrantes.Location = new System.Drawing.Point(292, 480);
            this.pnlBusquedaIntegrantes.Name = "pnlBusquedaIntegrantes";
            this.pnlBusquedaIntegrantes.Size = new System.Drawing.Size(262, 150);
            this.pnlBusquedaIntegrantes.TabIndex = 6;
            // 
            // btnEnviarInforme
            // 
            this.btnEnviarInforme.Location = new System.Drawing.Point(33, 119);
            this.btnEnviarInforme.Name = "btnEnviarInforme";
            this.btnEnviarInforme.Size = new System.Drawing.Size(197, 24);
            this.btnEnviarInforme.TabIndex = 8;
            this.btnEnviarInforme.Text = "Enviar Informe a Grupo Seleccionado";
            this.btnEnviarInforme.UseVisualStyleBackColor = true;
            this.btnEnviarInforme.Click += new System.EventHandler(this.btnEnviarInforme_Click);
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreGrupo.Location = new System.Drawing.Point(9, 38);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(126, 26);
            this.lblNombreGrupo.TabIndex = 6;
            this.lblNombreGrupo.Text = "Nombre del \r\nGrupo Seleccionado:";
            // 
            // tbNombreGrupo
            // 
            this.tbNombreGrupo.Enabled = false;
            this.tbNombreGrupo.Location = new System.Drawing.Point(140, 44);
            this.tbNombreGrupo.Name = "tbNombreGrupo";
            this.tbNombreGrupo.Size = new System.Drawing.Size(102, 20);
            this.tbNombreGrupo.TabIndex = 4;
            // 
            // lblTituloBusquedaIntegrantes
            // 
            this.lblTituloBusquedaIntegrantes.AutoSize = true;
            this.lblTituloBusquedaIntegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloBusquedaIntegrantes.Location = new System.Drawing.Point(59, 9);
            this.lblTituloBusquedaIntegrantes.Name = "lblTituloBusquedaIntegrantes";
            this.lblTituloBusquedaIntegrantes.Size = new System.Drawing.Size(140, 15);
            this.lblTituloBusquedaIntegrantes.TabIndex = 1;
            this.lblTituloBusquedaIntegrantes.Text = "Seleccion de Grupos";
            // 
            // btnListarIntegrantes
            // 
            this.btnListarIntegrantes.Location = new System.Drawing.Point(33, 87);
            this.btnListarIntegrantes.Name = "btnListarIntegrantes";
            this.btnListarIntegrantes.Size = new System.Drawing.Size(197, 26);
            this.btnListarIntegrantes.TabIndex = 0;
            this.btnListarIntegrantes.Text = "Visualizar integrantes de este grupo";
            this.btnListarIntegrantes.UseVisualStyleBackColor = true;
            this.btnListarIntegrantes.Click += new System.EventHandler(this.btnListarIntegrantes_Click);
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlEliminar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEliminar.Controls.Add(this.lblTituloEliminar);
            this.pnlEliminar.Controls.Add(this.lblNombreGrupoElim);
            this.pnlEliminar.Controls.Add(this.tbNombreGrupoElim);
            this.pnlEliminar.Controls.Add(this.btnEliminarGrupo);
            this.pnlEliminar.Enabled = false;
            this.pnlEliminar.Location = new System.Drawing.Point(12, 479);
            this.pnlEliminar.Name = "pnlEliminar";
            this.pnlEliminar.Size = new System.Drawing.Size(262, 150);
            this.pnlEliminar.TabIndex = 7;
            // 
            // lblTituloEliminar
            // 
            this.lblTituloEliminar.AutoSize = true;
            this.lblTituloEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEliminar.Location = new System.Drawing.Point(77, 10);
            this.lblTituloEliminar.Name = "lblTituloEliminar";
            this.lblTituloEliminar.Size = new System.Drawing.Size(104, 15);
            this.lblTituloEliminar.TabIndex = 7;
            this.lblTituloEliminar.Text = "Eliminar Grupo";
            // 
            // lblNombreGrupoElim
            // 
            this.lblNombreGrupoElim.AutoSize = true;
            this.lblNombreGrupoElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreGrupoElim.Location = new System.Drawing.Point(16, 47);
            this.lblNombreGrupoElim.Name = "lblNombreGrupoElim";
            this.lblNombreGrupoElim.Size = new System.Drawing.Size(113, 13);
            this.lblNombreGrupoElim.TabIndex = 6;
            this.lblNombreGrupoElim.Text = "Nombre del Grupo:";
            // 
            // tbNombreGrupoElim
            // 
            this.tbNombreGrupoElim.Enabled = false;
            this.tbNombreGrupoElim.Location = new System.Drawing.Point(140, 44);
            this.tbNombreGrupoElim.Name = "tbNombreGrupoElim";
            this.tbNombreGrupoElim.Size = new System.Drawing.Size(102, 20);
            this.tbNombreGrupoElim.TabIndex = 4;
            // 
            // btnEliminarGrupo
            // 
            this.btnEliminarGrupo.Location = new System.Drawing.Point(78, 107);
            this.btnEliminarGrupo.Name = "btnEliminarGrupo";
            this.btnEliminarGrupo.Size = new System.Drawing.Size(102, 23);
            this.btnEliminarGrupo.TabIndex = 0;
            this.btnEliminarGrupo.Text = "Eliminar Grupo";
            this.btnEliminarGrupo.UseVisualStyleBackColor = true;
            this.btnEliminarGrupo.Click += new System.EventHandler(this.btnEliminarGrupo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(142, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 13);
            this.lblTitulo.TabIndex = 8;
            // 
            // frmGestionGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 642);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlEliminar);
            this.Controls.Add(this.pnlBusquedaIntegrantes);
            this.Controls.Add(this.pnlBusquedaGrupos);
            this.Controls.Add(this.dgvDatos);
            this.Name = "frmGestionGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGestionGrupo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.pnlBusquedaGrupos.ResumeLayout(false);
            this.pnlBusquedaGrupos.PerformLayout();
            this.pnlBusquedaIntegrantes.ResumeLayout(false);
            this.pnlBusquedaIntegrantes.PerformLayout();
            this.pnlEliminar.ResumeLayout(false);
            this.pnlEliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Panel pnlBusquedaGrupos;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Label lblTituloBusquedaGrupos;
        private System.Windows.Forms.Button btnListarGrupos;
        private System.Windows.Forms.Panel pnlBusquedaIntegrantes;
        private System.Windows.Forms.Label lblNombreGrupo;
        private System.Windows.Forms.TextBox tbNombreGrupo;
        private System.Windows.Forms.Label lblTituloBusquedaIntegrantes;
        private System.Windows.Forms.Button btnListarIntegrantes;
        private System.Windows.Forms.Panel pnlEliminar;
        private System.Windows.Forms.Label lblNombreGrupoElim;
        private System.Windows.Forms.TextBox tbNombreGrupoElim;
        private System.Windows.Forms.Button btnEliminarGrupo;
        private System.Windows.Forms.Label lblTituloEliminar;
        private System.Windows.Forms.Button btnEnviarInforme;
        private System.Windows.Forms.Button btnGruposNoForm;
        private System.Windows.Forms.Label lblTitulo;

    }
}