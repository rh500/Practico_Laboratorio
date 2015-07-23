namespace Proyecto_Laboratorio
{
    partial class frmInformeGrupo
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
            this.dgvMensajes = new System.Windows.Forms.DataGridView();
            this.pnlLlenado = new System.Windows.Forms.Panel();
            this.lblTituloPnlInforme = new System.Windows.Forms.Label();
            this.lblTituloMensaje = new System.Windows.Forms.Label();
            this.lblTitulopanel = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.btnListarMensajes = new System.Windows.Forms.Button();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.chbxAfirmacion = new System.Windows.Forms.CheckBox();
            this.btnListarInformes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajes)).BeginInit();
            this.pnlLlenado.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMensajes
            // 
            this.dgvMensajes.AllowUserToAddRows = false;
            this.dgvMensajes.AllowUserToDeleteRows = false;
            this.dgvMensajes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMensajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMensajes.Location = new System.Drawing.Point(212, 12);
            this.dgvMensajes.Name = "dgvMensajes";
            this.dgvMensajes.ReadOnly = true;
            this.dgvMensajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMensajes.Size = new System.Drawing.Size(451, 264);
            this.dgvMensajes.TabIndex = 0;
            this.dgvMensajes.Visible = false;
            // 
            // pnlLlenado
            // 
            this.pnlLlenado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLlenado.Controls.Add(this.lblTituloPnlInforme);
            this.pnlLlenado.Controls.Add(this.lblTituloMensaje);
            this.pnlLlenado.Controls.Add(this.lblTitulopanel);
            this.pnlLlenado.Controls.Add(this.btnEnviar);
            this.pnlLlenado.Controls.Add(this.rtbTexto);
            this.pnlLlenado.Controls.Add(this.tbTitulo);
            this.pnlLlenado.Controls.Add(this.lblTexto);
            this.pnlLlenado.Controls.Add(this.lblTitulo);
            this.pnlLlenado.Location = new System.Drawing.Point(46, 304);
            this.pnlLlenado.Name = "pnlLlenado";
            this.pnlLlenado.Size = new System.Drawing.Size(391, 339);
            this.pnlLlenado.TabIndex = 1;
            // 
            // lblTituloPnlInforme
            // 
            this.lblTituloPnlInforme.AutoSize = true;
            this.lblTituloPnlInforme.Location = new System.Drawing.Point(93, 5);
            this.lblTituloPnlInforme.Name = "lblTituloPnlInforme";
            this.lblTituloPnlInforme.Size = new System.Drawing.Size(201, 13);
            this.lblTituloPnlInforme.TabIndex = 7;
            this.lblTituloPnlInforme.Text = "Redacte un informe para el Administrador";
            // 
            // lblTituloMensaje
            // 
            this.lblTituloMensaje.AutoSize = true;
            this.lblTituloMensaje.Location = new System.Drawing.Point(214, 32);
            this.lblTituloMensaje.Name = "lblTituloMensaje";
            this.lblTituloMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblTituloMensaje.TabIndex = 6;
            // 
            // lblTitulopanel
            // 
            this.lblTitulopanel.AutoSize = true;
            this.lblTitulopanel.Location = new System.Drawing.Point(51, 32);
            this.lblTitulopanel.Name = "lblTitulopanel";
            this.lblTitulopanel.Size = new System.Drawing.Size(0, 13);
            this.lblTitulopanel.TabIndex = 5;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(255, 280);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(98, 23);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar Informe";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // rtbTexto
            // 
            this.rtbTexto.Location = new System.Drawing.Point(84, 91);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(269, 166);
            this.rtbTexto.TabIndex = 3;
            this.rtbTexto.Text = "";
            this.rtbTexto.Enter += new System.EventHandler(this.tbTitulo_Enter);
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(84, 56);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(269, 20);
            this.tbTitulo.TabIndex = 2;
            this.tbTitulo.Enter += new System.EventHandler(this.tbTitulo_Enter);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(18, 91);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(42, 13);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Informe";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(18, 56);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBusqueda.Controls.Add(this.btnSeleccionar);
            this.pnlBusqueda.Controls.Add(this.lblBusqueda);
            this.pnlBusqueda.Controls.Add(this.lblOpcion);
            this.pnlBusqueda.Controls.Add(this.tbBusqueda);
            this.pnlBusqueda.Controls.Add(this.btnListarMensajes);
            this.pnlBusqueda.Controls.Add(this.cbxFiltro);
            this.pnlBusqueda.Enabled = false;
            this.pnlBusqueda.Location = new System.Drawing.Point(531, 389);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(300, 166);
            this.pnlBusqueda.TabIndex = 2;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Enabled = false;
            this.btnSeleccionar.Location = new System.Drawing.Point(88, 136);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(121, 23);
            this.btnSeleccionar.TabIndex = 6;
            this.btnSeleccionar.Text = "Seleccionar Prédica";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(26, 96);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(0, 13);
            this.lblBusqueda.TabIndex = 5;
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Location = new System.Drawing.Point(26, 60);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(0, 13);
            this.lblOpcion.TabIndex = 4;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Enabled = false;
            this.tbBusqueda.Location = new System.Drawing.Point(172, 96);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(100, 20);
            this.tbBusqueda.TabIndex = 3;
            this.tbBusqueda.TextChanged += new System.EventHandler(this.tbBusqueda_TextChanged);
            // 
            // btnListarMensajes
            // 
            this.btnListarMensajes.Location = new System.Drawing.Point(109, 15);
            this.btnListarMensajes.Name = "btnListarMensajes";
            this.btnListarMensajes.Size = new System.Drawing.Size(93, 23);
            this.btnListarMensajes.TabIndex = 1;
            this.btnListarMensajes.Text = "Listar Mensajes";
            this.btnListarMensajes.UseVisualStyleBackColor = true;
            this.btnListarMensajes.Click += new System.EventHandler(this.btnListarMensajes_Click);
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "Título",
            "Mensaje",
            "Fecha"});
            this.cbxFiltro.Location = new System.Drawing.Point(172, 60);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(100, 21);
            this.cbxFiltro.TabIndex = 0;
            this.cbxFiltro.Visible = false;
            this.cbxFiltro.SelectedIndexChanged += new System.EventHandler(this.cbxFiltro_SelectedIndexChanged);
            // 
            // chbxAfirmacion
            // 
            this.chbxAfirmacion.AutoSize = true;
            this.chbxAfirmacion.Location = new System.Drawing.Point(562, 334);
            this.chbxAfirmacion.Name = "chbxAfirmacion";
            this.chbxAfirmacion.Size = new System.Drawing.Size(224, 17);
            this.chbxAfirmacion.TabIndex = 3;
            this.chbxAfirmacion.Text = "Enviar informe acerca de alguna Prédica?";
            this.chbxAfirmacion.UseVisualStyleBackColor = true;
            this.chbxAfirmacion.CheckedChanged += new System.EventHandler(this.chbxAfirmacion_CheckedChanged);
            // 
            // btnListarInformes
            // 
            this.btnListarInformes.Location = new System.Drawing.Point(571, 289);
            this.btnListarInformes.Name = "btnListarInformes";
            this.btnListarInformes.Size = new System.Drawing.Size(140, 23);
            this.btnListarInformes.TabIndex = 4;
            this.btnListarInformes.Text = "Listar Informes Recibidos";
            this.btnListarInformes.UseVisualStyleBackColor = true;
            this.btnListarInformes.Click += new System.EventHandler(this.btnListarInformes_Click);
            // 
            // frmInformeGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 664);
            this.Controls.Add(this.btnListarInformes);
            this.Controls.Add(this.chbxAfirmacion);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.pnlLlenado);
            this.Controls.Add(this.dgvMensajes);
            this.Name = "frmInformeGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInformeGrupo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajes)).EndInit();
            this.pnlLlenado.ResumeLayout(false);
            this.pnlLlenado.PerformLayout();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMensajes;
        private System.Windows.Forms.Panel pnlLlenado;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Button btnListarMensajes;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblTituloMensaje;
        private System.Windows.Forms.Label lblTitulopanel;
        private System.Windows.Forms.CheckBox chbxAfirmacion;
        private System.Windows.Forms.Label lblTituloPnlInforme;
        private System.Windows.Forms.Button btnListarInformes;
    }
}