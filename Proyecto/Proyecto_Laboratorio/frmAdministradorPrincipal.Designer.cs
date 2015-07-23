namespace Proyecto_Laboratorio
{
    partial class frmAdministradorPrincipal
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
            this.btnCrearMensajes = new System.Windows.Forms.Button();
            this.btnPersona = new System.Windows.Forms.Button();
            this.btnGestionGrupo = new System.Windows.Forms.Button();
            this.btnFormularios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearMensajes
            // 
            this.btnCrearMensajes.Location = new System.Drawing.Point(120, 80);
            this.btnCrearMensajes.Name = "btnCrearMensajes";
            this.btnCrearMensajes.Size = new System.Drawing.Size(92, 23);
            this.btnCrearMensajes.TabIndex = 0;
            this.btnCrearMensajes.Text = "Emitir Prédica";
            this.btnCrearMensajes.UseVisualStyleBackColor = true;
            this.btnCrearMensajes.Click += new System.EventHandler(this.btnCrearMensajes_Click);
            // 
            // btnPersona
            // 
            this.btnPersona.Location = new System.Drawing.Point(120, 196);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(117, 23);
            this.btnPersona.TabIndex = 1;
            this.btnPersona.Text = "Gestion de Personas";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // btnGestionGrupo
            // 
            this.btnGestionGrupo.Location = new System.Drawing.Point(356, 196);
            this.btnGestionGrupo.Name = "btnGestionGrupo";
            this.btnGestionGrupo.Size = new System.Drawing.Size(117, 23);
            this.btnGestionGrupo.TabIndex = 2;
            this.btnGestionGrupo.Text = "Gestion de Grupo";
            this.btnGestionGrupo.UseVisualStyleBackColor = true;
            this.btnGestionGrupo.Click += new System.EventHandler(this.btnGestionGrupo_Click);
            // 
            // btnFormularios
            // 
            this.btnFormularios.Location = new System.Drawing.Point(356, 80);
            this.btnFormularios.Name = "btnFormularios";
            this.btnFormularios.Size = new System.Drawing.Size(117, 23);
            this.btnFormularios.TabIndex = 3;
            this.btnFormularios.Text = "Gestion Formularios";
            this.btnFormularios.UseVisualStyleBackColor = true;
            this.btnFormularios.Click += new System.EventHandler(this.btnFormularios_Click);
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 438);
            this.Controls.Add(this.btnFormularios);
            this.Controls.Add(this.btnGestionGrupo);
            this.Controls.Add(this.btnPersona);
            this.Controls.Add(this.btnCrearMensajes);
            this.Name = "frmAdministrador";
            this.Text = "frmAdministrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearMensajes;
        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.Button btnGestionGrupo;
        private System.Windows.Forms.Button btnFormularios;
    }
}