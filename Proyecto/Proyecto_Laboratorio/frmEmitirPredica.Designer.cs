namespace Proyecto_Laboratorio
{
    partial class frmEmitirPredica
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
            this.tbVersiculos = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.lblVersiculos = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.rtbMensaje = new System.Windows.Forms.RichTextBox();
            this.btnCrearMensaje = new System.Windows.Forms.Button();
            this.lblVersiculoEjemplo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbVersiculos
            // 
            this.tbVersiculos.Location = new System.Drawing.Point(159, 71);
            this.tbVersiculos.Multiline = true;
            this.tbVersiculos.Name = "tbVersiculos";
            this.tbVersiculos.Size = new System.Drawing.Size(185, 88);
            this.tbVersiculos.TabIndex = 8;
            this.tbVersiculos.Enter += new System.EventHandler(this.tbTitulo_Enter);
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(159, 41);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(185, 20);
            this.tbTitulo.TabIndex = 7;
            this.tbTitulo.Enter += new System.EventHandler(this.tbTitulo_Enter);
            // 
            // lblVersiculos
            // 
            this.lblVersiculos.AutoSize = true;
            this.lblVersiculos.Location = new System.Drawing.Point(50, 70);
            this.lblVersiculos.Name = "lblVersiculos";
            this.lblVersiculos.Size = new System.Drawing.Size(57, 13);
            this.lblVersiculos.TabIndex = 10;
            this.lblVersiculos.Text = "Versículos";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(50, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Título";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(50, 172);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(47, 13);
            this.lblMensaje.TabIndex = 11;
            this.lblMensaje.Text = "Mensaje";
            // 
            // rtbMensaje
            // 
            this.rtbMensaje.Location = new System.Drawing.Point(159, 169);
            this.rtbMensaje.Name = "rtbMensaje";
            this.rtbMensaje.Size = new System.Drawing.Size(386, 281);
            this.rtbMensaje.TabIndex = 12;
            this.rtbMensaje.Text = "";
            this.rtbMensaje.Enter += new System.EventHandler(this.tbTitulo_Enter);
            // 
            // btnCrearMensaje
            // 
            this.btnCrearMensaje.Location = new System.Drawing.Point(448, 456);
            this.btnCrearMensaje.Name = "btnCrearMensaje";
            this.btnCrearMensaje.Size = new System.Drawing.Size(97, 23);
            this.btnCrearMensaje.TabIndex = 13;
            this.btnCrearMensaje.Text = "Crear Mensaje";
            this.btnCrearMensaje.UseVisualStyleBackColor = true;
            this.btnCrearMensaje.Click += new System.EventHandler(this.btnCrearMensaje_Click);
            // 
            // lblVersiculoEjemplo
            // 
            this.lblVersiculoEjemplo.AutoSize = true;
            this.lblVersiculoEjemplo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersiculoEjemplo.Location = new System.Drawing.Point(350, 86);
            this.lblVersiculoEjemplo.Name = "lblVersiculoEjemplo";
            this.lblVersiculoEjemplo.Size = new System.Drawing.Size(204, 26);
            this.lblVersiculoEjemplo.TabIndex = 14;
            this.lblVersiculoEjemplo.Text = "Separe cada versiculo con punto y coma \r\npor ej: Juan 3:16; Filipenses 4:13";
            // 
            // frmEmitirPredica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 485);
            this.Controls.Add(this.lblVersiculoEjemplo);
            this.Controls.Add(this.btnCrearMensaje);
            this.Controls.Add(this.rtbMensaje);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.tbVersiculos);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.lblVersiculos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmEmitirPredica";
            this.Text = "frmEmitirPredica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVersiculos;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label lblVersiculos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.RichTextBox rtbMensaje;
        private System.Windows.Forms.Button btnCrearMensaje;
        private System.Windows.Forms.Label lblVersiculoEjemplo;
    }
}