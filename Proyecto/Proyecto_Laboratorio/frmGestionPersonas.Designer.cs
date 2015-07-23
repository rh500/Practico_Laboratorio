namespace Proyecto_Laboratorio
{
    partial class frmGestionPersonas
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
            this.pnlAgregar = new System.Windows.Forms.Panel();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
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
            this.dgvListarPersonas = new System.Windows.Forms.DataGridView();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.lblTituloBusqueda = new System.Windows.Forms.Label();
            this.btnListarPersonas = new System.Windows.Forms.Button();
            this.pnlModificar = new System.Windows.Forms.Panel();
            this.lblPareja = new System.Windows.Forms.Label();
            this.cbLider = new System.Windows.Forms.ComboBox();
            this.lblNombreGrupoModif = new System.Windows.Forms.Label();
            this.cbNombreGrupoModif = new System.Windows.Forms.ComboBox();
            this.btnModificarDatos = new System.Windows.Forms.Button();
            this.dtpFechaNacModif = new System.Windows.Forms.DateTimePicker();
            this.tbDireccionModif = new System.Windows.Forms.TextBox();
            this.tbTelefonoModif = new System.Windows.Forms.TextBox();
            this.tbApellidoModif = new System.Windows.Forms.TextBox();
            this.tbNombreModif = new System.Windows.Forms.TextBox();
            this.tbDniModif = new System.Windows.Forms.TextBox();
            this.lblDireccionModif = new System.Windows.Forms.Label();
            this.lblFechaNacModif = new System.Windows.Forms.Label();
            this.lblTelefonoModif = new System.Windows.Forms.Label();
            this.lblApellidoModif = new System.Windows.Forms.Label();
            this.lblNombreModif = new System.Windows.Forms.Label();
            this.lblDniModif = new System.Windows.Forms.Label();
            this.lblTituloModif = new System.Windows.Forms.Label();
            this.pnlEliminar = new System.Windows.Forms.Panel();
            this.lblDniEliminar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tbDniEliminar = new System.Windows.Forms.TextBox();
            this.pnlAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarPersonas)).BeginInit();
            this.pnlBusqueda.SuspendLayout();
            this.pnlModificar.SuspendLayout();
            this.pnlEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAgregar
            // 
            this.pnlAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlAgregar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAgregar.Controls.Add(this.lblGrupo);
            this.pnlAgregar.Controls.Add(this.cbGrupo);
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
            this.pnlAgregar.Location = new System.Drawing.Point(12, 264);
            this.pnlAgregar.Name = "pnlAgregar";
            this.pnlAgregar.Size = new System.Drawing.Size(290, 258);
            this.pnlAgregar.TabIndex = 2;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.Location = new System.Drawing.Point(152, 189);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(109, 13);
            this.lblGrupo.TabIndex = 16;
            this.lblGrupo.Text = "Nombre del Grupo";
            // 
            // cbGrupo
            // 
            this.cbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(13, 186);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(125, 21);
            this.cbGrupo.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(155, 228);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar Líder";
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
            this.tbDireccion.Enter += new System.EventHandler(this.tbDni_Enter);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(13, 110);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(125, 20);
            this.tbTelefono.TabIndex = 10;
            this.tbTelefono.Enter += new System.EventHandler(this.tbDni_Enter);
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(13, 85);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(125, 20);
            this.tbApellido.TabIndex = 9;
            this.tbApellido.Enter += new System.EventHandler(this.tbDni_Enter);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(13, 60);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(125, 20);
            this.tbNombre.TabIndex = 8;
            this.tbNombre.Enter += new System.EventHandler(this.tbDni_Enter);
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(13, 35);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(125, 20);
            this.tbDni.TabIndex = 7;
            this.tbDni.Enter += new System.EventHandler(this.tbDni_Enter);
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
            this.lblAgregarTitulo.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblAgregarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarTitulo.Location = new System.Drawing.Point(86, 3);
            this.lblAgregarTitulo.Name = "lblAgregarTitulo";
            this.lblAgregarTitulo.Size = new System.Drawing.Size(114, 15);
            this.lblAgregarTitulo.TabIndex = 0;
            this.lblAgregarTitulo.Text = "Agregar un Lider";
            // 
            // dgvListarPersonas
            // 
            this.dgvListarPersonas.AllowUserToAddRows = false;
            this.dgvListarPersonas.AllowUserToDeleteRows = false;
            this.dgvListarPersonas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListarPersonas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListarPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarPersonas.Location = new System.Drawing.Point(27, 12);
            this.dgvListarPersonas.Name = "dgvListarPersonas";
            this.dgvListarPersonas.ReadOnly = true;
            this.dgvListarPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarPersonas.Size = new System.Drawing.Size(834, 242);
            this.dgvListarPersonas.TabIndex = 3;
            this.dgvListarPersonas.SelectionChanged += new System.EventHandler(this.dgvListarPersonas_SelectionChanged);
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
            this.pnlBusqueda.Controls.Add(this.btnListarPersonas);
            this.pnlBusqueda.Location = new System.Drawing.Point(315, 264);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(262, 150);
            this.pnlBusqueda.TabIndex = 4;
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion.Location = new System.Drawing.Point(3, 71);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(0, 13);
            this.lblOpcion.TabIndex = 6;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            "Nombre",
            "Nombre Grupo"});
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
            this.lblTituloBusqueda.Location = new System.Drawing.Point(47, 3);
            this.lblTituloBusqueda.Name = "lblTituloBusqueda";
            this.lblTituloBusqueda.Size = new System.Drawing.Size(165, 15);
            this.lblTituloBusqueda.TabIndex = 1;
            this.lblTituloBusqueda.Text = "Listar y Buscar Personas";
            // 
            // btnListarPersonas
            // 
            this.btnListarPersonas.Location = new System.Drawing.Point(78, 34);
            this.btnListarPersonas.Name = "btnListarPersonas";
            this.btnListarPersonas.Size = new System.Drawing.Size(102, 23);
            this.btnListarPersonas.TabIndex = 0;
            this.btnListarPersonas.Text = "Listar Personas";
            this.btnListarPersonas.UseVisualStyleBackColor = true;
            this.btnListarPersonas.Click += new System.EventHandler(this.btnListarPersonas_Click);
            // 
            // pnlModificar
            // 
            this.pnlModificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlModificar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlModificar.Controls.Add(this.lblPareja);
            this.pnlModificar.Controls.Add(this.cbLider);
            this.pnlModificar.Controls.Add(this.lblNombreGrupoModif);
            this.pnlModificar.Controls.Add(this.cbNombreGrupoModif);
            this.pnlModificar.Controls.Add(this.btnModificarDatos);
            this.pnlModificar.Controls.Add(this.dtpFechaNacModif);
            this.pnlModificar.Controls.Add(this.tbDireccionModif);
            this.pnlModificar.Controls.Add(this.tbTelefonoModif);
            this.pnlModificar.Controls.Add(this.tbApellidoModif);
            this.pnlModificar.Controls.Add(this.tbNombreModif);
            this.pnlModificar.Controls.Add(this.tbDniModif);
            this.pnlModificar.Controls.Add(this.lblDireccionModif);
            this.pnlModificar.Controls.Add(this.lblFechaNacModif);
            this.pnlModificar.Controls.Add(this.lblTelefonoModif);
            this.pnlModificar.Controls.Add(this.lblApellidoModif);
            this.pnlModificar.Controls.Add(this.lblNombreModif);
            this.pnlModificar.Controls.Add(this.lblDniModif);
            this.pnlModificar.Controls.Add(this.lblTituloModif);
            this.pnlModificar.Enabled = false;
            this.pnlModificar.Location = new System.Drawing.Point(590, 264);
            this.pnlModificar.Name = "pnlModificar";
            this.pnlModificar.Size = new System.Drawing.Size(290, 287);
            this.pnlModificar.TabIndex = 5;
            // 
            // lblPareja
            // 
            this.lblPareja.AutoSize = true;
            this.lblPareja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPareja.Location = new System.Drawing.Point(152, 187);
            this.lblPareja.Name = "lblPareja";
            this.lblPareja.Size = new System.Drawing.Size(132, 13);
            this.lblPareja.TabIndex = 18;
            this.lblPareja.Text = "Se convirtio en Lider?";
            // 
            // cbLider
            // 
            this.cbLider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLider.FormattingEnabled = true;
            this.cbLider.Items.AddRange(new object[] {
            "No",
            "Si"});
            this.cbLider.Location = new System.Drawing.Point(13, 184);
            this.cbLider.Name = "cbLider";
            this.cbLider.Size = new System.Drawing.Size(125, 21);
            this.cbLider.TabIndex = 17;
            this.cbLider.SelectedIndexChanged += new System.EventHandler(this.cbLider_SelectedIndexChanged);
            // 
            // lblNombreGrupoModif
            // 
            this.lblNombreGrupoModif.AutoSize = true;
            this.lblNombreGrupoModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreGrupoModif.Location = new System.Drawing.Point(152, 214);
            this.lblNombreGrupoModif.Name = "lblNombreGrupoModif";
            this.lblNombreGrupoModif.Size = new System.Drawing.Size(109, 13);
            this.lblNombreGrupoModif.TabIndex = 16;
            this.lblNombreGrupoModif.Text = "Nombre del Grupo";
            // 
            // cbNombreGrupoModif
            // 
            this.cbNombreGrupoModif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNombreGrupoModif.FormattingEnabled = true;
            this.cbNombreGrupoModif.Location = new System.Drawing.Point(13, 211);
            this.cbNombreGrupoModif.Name = "cbNombreGrupoModif";
            this.cbNombreGrupoModif.Size = new System.Drawing.Size(125, 21);
            this.cbNombreGrupoModif.TabIndex = 13;
            // 
            // btnModificarDatos
            // 
            this.btnModificarDatos.Location = new System.Drawing.Point(155, 257);
            this.btnModificarDatos.Name = "btnModificarDatos";
            this.btnModificarDatos.Size = new System.Drawing.Size(106, 23);
            this.btnModificarDatos.TabIndex = 14;
            this.btnModificarDatos.Text = "Modificar Datos";
            this.btnModificarDatos.UseVisualStyleBackColor = true;
            this.btnModificarDatos.Click += new System.EventHandler(this.btnModificarDatos_Click);
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
            // 
            // tbTelefonoModif
            // 
            this.tbTelefonoModif.Location = new System.Drawing.Point(13, 110);
            this.tbTelefonoModif.Name = "tbTelefonoModif";
            this.tbTelefonoModif.Size = new System.Drawing.Size(125, 20);
            this.tbTelefonoModif.TabIndex = 10;
            // 
            // tbApellidoModif
            // 
            this.tbApellidoModif.Location = new System.Drawing.Point(13, 85);
            this.tbApellidoModif.Name = "tbApellidoModif";
            this.tbApellidoModif.Size = new System.Drawing.Size(125, 20);
            this.tbApellidoModif.TabIndex = 9;
            // 
            // tbNombreModif
            // 
            this.tbNombreModif.Location = new System.Drawing.Point(13, 60);
            this.tbNombreModif.Name = "tbNombreModif";
            this.tbNombreModif.Size = new System.Drawing.Size(125, 20);
            this.tbNombreModif.TabIndex = 8;
            // 
            // tbDniModif
            // 
            this.tbDniModif.Location = new System.Drawing.Point(13, 35);
            this.tbDniModif.Name = "tbDniModif";
            this.tbDniModif.Size = new System.Drawing.Size(125, 20);
            this.tbDniModif.TabIndex = 7;
            // 
            // lblDireccionModif
            // 
            this.lblDireccionModif.AutoSize = true;
            this.lblDireccionModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionModif.Location = new System.Drawing.Point(152, 164);
            this.lblDireccionModif.Name = "lblDireccionModif";
            this.lblDireccionModif.Size = new System.Drawing.Size(61, 13);
            this.lblDireccionModif.TabIndex = 6;
            this.lblDireccionModif.Text = "Direccion";
            // 
            // lblFechaNacModif
            // 
            this.lblFechaNacModif.AutoSize = true;
            this.lblFechaNacModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacModif.Location = new System.Drawing.Point(152, 139);
            this.lblFechaNacModif.Name = "lblFechaNacModif";
            this.lblFechaNacModif.Size = new System.Drawing.Size(109, 13);
            this.lblFechaNacModif.TabIndex = 5;
            this.lblFechaNacModif.Text = "Fecha Nacimiento";
            // 
            // lblTelefonoModif
            // 
            this.lblTelefonoModif.AutoSize = true;
            this.lblTelefonoModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoModif.Location = new System.Drawing.Point(152, 114);
            this.lblTelefonoModif.Name = "lblTelefonoModif";
            this.lblTelefonoModif.Size = new System.Drawing.Size(57, 13);
            this.lblTelefonoModif.TabIndex = 4;
            this.lblTelefonoModif.Text = "Telefono";
            // 
            // lblApellidoModif
            // 
            this.lblApellidoModif.AutoSize = true;
            this.lblApellidoModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoModif.Location = new System.Drawing.Point(152, 89);
            this.lblApellidoModif.Name = "lblApellidoModif";
            this.lblApellidoModif.Size = new System.Drawing.Size(52, 13);
            this.lblApellidoModif.TabIndex = 3;
            this.lblApellidoModif.Text = "Apellido";
            // 
            // lblNombreModif
            // 
            this.lblNombreModif.AutoSize = true;
            this.lblNombreModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreModif.Location = new System.Drawing.Point(152, 64);
            this.lblNombreModif.Name = "lblNombreModif";
            this.lblNombreModif.Size = new System.Drawing.Size(50, 13);
            this.lblNombreModif.TabIndex = 2;
            this.lblNombreModif.Text = "Nombre";
            // 
            // lblDniModif
            // 
            this.lblDniModif.AutoSize = true;
            this.lblDniModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniModif.Location = new System.Drawing.Point(152, 39);
            this.lblDniModif.Name = "lblDniModif";
            this.lblDniModif.Size = new System.Drawing.Size(26, 13);
            this.lblDniModif.TabIndex = 1;
            this.lblDniModif.Text = "Dni";
            // 
            // lblTituloModif
            // 
            this.lblTituloModif.AutoSize = true;
            this.lblTituloModif.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblTituloModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloModif.Location = new System.Drawing.Point(86, 3);
            this.lblTituloModif.Name = "lblTituloModif";
            this.lblTituloModif.Size = new System.Drawing.Size(108, 15);
            this.lblTituloModif.TabIndex = 0;
            this.lblTituloModif.Text = "Modificar Datos";
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlEliminar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEliminar.Controls.Add(this.lblDniEliminar);
            this.pnlEliminar.Controls.Add(this.btnEliminar);
            this.pnlEliminar.Controls.Add(this.tbDniEliminar);
            this.pnlEliminar.Enabled = false;
            this.pnlEliminar.Location = new System.Drawing.Point(315, 428);
            this.pnlEliminar.Name = "pnlEliminar";
            this.pnlEliminar.Size = new System.Drawing.Size(262, 119);
            this.pnlEliminar.TabIndex = 6;
            // 
            // lblDniEliminar
            // 
            this.lblDniEliminar.AutoSize = true;
            this.lblDniEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniEliminar.Location = new System.Drawing.Point(54, 30);
            this.lblDniEliminar.Name = "lblDniEliminar";
            this.lblDniEliminar.Size = new System.Drawing.Size(35, 15);
            this.lblDniEliminar.TabIndex = 2;
            this.lblDniEliminar.Text = "DNI:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(65, 73);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(128, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar a Persona Seleccionada";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tbDniEliminar
            // 
            this.tbDniEliminar.Location = new System.Drawing.Point(104, 29);
            this.tbDniEliminar.Name = "tbDniEliminar";
            this.tbDniEliminar.ReadOnly = true;
            this.tbDniEliminar.Size = new System.Drawing.Size(100, 20);
            this.tbDniEliminar.TabIndex = 0;
            // 
            // frmGestionPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 559);
            this.Controls.Add(this.pnlEliminar);
            this.Controls.Add(this.pnlModificar);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.dgvListarPersonas);
            this.Controls.Add(this.pnlAgregar);
            this.Name = "frmGestionPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGestionPersonas";
            this.Load += new System.EventHandler(this.frmAgregarPersonas_Load);
            this.pnlAgregar.ResumeLayout(false);
            this.pnlAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarPersonas)).EndInit();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.pnlModificar.ResumeLayout(false);
            this.pnlModificar.PerformLayout();
            this.pnlEliminar.ResumeLayout(false);
            this.pnlEliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAgregar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblAgregarTitulo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.DataGridView dgvListarPersonas;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Label lblTituloBusqueda;
        private System.Windows.Forms.Button btnListarPersonas;
        private System.Windows.Forms.Panel pnlModificar;
        private System.Windows.Forms.Label lblNombreGrupoModif;
        private System.Windows.Forms.ComboBox cbNombreGrupoModif;
        private System.Windows.Forms.Button btnModificarDatos;
        private System.Windows.Forms.DateTimePicker dtpFechaNacModif;
        private System.Windows.Forms.TextBox tbDireccionModif;
        private System.Windows.Forms.TextBox tbTelefonoModif;
        private System.Windows.Forms.TextBox tbApellidoModif;
        private System.Windows.Forms.TextBox tbNombreModif;
        private System.Windows.Forms.TextBox tbDniModif;
        private System.Windows.Forms.Label lblDireccionModif;
        private System.Windows.Forms.Label lblFechaNacModif;
        private System.Windows.Forms.Label lblTelefonoModif;
        private System.Windows.Forms.Label lblApellidoModif;
        private System.Windows.Forms.Label lblNombreModif;
        private System.Windows.Forms.Label lblDniModif;
        private System.Windows.Forms.Label lblTituloModif;
        private System.Windows.Forms.Label lblPareja;
        private System.Windows.Forms.ComboBox cbLider;
        private System.Windows.Forms.Panel pnlEliminar;
        private System.Windows.Forms.Label lblDniEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox tbDniEliminar;
    }
}