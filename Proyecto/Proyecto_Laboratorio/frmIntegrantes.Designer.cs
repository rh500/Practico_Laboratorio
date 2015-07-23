namespace Proyecto_Laboratorio
{
    partial class frmIntegrantes
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
            this.dgvIntegrantes = new System.Windows.Forms.DataGridView();
            this.pnlAgregar = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblAgregarTitulo = new System.Windows.Forms.Label();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.lblTituloBusqueda = new System.Windows.Forms.Label();
            this.btnListarIntegrantes = new System.Windows.Forms.Button();
            this.pnlModificar = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dtpFechaNacModif = new System.Windows.Forms.DateTimePicker();
            this.tbDireccionModif = new System.Windows.Forms.TextBox();
            this.tbTelefonoModif = new System.Windows.Forms.TextBox();
            this.tbApellidoModif = new System.Windows.Forms.TextBox();
            this.tbNombreModif = new System.Windows.Forms.TextBox();
            this.tbDniModif = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTituloModificar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).BeginInit();
            this.pnlAgregar.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            this.pnlModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIntegrantes
            // 
            this.dgvIntegrantes.AllowUserToAddRows = false;
            this.dgvIntegrantes.AllowUserToDeleteRows = false;
            this.dgvIntegrantes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvIntegrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntegrantes.Location = new System.Drawing.Point(74, 12);
            this.dgvIntegrantes.Name = "dgvIntegrantes";
            this.dgvIntegrantes.ReadOnly = true;
            this.dgvIntegrantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIntegrantes.Size = new System.Drawing.Size(720, 242);
            this.dgvIntegrantes.TabIndex = 0;
            this.dgvIntegrantes.SelectionChanged += new System.EventHandler(this.dgvIntegrantes_SelectionChanged);
            // 
            // pnlAgregar
            // 
            this.pnlAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlAgregar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAgregar.Controls.Add(this.btnAgregar);
            this.pnlAgregar.Controls.Add(this.dtpFechaNac);
            this.pnlAgregar.Controls.Add(this.tbDireccion);
            this.pnlAgregar.Controls.Add(this.tbTelefono);
            this.pnlAgregar.Controls.Add(this.tbApellido);
            this.pnlAgregar.Controls.Add(this.tbNombre);
            this.pnlAgregar.Controls.Add(this.tbDni);
            this.pnlAgregar.Controls.Add(this.lblDireccion);
            this.pnlAgregar.Controls.Add(this.lblFechaNac);
            this.pnlAgregar.Controls.Add(this.lblTelefono);
            this.pnlAgregar.Controls.Add(this.lblApellido);
            this.pnlAgregar.Controls.Add(this.lblNombre);
            this.pnlAgregar.Controls.Add(this.lblDni);
            this.pnlAgregar.Controls.Add(this.lblAgregarTitulo);
            this.pnlAgregar.Location = new System.Drawing.Point(12, 271);
            this.pnlAgregar.Name = "pnlAgregar";
            this.pnlAgregar.Size = new System.Drawing.Size(261, 217);
            this.pnlAgregar.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(155, 187);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Checked = false;
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(13, 135);
            this.dtpFechaNac.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dtpFechaNac.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.ShowCheckBox = true;
            this.dtpFechaNac.Size = new System.Drawing.Size(125, 20);
            this.dtpFechaNac.TabIndex = 11;
            this.dtpFechaNac.Value = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(13, 160);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(125, 20);
            this.tbDireccion.TabIndex = 12;
            this.tbDireccion.Enter += new System.EventHandler(this.tbNombreModif_Enter);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(13, 110);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(125, 20);
            this.tbTelefono.TabIndex = 10;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDni_KeyPress);
            this.tbTelefono.Enter += new System.EventHandler(this.tbNombreModif_Enter);
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(13, 85);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(125, 20);
            this.tbApellido.TabIndex = 9;
            this.tbApellido.Enter += new System.EventHandler(this.tbNombreModif_Enter);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(13, 60);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(125, 20);
            this.tbNombre.TabIndex = 8;
            this.tbNombre.Enter += new System.EventHandler(this.tbNombreModif_Enter);
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(13, 35);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(125, 20);
            this.tbDni.TabIndex = 7;
            this.tbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDni_KeyPress);
            this.tbDni.Enter += new System.EventHandler(this.tbNombreModif_Enter);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(152, 164);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(61, 13);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(152, 139);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(109, 13);
            this.lblFechaNac.TabIndex = 5;
            this.lblFechaNac.Text = "Fecha Nacimiento";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(152, 114);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(57, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(152, 89);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(52, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(152, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(152, 39);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "Dni";
            // 
            // lblAgregarTitulo
            // 
            this.lblAgregarTitulo.AutoSize = true;
            this.lblAgregarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarTitulo.Location = new System.Drawing.Point(55, 3);
            this.lblAgregarTitulo.Name = "lblAgregarTitulo";
            this.lblAgregarTitulo.Size = new System.Drawing.Size(146, 15);
            this.lblAgregarTitulo.TabIndex = 0;
            this.lblAgregarTitulo.Text = "Agregar un Integrante";
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBusqueda.Controls.Add(this.lblOpcion);
            this.pnlBusqueda.Controls.Add(this.lblBusqueda);
            this.pnlBusqueda.Controls.Add(this.tbBusqueda);
            this.pnlBusqueda.Controls.Add(this.cbxFiltro);
            this.pnlBusqueda.Controls.Add(this.lblTituloBusqueda);
            this.pnlBusqueda.Controls.Add(this.btnListarIntegrantes);
            this.pnlBusqueda.Location = new System.Drawing.Point(304, 271);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(262, 150);
            this.pnlBusqueda.TabIndex = 2;
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Location = new System.Drawing.Point(3, 76);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(0, 13);
            this.lblOpcion.TabIndex = 6;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(3, 106);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(0, 13);
            this.lblBusqueda.TabIndex = 5;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Enabled = false;
            this.tbBusqueda.Location = new System.Drawing.Point(139, 103);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(102, 20);
            this.tbBusqueda.TabIndex = 4;
            this.tbBusqueda.TextChanged += new System.EventHandler(this.tbBusqueda_TextChanged);
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltro.Enabled = false;
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "Dni",
            "Nombre"});
            this.cbxFiltro.Location = new System.Drawing.Point(139, 73);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(102, 21);
            this.cbxFiltro.TabIndex = 3;
            this.cbxFiltro.SelectedIndexChanged += new System.EventHandler(this.cbxFiltro_SelectedIndexChanged);
            // 
            // lblTituloBusqueda
            // 
            this.lblTituloBusqueda.AutoSize = true;
            this.lblTituloBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloBusqueda.Location = new System.Drawing.Point(41, 3);
            this.lblTituloBusqueda.Name = "lblTituloBusqueda";
            this.lblTituloBusqueda.Size = new System.Drawing.Size(177, 15);
            this.lblTituloBusqueda.TabIndex = 1;
            this.lblTituloBusqueda.Text = "Listar y Buscar Integrantes";
            // 
            // btnListarIntegrantes
            // 
            this.btnListarIntegrantes.Location = new System.Drawing.Point(78, 34);
            this.btnListarIntegrantes.Name = "btnListarIntegrantes";
            this.btnListarIntegrantes.Size = new System.Drawing.Size(102, 23);
            this.btnListarIntegrantes.TabIndex = 0;
            this.btnListarIntegrantes.Text = "Listar Integrantes";
            this.btnListarIntegrantes.UseVisualStyleBackColor = true;
            this.btnListarIntegrantes.Click += new System.EventHandler(this.btnListarIntegrantes_Click);
            // 
            // pnlModificar
            // 
            this.pnlModificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlModificar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlModificar.Controls.Add(this.btnModificar);
            this.pnlModificar.Controls.Add(this.dtpFechaNacModif);
            this.pnlModificar.Controls.Add(this.tbDireccionModif);
            this.pnlModificar.Controls.Add(this.tbTelefonoModif);
            this.pnlModificar.Controls.Add(this.tbApellidoModif);
            this.pnlModificar.Controls.Add(this.tbNombreModif);
            this.pnlModificar.Controls.Add(this.tbDniModif);
            this.pnlModificar.Controls.Add(this.label1);
            this.pnlModificar.Controls.Add(this.label2);
            this.pnlModificar.Controls.Add(this.label3);
            this.pnlModificar.Controls.Add(this.label4);
            this.pnlModificar.Controls.Add(this.label5);
            this.pnlModificar.Controls.Add(this.label6);
            this.pnlModificar.Controls.Add(this.lblTituloModificar);
            this.pnlModificar.Location = new System.Drawing.Point(596, 271);
            this.pnlModificar.Name = "pnlModificar";
            this.pnlModificar.Size = new System.Drawing.Size(261, 217);
            this.pnlModificar.TabIndex = 3;
            this.pnlModificar.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(151, 187);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 23);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar Datos";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dtpFechaNacModif
            // 
            this.dtpFechaNacModif.Checked = false;
            this.dtpFechaNacModif.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacModif.Location = new System.Drawing.Point(13, 135);
            this.dtpFechaNacModif.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dtpFechaNacModif.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacModif.Name = "dtpFechaNacModif";
            this.dtpFechaNacModif.ShowCheckBox = true;
            this.dtpFechaNacModif.Size = new System.Drawing.Size(125, 20);
            this.dtpFechaNacModif.TabIndex = 11;
            this.dtpFechaNacModif.Value = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            // 
            // tbDireccionModif
            // 
            this.tbDireccionModif.Location = new System.Drawing.Point(13, 160);
            this.tbDireccionModif.Name = "tbDireccionModif";
            this.tbDireccionModif.Size = new System.Drawing.Size(125, 20);
            this.tbDireccionModif.TabIndex = 12;
            this.tbDireccionModif.Enter += new System.EventHandler(this.tbNombreModif_Enter);
            // 
            // tbTelefonoModif
            // 
            this.tbTelefonoModif.Location = new System.Drawing.Point(13, 110);
            this.tbTelefonoModif.Name = "tbTelefonoModif";
            this.tbTelefonoModif.Size = new System.Drawing.Size(125, 20);
            this.tbTelefonoModif.TabIndex = 10;
            this.tbTelefonoModif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDni_KeyPress);
            this.tbTelefonoModif.Enter += new System.EventHandler(this.tbNombreModif_Enter);
            // 
            // tbApellidoModif
            // 
            this.tbApellidoModif.Location = new System.Drawing.Point(13, 85);
            this.tbApellidoModif.Name = "tbApellidoModif";
            this.tbApellidoModif.Size = new System.Drawing.Size(125, 20);
            this.tbApellidoModif.TabIndex = 9;
            this.tbApellidoModif.Enter += new System.EventHandler(this.tbNombreModif_Enter);
            // 
            // tbNombreModif
            // 
            this.tbNombreModif.Location = new System.Drawing.Point(13, 60);
            this.tbNombreModif.Name = "tbNombreModif";
            this.tbNombreModif.Size = new System.Drawing.Size(125, 20);
            this.tbNombreModif.TabIndex = 8;
            this.tbNombreModif.Enter += new System.EventHandler(this.tbNombreModif_Enter);
            // 
            // tbDniModif
            // 
            this.tbDniModif.Location = new System.Drawing.Point(13, 35);
            this.tbDniModif.Name = "tbDniModif";
            this.tbDniModif.ReadOnly = true;
            this.tbDniModif.Size = new System.Drawing.Size(125, 20);
            this.tbDniModif.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(152, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Dni";
            // 
            // lblTituloModificar
            // 
            this.lblTituloModificar.AutoSize = true;
            this.lblTituloModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloModificar.Location = new System.Drawing.Point(74, 3);
            this.lblTituloModificar.Name = "lblTituloModificar";
            this.lblTituloModificar.Size = new System.Drawing.Size(108, 15);
            this.lblTituloModificar.TabIndex = 0;
            this.lblTituloModificar.Text = "Modificar Datos";
            // 
            // frmIntegrantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 538);
            this.Controls.Add(this.pnlModificar);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.pnlAgregar);
            this.Controls.Add(this.dgvIntegrantes);
            this.Name = "frmIntegrantes";
            this.Text = "frmIntegrantes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).EndInit();
            this.pnlAgregar.ResumeLayout(false);
            this.pnlAgregar.PerformLayout();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.pnlModificar.ResumeLayout(false);
            this.pnlModificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIntegrantes;
        private System.Windows.Forms.Panel pnlAgregar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblAgregarTitulo;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Button btnListarIntegrantes;
        private System.Windows.Forms.Label lblTituloBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Panel pnlModificar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DateTimePicker dtpFechaNacModif;
        private System.Windows.Forms.TextBox tbDireccionModif;
        private System.Windows.Forms.TextBox tbTelefonoModif;
        private System.Windows.Forms.TextBox tbApellidoModif;
        private System.Windows.Forms.TextBox tbNombreModif;
        private System.Windows.Forms.TextBox tbDniModif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTituloModificar;
    }
}