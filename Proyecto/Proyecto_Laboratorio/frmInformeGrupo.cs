using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mi_Biblioteca;
using System.Data;

namespace Proyecto_Laboratorio
{
    public partial class frmInformeGrupo : Form
    {
        public frmInformeGrupo()
        {
            InitializeComponent();
        }
        clsMensaje_Predica oMensaje;
        clsInforme oInforme;
        BindingSource bsDatos;
        int idMensaje;
        private void btnListarMensajes_Click(object sender, EventArgs e)
        {
            oMensaje = new clsMensaje_Predica();
            bsDatos = new BindingSource();
            bsDatos.DataSource = oMensaje.ListarMensajes();
            if (bsDatos.DataSource != null)
            {
                dgvMensajes.DataSource = bsDatos;
                dgvMensajes.Columns["id_mensaje"].Visible = false;
                cbxFiltro.Visible = true;
                lblOpcion.Text = "Seleccione una Opcion"+"\n"+"de busqueda";
                btnSeleccionar.Enabled = true;
            }
        }

        private void cbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbBusqueda.Enabled = true;

            if (cbxFiltro.SelectedIndex == 0)
            {
                lblBusqueda.Text = "Escriba Título: ";
            }
            if (cbxFiltro.SelectedIndex == 1)
            {
                lblBusqueda.Text = "Escriba parte del Mensaje:";
            }
            if (cbxFiltro.SelectedIndex == 2)
            {
                lblBusqueda.Text = "Escriba la fecha:";
            }
            tbBusqueda.Text = "";
        }

        private void tbBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (cbxFiltro.SelectedIndex == 0)
            {
                bsDatos.Filter = "titulo like'%" + tbBusqueda.Text + "%'";
            }
            if (cbxFiltro.SelectedIndex == 1)
            {
                bsDatos.Filter = "texto_mensaje like'%" + tbBusqueda.Text + "%'";
            }
            if (cbxFiltro.SelectedIndex == 2)
            {
                lblBusqueda.Text = "Escriba la fecha:";
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int indice = dgvMensajes.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (indice != -1)
            {
                idMensaje = Convert.ToInt32(dgvMensajes["id_mensaje", indice].Value);
                lblTitulopanel.Text = "Título de mensaje Seleccionado :";
                lblTituloMensaje.Text = dgvMensajes["titulo", indice].Value.ToString();
                pnlBusqueda.Enabled = false;
                tbTitulo.Text = "Informe de prédica : '" + dgvMensajes["titulo", indice].Value.ToString()+"'";
                rtbTexto.Focus();
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            bool x = true;
            if (tbTitulo.Text == "" || tbTitulo.Text == null)
            {
                x = false;
                tbTitulo.BackColor = Color.Red;
            }
            if (rtbTexto.Text == "" || rtbTexto.Text == null)
            {
                x = false;
                rtbTexto.BackColor = Color.Red;
            }
            if (x)
            {
                string res = "";
                oInforme = new clsInforme();
                oInforme.Codigo_grupo = clsUtilidades.codigoGrupo;
                oInforme.Fecha_creacion = DateTime.Today.Date;
                oInforme.Titulo = tbTitulo.Text;
                oInforme.Texto = rtbTexto.Text;
                oInforme.Tipo = "de Grupo";
                res = oInforme.agregarInforme();
                if (res == "")
                {
                    MessageBox.Show("Informe correctamente enviado");
                    tbTitulo.Focus();
                }
            }
            else
            {
                MessageBox.Show("Por favor llene los campos correspondientes");
            }
        }

        private void chbxAfirmacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxAfirmacion.Checked)
            {
                pnlBusqueda.Enabled = true;
                dgvMensajes.Visible = true;
                
                tbTitulo.Enabled = false;
            }
            else
            {
                lblTitulopanel.Visible = false;
                lblTituloMensaje.Visible = false;
                pnlBusqueda.Enabled = false;
                dgvMensajes.Visible = false;
                btnSeleccionar.Enabled = false;
                tbTitulo.Enabled = true;
            }
        }

        private void tbTitulo_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                (sender as TextBox).BackColor = Color.White;
            }
            if (sender is RichTextBox)
            {
                (sender as RichTextBox).BackColor = Color.White;
            }
        }

        private void btnListarInformes_Click(object sender, EventArgs e)
        {
            oInforme = new clsInforme();
            bsDatos = new BindingSource();
            bsDatos.DataSource = oInforme.listarInformes_Grupo(clsUtilidades.codigoGrupo);
            dgvMensajes.DataSource = bsDatos;
            if (dgvMensajes.DataSource != null)
            {
                dgvMensajes.Visible = true;
                dgvMensajes.Columns["id_informe"].Visible = false;
                dgvMensajes.Columns["tipo"].Visible = false;
                dgvMensajes.Columns["codigo_grupo"].Visible = false;
            }
        }
    }
}
