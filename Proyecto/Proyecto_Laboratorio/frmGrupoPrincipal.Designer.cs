namespace Proyecto_Laboratorio
{
    partial class frmGrupoPrincipal
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
            this.btnLlenarFormulario = new System.Windows.Forms.Button();
            this.btnIntegrantes = new System.Windows.Forms.Button();
            this.btnFaltas = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLlenarFormulario
            // 
            this.btnLlenarFormulario.Location = new System.Drawing.Point(54, 43);
            this.btnLlenarFormulario.Name = "btnLlenarFormulario";
            this.btnLlenarFormulario.Size = new System.Drawing.Size(120, 23);
            this.btnLlenarFormulario.TabIndex = 0;
            this.btnLlenarFormulario.Text = "Llenar un Formulario";
            this.btnLlenarFormulario.UseVisualStyleBackColor = true;
            this.btnLlenarFormulario.Click += new System.EventHandler(this.btnLlenarFormulario_Click);
            // 
            // btnIntegrantes
            // 
            this.btnIntegrantes.Location = new System.Drawing.Point(54, 123);
            this.btnIntegrantes.Name = "btnIntegrantes";
            this.btnIntegrantes.Size = new System.Drawing.Size(120, 23);
            this.btnIntegrantes.TabIndex = 1;
            this.btnIntegrantes.Text = "Integrantes";
            this.btnIntegrantes.UseVisualStyleBackColor = true;
            this.btnIntegrantes.Click += new System.EventHandler(this.btnIntegrantes_Click);
            // 
            // btnFaltas
            // 
            this.btnFaltas.Location = new System.Drawing.Point(225, 43);
            this.btnFaltas.Name = "btnFaltas";
            this.btnFaltas.Size = new System.Drawing.Size(149, 23);
            this.btnFaltas.TabIndex = 2;
            this.btnFaltas.Text = "Cargar / Verificar Faltas";
            this.btnFaltas.UseVisualStyleBackColor = true;
            this.btnFaltas.Click += new System.EventHandler(this.btnFaltas_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(225, 123);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(112, 23);
            this.btnInforme.TabIndex = 3;
            this.btnInforme.Text = "Gestion de Informes";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // frmGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 283);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnFaltas);
            this.Controls.Add(this.btnIntegrantes);
            this.Controls.Add(this.btnLlenarFormulario);
            this.Name = "frmGrupo";
            this.Text = "Bienvenido grupo";
            this.Load += new System.EventHandler(this.frmGrupo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLlenarFormulario;
        private System.Windows.Forms.Button btnIntegrantes;
        private System.Windows.Forms.Button btnFaltas;
        private System.Windows.Forms.Button btnInforme;
    }
}