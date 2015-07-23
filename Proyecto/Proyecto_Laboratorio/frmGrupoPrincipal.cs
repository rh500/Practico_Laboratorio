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
    public partial class frmGrupoPrincipal : Form
    {
        public frmGrupoPrincipal()
        {
            InitializeComponent();
        }
        clsGrupo oGrupo;
        clsMensaje_Predica oMensaje;
        clsPersona oPersona;
        public bool tiene_integrante;

        private void frmGrupo_Load(object sender, EventArgs e)
        {
            DataTable dtIntegrantes = new DataTable();
            oPersona = new clsPersona();
            dtIntegrantes = oPersona.listarIntegrantes(clsUtilidades.codigoGrupo);
            if (dtIntegrantes.Rows.Count == 0)
            {
                MessageBox.Show("Este Grupo no dispone de intengrantes");
                btnLlenarFormulario.Enabled = false;
                btnFaltas.Enabled = false;
                tiene_integrante = false;
            }
            else
            {
                tiene_integrante = true;
            }
        }
        private void btnIntegrantes_Click(object sender, EventArgs e)
        {
            frmGrupoGestionIntegrantes formIntegrantes = new frmGrupoGestionIntegrantes();
            formIntegrantes.ShowDialog();
            this.Refresh();
        }

        private void btnLlenarFormulario_Click(object sender, EventArgs e)
        {
            oGrupo = new clsGrupo();
            oMensaje = new clsMensaje_Predica();
            if (oMensaje.HayMensaje())
            {
                if (oGrupo.HayFormulario(clsUtilidades.codigoGrupo))
                {
                    MessageBox.Show("Ya existe un formulario cargado, espere a que se emita una nueva Prédica");
                    btnLlenarFormulario.Enabled = false;
                }
                else
                {
                    frmLlenarFormulario formLlenarForm = new frmLlenarFormulario();
                    formLlenarForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Por el momento no se ha emitido prédica esta semana");
            }
        }

        private void btnFaltas_Click(object sender, EventArgs e)
        {
            frmCargarAsistencia formCargarAsistencia = new frmCargarAsistencia();
            formCargarAsistencia.ShowDialog();
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            frmInformeGrupo formInforme = new frmInformeGrupo();
            formInforme.ShowDialog();
        }

        
    }
}
