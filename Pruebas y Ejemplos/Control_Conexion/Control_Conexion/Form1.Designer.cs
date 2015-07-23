namespace Control_Conexion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlusu_Conexion1 = new Control_Conexion.ctrlusu_Conexion();
            this.SuspendLayout();
            // 
            // ctrlusu_Conexion1
            // 
            this.ctrlusu_Conexion1.BASEDEDATOS = "Practico_Laboratorio";
            this.ctrlusu_Conexion1.Location = new System.Drawing.Point(12, 25);
            this.ctrlusu_Conexion1.Name = "ctrlusu_Conexion1";
            this.ctrlusu_Conexion1.SERVIDOR = "RH500-PC\\SQLEXPRESS";
            this.ctrlusu_Conexion1.Size = new System.Drawing.Size(336, 119);
            this.ctrlusu_Conexion1.TabIndex = 0;
            this.ctrlusu_Conexion1.Conexion_Exitosa += new Control_Conexion.ctrlusu_Conexion.del_Conexion(this.ctrlusu_Conexion1_Conexion_Exitosa);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 259);
            this.Controls.Add(this.ctrlusu_Conexion1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlusu_Conexion conexion1;
        private ctrlusu_Conexion ctrlusu_Conexion1;
    }
}

