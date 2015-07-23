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
    public partial class frmGestionGrupo : Form
    {
        public frmGestionGrupo()
        {
            InitializeComponent();
        }
        clsGrupo oGrupo;
        clsPersona oPersona;
        DataTable dtIntegrantes;
        BindingSource bsGrupos;
        crIntengrantes crystal_Integrantes;
        private void btnListarGrupos_Click(object sender, EventArgs e)
        {
            oGrupo = new clsGrupo();
            bsGrupos = new BindingSource();
            bsGrupos.DataSource = oGrupo.listarGrupos();
            dgvDatos.DataSource = bsGrupos;
            if (dgvDatos.DataSource != null)
            {
                lblTitulo.Text = "Se muestran Todos los Gupos";
                cbxFiltro.Enabled = true;
                tbBusqueda.Enabled = true;
                pnlBusquedaIntegrantes.Enabled = true;
                pnlEliminar.Enabled = true;
                lblOpcion.Text = "Seleccione una Opcion" + "\n" + "de busqueda";

                dgvDatos.Columns["contrasena"].Visible = false;
                dgvDatos.Columns["eliminado"].Visible = false;
            }
        }

        private void cbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFiltro.SelectedIndex == 0)
            {
                lblBusqueda.Text = "Escriba Nombre: ";
            }
        }

        private void tbBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (cbxFiltro.SelectedIndex == 0)
            {
                bsGrupos.Filter = "nombre like'" + tbBusqueda.Text + "%'";
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            int indice = dgvDatos.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (indice != -1)
            {
                tbNombreGrupo.Text = dgvDatos["nombre", indice].Value.ToString();
                tbNombreGrupoElim.Text = dgvDatos["nombre", indice].Value.ToString();
            }
        }

        private void btnListarIntegrantes_Click(object sender, EventArgs e)
        {
            int indice = dgvDatos.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int codigo;
            if (indice != -1)
            {
                oPersona = new clsPersona();
                crystal_Integrantes = new crIntengrantes();
                codigo = Convert.ToInt32(dgvDatos["codigo_grupo", indice].Value.ToString());
                
                //aca traigo los datos en un datatable
                dtIntegrantes = oPersona.listarIntegrantes(codigo);
                if (dtIntegrantes.Rows.Count != 0)
                {
                    crystal_Integrantes.SetDataSource(dtIntegrantes);
                    crystal_Integrantes.SetParameterValue("nombre_grupo", tbNombreGrupo.Text);
                    frmVisorIntegrantes formIntegrantes = new frmVisorIntegrantes();
                    formIntegrantes.crvIntegrantes.ReportSource = crystal_Integrantes;
                    formIntegrantes.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Este Grupo no tiene integrantes");
                }
            }
        }

        private void btnEliminarGrupo_Click(object sender, EventArgs e)
        {
            int indice = dgvDatos.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int codigo;
            string res;
            if (indice != -1)
            {
                oPersona = new clsPersona();
                codigo = Convert.ToInt32(dgvDatos["codigo_grupo", indice].Value.ToString());
                res = oGrupo.eliminarGrupo(codigo);
                if (res == "")
                {
                    MessageBox.Show("Grupo Correctamente Eliminado");
                }
            }
        }

        private void btnEnviarInforme_Click(object sender, EventArgs e)
        {
            int indice = dgvDatos.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            frmAdminInforme formInforme = new frmAdminInforme();
            formInforme.nombre_grupo = dgvDatos["nombre", indice].Value.ToString();
            formInforme.ShowDialog();
        }

        private void btnGruposNoForm_Click(object sender, EventArgs e)
        {
            oGrupo = new clsGrupo();
            bsGrupos = new BindingSource();
            bsGrupos.DataSource = oGrupo.listarGrupos_No_Formulario();
            dgvDatos.DataSource = bsGrupos;
            if (dgvDatos.DataSource != null)
            {
                lblTitulo.Text = "Se muestran aquellos Grupos que no han enviado formularios";
                dgvDatos.Columns["contrasena"].Visible = false;
                dgvDatos.Columns["eliminado"].Visible = false;
                pnlBusquedaIntegrantes.Enabled = true;
            }
        }
        
        
    }
}
