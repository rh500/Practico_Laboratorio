namespace Proyecto_Laboratorio
{
    partial class frmCargarAsistencia
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
            this.pnlFunciones = new System.Windows.Forms.Panel();
            this.btnCargarFaltas = new System.Windows.Forms.Button();
            this.btnListarIntegrantes = new System.Windows.Forms.Button();
            this.btnListarAsistencias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).BeginInit();
            this.pnlFunciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIntegrantes
            // 
            this.dgvIntegrantes.AllowUserToAddRows = false;
            this.dgvIntegrantes.AllowUserToDeleteRows = false;
            this.dgvIntegrantes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvIntegrantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvIntegrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntegrantes.Location = new System.Drawing.Point(12, 12);
            this.dgvIntegrantes.MultiSelect = false;
            this.dgvIntegrantes.Name = "dgvIntegrantes";
            this.dgvIntegrantes.Size = new System.Drawing.Size(744, 282);
            this.dgvIntegrantes.TabIndex = 0;
            // 
            // pnlFunciones
            // 
            this.pnlFunciones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlFunciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFunciones.Controls.Add(this.btnCargarFaltas);
            this.pnlFunciones.Controls.Add(this.btnListarIntegrantes);
            this.pnlFunciones.Location = new System.Drawing.Point(33, 300);
            this.pnlFunciones.Name = "pnlFunciones";
            this.pnlFunciones.Size = new System.Drawing.Size(220, 126);
            this.pnlFunciones.TabIndex = 2;
            // 
            // btnCargarFaltas
            // 
            this.btnCargarFaltas.Enabled = false;
            this.btnCargarFaltas.Location = new System.Drawing.Point(57, 79);
            this.btnCargarFaltas.Name = "btnCargarFaltas";
            this.btnCargarFaltas.Size = new System.Drawing.Size(98, 23);
            this.btnCargarFaltas.TabIndex = 4;
            this.btnCargarFaltas.Text = "Cargar Faltas";
            this.btnCargarFaltas.UseVisualStyleBackColor = true;
            this.btnCargarFaltas.Click += new System.EventHandler(this.btnCargarFaltas_Click);
            // 
            // btnListarIntegrantes
            // 
            this.btnListarIntegrantes.Location = new System.Drawing.Point(57, 31);
            this.btnListarIntegrantes.Name = "btnListarIntegrantes";
            this.btnListarIntegrantes.Size = new System.Drawing.Size(98, 23);
            this.btnListarIntegrantes.TabIndex = 3;
            this.btnListarIntegrantes.Text = "Listar Integrantes";
            this.btnListarIntegrantes.UseVisualStyleBackColor = true;
            this.btnListarIntegrantes.Click += new System.EventHandler(this.btnListarIntegrantes_Click);
            // 
            // btnListarAsistencias
            // 
            this.btnListarAsistencias.Location = new System.Drawing.Point(408, 381);
            this.btnListarAsistencias.Name = "btnListarAsistencias";
            this.btnListarAsistencias.Size = new System.Drawing.Size(98, 23);
            this.btnListarAsistencias.TabIndex = 3;
            this.btnListarAsistencias.Text = "Listar Asistencias";
            this.btnListarAsistencias.UseVisualStyleBackColor = true;
            this.btnListarAsistencias.Click += new System.EventHandler(this.btnListarAsistencias_Click);
            // 
            // frmCargarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 477);
            this.Controls.Add(this.btnListarAsistencias);
            this.Controls.Add(this.pnlFunciones);
            this.Controls.Add(this.dgvIntegrantes);
            this.Name = "frmCargarAsistencia";
            this.Text = "frmFaltas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).EndInit();
            this.pnlFunciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIntegrantes;
        private System.Windows.Forms.Panel pnlFunciones;
        private System.Windows.Forms.Button btnCargarFaltas;
        private System.Windows.Forms.Button btnListarIntegrantes;
        private System.Windows.Forms.Button btnListarAsistencias;
    }
}