namespace Proyecto_Laboratorio
{
    partial class frmVisorFormulario
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
            this.crvVisorFormulario = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvVisorFormulario
            // 
            this.crvVisorFormulario.ActiveViewIndex = -1;
            this.crvVisorFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVisorFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvVisorFormulario.Location = new System.Drawing.Point(0, 0);
            this.crvVisorFormulario.Name = "crvVisorFormulario";
            this.crvVisorFormulario.SelectionFormula = "";
            this.crvVisorFormulario.Size = new System.Drawing.Size(900, 473);
            this.crvVisorFormulario.TabIndex = 0;
            this.crvVisorFormulario.ViewTimeSelectionFormula = "";
            // 
            // frmVisorFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 473);
            this.Controls.Add(this.crvVisorFormulario);
            this.Name = "frmVisorFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVisorFormulario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVisorFormulario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvVisorFormulario;

    }
}