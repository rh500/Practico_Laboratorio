namespace Control_Conexion
{
    partial class ctrlusu_Conexion
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx_Usuario = new System.Windows.Forms.TextBox();
            this.tbx_Contraseña = new System.Windows.Forms.TextBox();
            this.btn_Conexion = new System.Windows.Forms.Button();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_Usuario
            // 
            this.tbx_Usuario.Location = new System.Drawing.Point(93, 18);
            this.tbx_Usuario.Name = "tbx_Usuario";
            this.tbx_Usuario.Size = new System.Drawing.Size(100, 20);
            this.tbx_Usuario.TabIndex = 0;
            // 
            // tbx_Contraseña
            // 
            this.tbx_Contraseña.Location = new System.Drawing.Point(93, 60);
            this.tbx_Contraseña.Name = "tbx_Contraseña";
            this.tbx_Contraseña.PasswordChar = '*';
            this.tbx_Contraseña.Size = new System.Drawing.Size(100, 20);
            this.tbx_Contraseña.TabIndex = 1;
            // 
            // btn_Conexion
            // 
            this.btn_Conexion.Location = new System.Drawing.Point(225, 39);
            this.btn_Conexion.Name = "btn_Conexion";
            this.btn_Conexion.Size = new System.Drawing.Size(75, 23);
            this.btn_Conexion.TabIndex = 2;
            this.btn_Conexion.Text = "Conectar";
            this.btn_Conexion.UseVisualStyleBackColor = true;
            this.btn_Conexion.Click += new System.EventHandler(this.btn_Conexion_Click);
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(16, 21);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_Usuario.TabIndex = 3;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Location = new System.Drawing.Point(16, 60);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(61, 13);
            this.lbl_contraseña.TabIndex = 4;
            this.lbl_contraseña.Text = "Contraseña";
            // 
            // Conexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.btn_Conexion);
            this.Controls.Add(this.tbx_Contraseña);
            this.Controls.Add(this.tbx_Usuario);
            this.Name = "Conexion";
            this.Size = new System.Drawing.Size(336, 119);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Usuario;
        private System.Windows.Forms.TextBox tbx_Contraseña;
        private System.Windows.Forms.Button btn_Conexion;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_contraseña;
    }
}
