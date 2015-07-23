namespace Proyecto_Laboratorio
{
    partial class frmGestionFormularios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListaFormularios = new System.Windows.Forms.DataGridView();
            this.pnlBusquedaGrupos = new System.Windows.Forms.Panel();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.lblTituloBusquedaFormularios = new System.Windows.Forms.Label();
            this.btnListarFormularios = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnEnviarInforme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFormularios)).BeginInit();
            this.pnlBusquedaGrupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaFormularios
            // 
            this.dgvListaFormularios.AllowUserToAddRows = false;
            this.dgvListaFormularios.AllowUserToDeleteRows = false;
            this.dgvListaFormularios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvListaFormularios.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaFormularios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaFormularios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaFormularios.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListaFormularios.Location = new System.Drawing.Point(12, 12);
            this.dgvListaFormularios.MultiSelect = false;
            this.dgvListaFormularios.Name = "dgvListaFormularios";
            this.dgvListaFormularios.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaFormularios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListaFormularios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaFormularios.Size = new System.Drawing.Size(1007, 264);
            this.dgvListaFormularios.TabIndex = 0;
            // 
            // pnlBusquedaGrupos
            // 
            this.pnlBusquedaGrupos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBusquedaGrupos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBusquedaGrupos.Controls.Add(this.lblOpcion);
            this.pnlBusquedaGrupos.Controls.Add(this.lblBusqueda);
            this.pnlBusquedaGrupos.Controls.Add(this.tbBusqueda);
            this.pnlBusquedaGrupos.Controls.Add(this.cbxFiltro);
            this.pnlBusquedaGrupos.Controls.Add(this.lblTituloBusquedaFormularios);
            this.pnlBusquedaGrupos.Controls.Add(this.btnListarFormularios);
            this.pnlBusquedaGrupos.Location = new System.Drawing.Point(386, 297);
            this.pnlBusquedaGrupos.Name = "pnlBusquedaGrupos";
            this.pnlBusquedaGrupos.Size = new System.Drawing.Size(296, 158);
            this.pnlBusquedaGrupos.TabIndex = 6;
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
            this.tbBusqueda.Location = new System.Drawing.Point(152, 103);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(132, 20);
            this.tbBusqueda.TabIndex = 4;
            this.tbBusqueda.TextChanged += new System.EventHandler(this.tbBusqueda_TextChanged);
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltro.Enabled = false;
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "Formulario de esta semana",
            "Titulo del Mensaje",
            "Nombre del Grupo"});
            this.cbxFiltro.Location = new System.Drawing.Point(152, 73);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(132, 21);
            this.cbxFiltro.TabIndex = 3;
            this.cbxFiltro.SelectedIndexChanged += new System.EventHandler(this.cbxFiltro_SelectedIndexChanged);
            // 
            // lblTituloBusquedaFormularios
            // 
            this.lblTituloBusquedaFormularios.AutoSize = true;
            this.lblTituloBusquedaFormularios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloBusquedaFormularios.Location = new System.Drawing.Point(21, 3);
            this.lblTituloBusquedaFormularios.Name = "lblTituloBusquedaFormularios";
            this.lblTituloBusquedaFormularios.Size = new System.Drawing.Size(250, 15);
            this.lblTituloBusquedaFormularios.TabIndex = 1;
            this.lblTituloBusquedaFormularios.Text = "Listar y Buscar Formularios Recibidos";
            // 
            // btnListarFormularios
            // 
            this.btnListarFormularios.Location = new System.Drawing.Point(95, 34);
            this.btnListarFormularios.Name = "btnListarFormularios";
            this.btnListarFormularios.Size = new System.Drawing.Size(102, 23);
            this.btnListarFormularios.TabIndex = 0;
            this.btnListarFormularios.Text = "Listar Formularios";
            this.btnListarFormularios.UseVisualStyleBackColor = true;
            this.btnListarFormularios.Click += new System.EventHandler(this.btnListarFormularios_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Enabled = false;
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(720, 370);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(218, 23);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "Visualizar Formulario Seleccionado";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnEnviarInforme
            // 
            this.btnEnviarInforme.Enabled = false;
            this.btnEnviarInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarInforme.Location = new System.Drawing.Point(720, 405);
            this.btnEnviarInforme.Name = "btnEnviarInforme";
            this.btnEnviarInforme.Size = new System.Drawing.Size(218, 34);
            this.btnEnviarInforme.TabIndex = 8;
            this.btnEnviarInforme.Text = "Enviar un informe del formulario seleccionado";
            this.btnEnviarInforme.UseVisualStyleBackColor = true;
            this.btnEnviarInforme.Click += new System.EventHandler(this.btnEnviarInforme_Click);
            // 
            // frmGestionFormularios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 497);
            this.Controls.Add(this.btnEnviarInforme);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.pnlBusquedaGrupos);
            this.Controls.Add(this.dgvListaFormularios);
            this.Name = "frmGestionFormularios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de formularios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFormularios)).EndInit();
            this.pnlBusquedaGrupos.ResumeLayout(false);
            this.pnlBusquedaGrupos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaFormularios;
        private System.Windows.Forms.Panel pnlBusquedaGrupos;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Label lblTituloBusquedaFormularios;
        private System.Windows.Forms.Button btnListarFormularios;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnEnviarInforme;
    }
}