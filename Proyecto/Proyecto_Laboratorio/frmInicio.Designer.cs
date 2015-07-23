namespace Proyecto_Laboratorio
{
    partial class frmInicio
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
            this.ctrUsu_Login1 = new Controles_y_Utilidades.ctrUsu_Login();
            this.SuspendLayout();
            // 
            // ctrUsu_Login1
            // 
            this.ctrUsu_Login1.BASEDATOS = "Practico_Laboratorio";
            this.ctrUsu_Login1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrUsu_Login1.Location = new System.Drawing.Point(12, 12);
            this.ctrUsu_Login1.Name = "ctrUsu_Login1";
            this.ctrUsu_Login1.SERVIDOR = "25.60.2.145";
            this.ctrUsu_Login1.Size = new System.Drawing.Size(346, 102);
            this.ctrUsu_Login1.TabIndex = 0;
            this.ctrUsu_Login1.Conexion_Exitosa += new Controles_y_Utilidades.ctrUsu_Login.delConexion(this.ctrUsu_Login1_Conexion_Exitosa);
            this.ctrUsu_Login1.Conexion_Fallida += new Controles_y_Utilidades.ctrUsu_Login.delConexion(this.ctrUsu_Login1_Conexion_Fallida);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 242);
            this.Controls.Add(this.ctrUsu_Login1);
            this.Name = "frmInicio";
            this.Text = "Inicio de Sesion";

            this.ResumeLayout(false);

        }

        #endregion

        private Controles_y_Utilidades.ctrUsu_Login ctrUsu_Login1;




    }
}

