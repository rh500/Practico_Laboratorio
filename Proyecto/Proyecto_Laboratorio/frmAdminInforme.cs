using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mi_Biblioteca;

namespace Proyecto_Laboratorio
{
    public partial class frmAdminInforme : Form
    {
        public frmAdminInforme()
        {
            InitializeComponent();
        }
        public int codigo_grupo;
        public string titulo_formulario = "";
        public string nombre_grupo = "";
        clsInforme oInforme;

        private void frmEnviarInformes_Load(object sender, EventArgs e)
        {
            if (titulo_formulario == "")
            {
                this.Text = "Informe para un Grupo";
                tbTitulo.Text = "Informe para Grupo: " + nombre_grupo;
            }
            else
            {
                this.Text = "Informe para un Formulario de Grupo";
                tbTitulo.Text = "Informe de Formulario: '" + titulo_formulario + "' ";
                tbTituloGrupo.Text = "Grupo: " + nombre_grupo;
            }
        }

        private void btnEnviarInforme_Click(object sender, EventArgs e)
        {
            bool x = true;
            if (tbInforme.Text == "" || tbInforme.Text == null)
            {
                x = false;
                tbInforme.BackColor = Color.Red;
            }
            if (tbTituloInforme.Text == "" || tbTituloInforme.Text == null)
            {
                x = false;
                tbTituloInforme.BackColor = Color.Red;
            }

            if (x)
            {
                string res = "";
                oInforme = new clsInforme();
                oInforme.Titulo = tbTituloInforme.Text;
                oInforme.Codigo_grupo = codigo_grupo;
                oInforme.Fecha_creacion = DateTime.Today.Date;
                oInforme.Texto = tbInforme.Text;
                oInforme.Tipo = "de Admin";
                res = oInforme.agregarInforme();
                if (res == "")
                {
                    MessageBox.Show("Informe Correctamente enviado.");
                    if (titulo_formulario == "")
                    {
                        if (DialogResult.Yes == MessageBox.Show("Desea enviar otro informe para este Grupo?", "", MessageBoxButtons.YesNo))
                        {
                            tbInforme.Text = "";
                            tbInforme.Focus();
                        }
                        else
                        {
                            btnEnviarInforme.Enabled = false;
                        }
                    }
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Desea enviar otro informe con respecto a este Formulario?", "", MessageBoxButtons.YesNo))
                        {
                            tbInforme.Text = "";
                            tbInforme.Focus();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor llene los campos de texto correctamente");
                tbTituloInforme.Focus();
            }
        }

        private void tbTituloInforme_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                (sender as TextBox).BackColor = Color.White;
            }
        }

        
    }
}
