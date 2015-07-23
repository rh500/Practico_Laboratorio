namespace Proyecto_Laboratorio
{
    partial class frmAdminInforme
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
            this.btnEnviarInforme = new System.Windows.Forms.Button();
            this.tbInforme = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbTituloGrupo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.tbTituloInforme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnviarInforme
            // 
            this.btnEnviarInforme.Location = new System.Drawing.Point(415, 384);
            this.btnEnviarInforme.Name = "btnEnviarInforme";
            this.btnEnviarInforme.Size = new System.Drawing.Size(98, 23);
            this.btnEnviarInforme.TabIndex = 2;
            this.btnEnviarInforme.Text = "Enviar Informe";
            this.btnEnviarInforme.UseVisualStyleBackColor = true;
            this.btnEnviarInforme.Click += new System.EventHandler(this.btnEnviarInforme_Click);
            // 
            // tbInforme
            // 
            this.tbInforme.Location = new System.Drawing.Point(179, 166);
            this.tbInforme.Multiline = true;
            this.tbInforme.Name = "tbInforme";
            this.tbInforme.Size = new System.Drawing.Size(334, 212);
            this.tbInforme.TabIndex = 1;
            this.tbInforme.Enter += new System.EventHandler(this.tbTituloInforme_Enter);
            // 
            // tbTitulo
            // 
            this.tbTitulo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitulo.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitulo.Location = new System.Drawing.Point(34, 34);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.ReadOnly = true;
            this.tbTitulo.Size = new System.Drawing.Size(479, 22);
            this.tbTitulo.TabIndex = 4;
            // 
            // tbTituloGrupo
            // 
            this.tbTituloGrupo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbTituloGrupo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTituloGrupo.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTituloGrupo.Location = new System.Drawing.Point(34, 62);
            this.tbTituloGrupo.Name = "tbTituloGrupo";
            this.tbTituloGrupo.ReadOnly = true;
            this.tbTituloGrupo.Size = new System.Drawing.Size(479, 22);
            this.tbTituloGrupo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(30, 134);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 17);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(30, 166);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(126, 17);
            this.lblTexto.TabIndex = 7;
            this.lblTexto.Text = "Texto del Informe";
            // 
            // tbTituloInforme
            // 
            this.tbTituloInforme.Location = new System.Drawing.Point(179, 135);
            this.tbTituloInforme.Name = "tbTituloInforme";
            this.tbTituloInforme.Size = new System.Drawing.Size(159, 20);
            this.tbTituloInforme.TabIndex = 0;
            this.tbTituloInforme.Enter += new System.EventHandler(this.tbTituloInforme_Enter);
            // 
            // frmEnviarInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 451);
            this.Controls.Add(this.tbTituloInforme);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tbTituloGrupo);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.tbInforme);
            this.Controls.Add(this.btnEnviarInforme);
            this.Name = "frmEnviarInformes";
            this.Text = "frmEnviarInforme";
            this.Load += new System.EventHandler(this.frmEnviarInformes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviarInforme;
        private System.Windows.Forms.TextBox tbInforme;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbTituloGrupo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox tbTituloInforme;
    }
}