namespace Proyecto_Laboratorio
{
    partial class frmVisorIntegrantes
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
            this.crvIntegrantes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvIntegrantes
            // 
            this.crvIntegrantes.ActiveViewIndex = -1;
            this.crvIntegrantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvIntegrantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvIntegrantes.Location = new System.Drawing.Point(0, 0);
            this.crvIntegrantes.Name = "crvIntegrantes";
            this.crvIntegrantes.SelectionFormula = "";
            this.crvIntegrantes.Size = new System.Drawing.Size(1050, 499);
            this.crvIntegrantes.TabIndex = 0;
            this.crvIntegrantes.ViewTimeSelectionFormula = "";
            // 
            // frmVisorIntegrantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 499);
            this.Controls.Add(this.crvIntegrantes);
            this.Name = "frmVisorIntegrantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVisorIntegrantes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvIntegrantes;

    }
}