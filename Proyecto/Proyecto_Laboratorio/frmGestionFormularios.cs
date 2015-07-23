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
    public partial class frmGestionFormularios : Form
    {
        public frmGestionFormularios()
        {
            InitializeComponent();
        }
        clsFormulario oFormulario;
        clsMensaje_Predica oMensaje;
        BindingSource bsFormularios;
        crFormulario crystalFormulario;
        DataTable dtFormulario;

        private void btnListarFormularios_Click(object sender, EventArgs e)
        {
            oFormulario = new clsFormulario();
            bsFormularios = new BindingSource();
            bsFormularios.DataSource = oFormulario.listarFormularios_Mensaje_Grupo();
            dgvListaFormularios.DataSource = bsFormularios;
            if (dgvListaFormularios.DataSource != null)
            {
                cbxFiltro.Enabled = true;
                lblOpcion.Text = "Seleccione una Opcion" + "\n" + "de busqueda";
                dgvListaFormularios.Columns["id_mensaje"].Visible = false;
                dgvListaFormularios.Columns["codigo_grupo"].Visible = false;
                btnVisualizar.Enabled = true;
                btnEnviarInforme.Enabled = true;
            }
        }

        private void cbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime fecha_mensaje_minimo;
            DateTime fecha_mensaje_maximo;
            if (cbxFiltro.SelectedIndex == 0)
            {
                oMensaje = new clsMensaje_Predica();
                oMensaje.MensajeReciente();

                fecha_mensaje_minimo = oMensaje.Fecha_emitido;
                fecha_mensaje_maximo = oMensaje.Fecha_emitido.AddDays(7);
                fecha_mensaje_minimo.Date.ToString("dd/mm/yyyy");
                fecha_mensaje_maximo.Date.ToString("dd/mm/yyyy");

                bsFormularios.Filter = String.Format("fecha_llenado >= '{0:dd-MM-yyyy}' AND fecha_llenado < '{1:dd-MM-yyyy}'", fecha_mensaje_minimo, fecha_mensaje_maximo);
                lblOpcion.Text = "Formularios"+"\n"+"de esta semana.";
            }
            if (cbxFiltro.SelectedIndex == 1)
            {
                lblOpcion.Text = "Escriba el Título"+"\n"+ "del mensaje: ";
                tbBusqueda.Enabled = true;
            }
            if (cbxFiltro.SelectedIndex == 2)
            {
                lblOpcion.Text = "Escriba Nombre"+"\n"+"del grupo: ";
                tbBusqueda.Enabled = true;
            }
        }

        private void tbBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (cbxFiltro.SelectedIndex == 0)
            {
                bsFormularios.Filter = "titulo like '%" + tbBusqueda.Text + "%'";
            }
            if (cbxFiltro.SelectedIndex == 1)
            {
                bsFormularios.Filter = "nombre like '%" + tbBusqueda.Text + "%'";
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            int indice = dgvListaFormularios.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int codigo;
            int id_mensaje;
            if (indice != -1)
            {
                oFormulario = new clsFormulario();
                crystalFormulario = new crFormulario();
                frmVisorFormulario formFormulario = new frmVisorFormulario();
                id_mensaje = Convert.ToInt32(dgvListaFormularios["id_mensaje", indice].Value.ToString());
                codigo = Convert.ToInt32(dgvListaFormularios["codigo_grupo", indice].Value.ToString());

                dtFormulario = oFormulario.buscarFormulario_Mensaje(id_mensaje, codigo);
                crystalFormulario.SetDataSource(dtFormulario);
                formFormulario.crvVisorFormulario.ReportSource = crystalFormulario;
                formFormulario.ShowDialog();
            }
        }

        private void btnEnviarInforme_Click(object sender, EventArgs e)
        {
            int indice = dgvListaFormularios.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            frmAdminInforme formInforme = new frmAdminInforme();
            formInforme.titulo_formulario = dgvListaFormularios["titulo", indice].Value.ToString();
            formInforme.nombre_grupo = dgvListaFormularios["nombre", indice].Value.ToString();
            formInforme.codigo_grupo = Convert.ToInt32(dgvListaFormularios["codigo_grupo", indice].Value.ToString());
            formInforme.ShowDialog();
        }




    }
}
