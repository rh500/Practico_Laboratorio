namespace Proyecto_Laboratorio
{
    partial class frmLlenarFormulario
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDiaCelula = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblOfrenda = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.tbDiaCelula = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.cbxOfrenda = new System.Windows.Forms.ComboBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.dtpFechaLlenado = new System.Windows.Forms.DateTimePicker();
            this.rtbMensajeConsideracion = new System.Windows.Forms.RichTextBox();
            this.lblMensajeConsideracion = new System.Windows.Forms.Label();
            this.rtbMensaje = new System.Windows.Forms.RichTextBox();
            this.rtbTitulo = new System.Windows.Forms.RichTextBox();
            this.rtbVersiculos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(26, 249);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(26, 299);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo";
            // 
            // lblDiaCelula
            // 
            this.lblDiaCelula.AutoSize = true;
            this.lblDiaCelula.Location = new System.Drawing.Point(26, 343);
            this.lblDiaCelula.Name = "lblDiaCelula";
            this.lblDiaCelula.Size = new System.Drawing.Size(55, 13);
            this.lblDiaCelula.TabIndex = 5;
            this.lblDiaCelula.Text = "Dia Celula";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(26, 388);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblOfrenda
            // 
            this.lblOfrenda.AutoSize = true;
            this.lblOfrenda.Location = new System.Drawing.Point(26, 432);
            this.lblOfrenda.Name = "lblOfrenda";
            this.lblOfrenda.Size = new System.Drawing.Size(81, 13);
            this.lblOfrenda.TabIndex = 7;
            this.lblOfrenda.Text = "Tiene Ofrenda?";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(26, 471);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 8;
            this.lblMonto.Text = "Monto";
            this.lblMonto.Visible = false;
            // 
            // tbDiaCelula
            // 
            this.tbDiaCelula.Location = new System.Drawing.Point(128, 343);
            this.tbDiaCelula.Name = "tbDiaCelula";
            this.tbDiaCelula.Size = new System.Drawing.Size(100, 20);
            this.tbDiaCelula.TabIndex = 3;
            this.tbDiaCelula.Enter += new System.EventHandler(this.tbDiaCelula_Enter);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(128, 388);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(100, 20);
            this.tbDireccion.TabIndex = 4;
            this.tbDireccion.Enter += new System.EventHandler(this.tbDiaCelula_Enter);
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(128, 471);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(100, 20);
            this.tbMonto.TabIndex = 6;
            this.tbMonto.Visible = false;
            this.tbMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMonto_KeyPress);
            this.tbMonto.Enter += new System.EventHandler(this.tbDiaCelula_Enter);
            // 
            // cbxOfrenda
            // 
            this.cbxOfrenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOfrenda.FormattingEnabled = true;
            this.cbxOfrenda.Items.AddRange(new object[] {
            "No",
            "Si"});
            this.cbxOfrenda.Location = new System.Drawing.Point(128, 432);
            this.cbxOfrenda.Name = "cbxOfrenda";
            this.cbxOfrenda.Size = new System.Drawing.Size(100, 21);
            this.cbxOfrenda.TabIndex = 5;
            this.cbxOfrenda.SelectedIndexChanged += new System.EventHandler(this.cbxOfrenda_SelectedIndexChanged);
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Matrimonios",
            "Mujeres",
            "Hombres",
            "Jovenes V",
            "Jovenes M",
            "Adolescentes V",
            "Adoslescentes M"});
            this.cbxTipo.Location = new System.Drawing.Point(128, 299);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(100, 21);
            this.cbxTipo.TabIndex = 2;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(458, 589);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(105, 23);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar Formulario";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // dtpFechaLlenado
            // 
            this.dtpFechaLlenado.Checked = false;
            this.dtpFechaLlenado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLlenado.Location = new System.Drawing.Point(128, 249);
            this.dtpFechaLlenado.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.dtpFechaLlenado.Name = "dtpFechaLlenado";
            this.dtpFechaLlenado.ShowCheckBox = true;
            this.dtpFechaLlenado.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaLlenado.TabIndex = 1;
            // 
            // rtbMensajeConsideracion
            // 
            this.rtbMensajeConsideracion.Location = new System.Drawing.Point(128, 516);
            this.rtbMensajeConsideracion.Name = "rtbMensajeConsideracion";
            this.rtbMensajeConsideracion.Size = new System.Drawing.Size(252, 96);
            this.rtbMensajeConsideracion.TabIndex = 7;
            this.rtbMensajeConsideracion.Text = "";
            // 
            // lblMensajeConsideracion
            // 
            this.lblMensajeConsideracion.AutoSize = true;
            this.lblMensajeConsideracion.Location = new System.Drawing.Point(26, 543);
            this.lblMensajeConsideracion.Name = "lblMensajeConsideracion";
            this.lblMensajeConsideracion.Size = new System.Drawing.Size(84, 26);
            this.lblMensajeConsideracion.TabIndex = 9;
            this.lblMensajeConsideracion.Text = "Comentarios y/o\r\nmensajes.";
            // 
            // rtbMensaje
            // 
            this.rtbMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMensaje.Enabled = false;
            this.rtbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMensaje.Location = new System.Drawing.Point(128, 85);
            this.rtbMensaje.Name = "rtbMensaje";
            this.rtbMensaje.Size = new System.Drawing.Size(483, 158);
            this.rtbMensaje.TabIndex = 10;
            this.rtbMensaje.Text = "";
            // 
            // rtbTitulo
            // 
            this.rtbTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTitulo.Enabled = false;
            this.rtbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTitulo.Location = new System.Drawing.Point(128, 8);
            this.rtbTitulo.Name = "rtbTitulo";
            this.rtbTitulo.Size = new System.Drawing.Size(351, 32);
            this.rtbTitulo.TabIndex = 11;
            this.rtbTitulo.Text = "";
            // 
            // rtbVersiculos
            // 
            this.rtbVersiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbVersiculos.Enabled = false;
            this.rtbVersiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbVersiculos.Location = new System.Drawing.Point(128, 46);
            this.rtbVersiculos.Name = "rtbVersiculos";
            this.rtbVersiculos.Size = new System.Drawing.Size(351, 33);
            this.rtbVersiculos.TabIndex = 12;
            this.rtbVersiculos.Text = "";
            // 
            // frmLlenarFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 663);
            this.Controls.Add(this.rtbVersiculos);
            this.Controls.Add(this.rtbTitulo);
            this.Controls.Add(this.rtbMensaje);
            this.Controls.Add(this.lblMensajeConsideracion);
            this.Controls.Add(this.rtbMensajeConsideracion);
            this.Controls.Add(this.dtpFechaLlenado);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.cbxOfrenda);
            this.Controls.Add(this.tbMonto);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbDiaCelula);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblOfrenda);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblDiaCelula);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmLlenarFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLlenarFormulario";
            this.Load += new System.EventHandler(this.frmLlenarFormulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDiaCelula;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblOfrenda;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox tbDiaCelula;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.ComboBox cbxOfrenda;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DateTimePicker dtpFechaLlenado;
        private System.Windows.Forms.RichTextBox rtbMensajeConsideracion;
        private System.Windows.Forms.Label lblMensajeConsideracion;
        private System.Windows.Forms.RichTextBox rtbMensaje;
        private System.Windows.Forms.RichTextBox rtbTitulo;
        private System.Windows.Forms.RichTextBox rtbVersiculos;
    }
}