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
    public partial class frmAdministradorPrincipal : Form
    {
        public frmAdministradorPrincipal()
        {
            InitializeComponent();
        }
        clsMensaje_Predica oMensaje;
        private void btnCrearMensajes_Click(object sender, EventArgs e)
        {
            oMensaje = new clsMensaje_Predica();
            if (!oMensaje.HayMensaje())
            {
                frmEmitirPredica formEmitirPredica = new frmEmitirPredica();
                formEmitirPredica.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ya has enviado una prédica por esta semana espera a la proxima para realizarlo nuevamente");
            }
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            frmGestionPersonas formPersonas = new frmGestionPersonas();
            formPersonas.ShowDialog();
        }

        private void btnGestionGrupo_Click(object sender, EventArgs e)
        {
            frmGestionGrupo formGrupos = new frmGestionGrupo();
            formGrupos.ShowDialog();
        }

        private void btnFormularios_Click(object sender, EventArgs e)
        {
            frmGestionFormularios formFormularios = new frmGestionFormularios();
            formFormularios.ShowDialog();
        }
    }
}
