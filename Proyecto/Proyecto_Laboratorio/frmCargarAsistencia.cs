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
using System.Data.SqlClient;

namespace Proyecto_Laboratorio
{
    public partial class frmCargarAsistencia : Form
    {
        public frmCargarAsistencia()
        {
            InitializeComponent();
        }
        
        clsPersona oPersona;
        clsAsistencia oAsistencia;
        clsMensaje_Predica oMensaje;
        private void btnCargarFaltas_Click(object sender, EventArgs e)
        {
            string res = "";
            for (int i = 0; i < dgvIntegrantes.Rows.Count; i++)
            {

                oAsistencia = new clsAsistencia();
                oAsistencia.Dni = dgvIntegrantes["dni", i].Value.ToString();
                if (dgvIntegrantes["asistio?", i].Value != null)
                {
                    oAsistencia.Asistio = 1;
                }
                else
                {
                    oAsistencia.Asistio = 0;
                }
                oAsistencia.Fecha_creacion = DateTime.Now.Date;
                oMensaje = new clsMensaje_Predica();
                oMensaje.MensajeReciente();
                res = oAsistencia.agregarAsistencia(oMensaje.ID_mensaje);
            }
            if (res == "")
            {
                MessageBox.Show("Asistencias cargadas exitosamente");
                btnCargarFaltas.Visible = false;
            }
        }

        private void btnListarIntegrantes_Click(object sender, EventArgs e)
        {
            
            oPersona = new clsPersona();
            //dgvIntegrantes.DataSource = "";
            dgvIntegrantes.Columns.Clear();
            dgvIntegrantes.DataSource = oPersona.listarIntegrantes(clsUtilidades.codigoGrupo);
            if (dgvIntegrantes.Columns["asistencia"] != null)
            {
                dgvIntegrantes.Columns["asistencia"].Visible = false;
            }
            if (dgvIntegrantes.DataSource != null)
            {
                DataGridViewCheckBoxColumn columna = new DataGridViewCheckBoxColumn();
                columna.Name = "asistio?";
                columna.HeaderText = "Esta Presente?";
                dgvIntegrantes.Columns.Add(columna);

                dgvIntegrantes.Columns["codigo_grupo"].Visible = false;
                dgvIntegrantes.Columns["es_pareja"].Visible = false;
                dgvIntegrantes.Columns["eliminado"].Visible = false;
                dgvIntegrantes.Columns["dni"].ReadOnly = true;
                dgvIntegrantes.Columns["nombre"].ReadOnly = true;
                dgvIntegrantes.Columns["telefono"].ReadOnly = true;
                dgvIntegrantes.Columns["fecha_nacimiento"].ReadOnly = true;
                dgvIntegrantes.Columns["direccion"].ReadOnly = true;
                
            }

            btnCargarFaltas.Enabled = true;
            btnListarIntegrantes.Enabled = false;
        }

        private void btnListarAsistencias_Click(object sender, EventArgs e)
        {
            oAsistencia = new clsAsistencia();
            dgvIntegrantes.Columns.Clear();
            dgvIntegrantes.DataSource = oAsistencia.listarAsistencias(clsUtilidades.codigoGrupo);
            dgvIntegrantes.Columns.Add("asistencia", "Asistencia");

            if (dgvIntegrantes.Columns["asistio"] != null)
            {
                dgvIntegrantes.Columns["asistio"].Visible = false;
                for (int i = 0; i < dgvIntegrantes.Rows.Count; i++)
                {
                    if (dgvIntegrantes["asistio", i].Value.ToString() == "1")
                    {
                        dgvIntegrantes.Rows[i].Cells[5].Value = "Asistió";
                    }
                    else
                    {
                        dgvIntegrantes.Rows[i].Cells[5].Value = "Faltó";
                    }
                }
            }
        }



    }
}
