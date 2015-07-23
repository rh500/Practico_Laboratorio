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
    public partial class frmGrupoGestionIntegrantes : Form
    {
        public frmGrupoGestionIntegrantes()
        {
            InitializeComponent();
        }
        clsPersona oPersona;
        BindingSource bsDatos;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool x = true;

            if (tbDni.Text == "")
            {
                tbDni.BackColor = Color.Red;
                x = false;
            }
            if (tbNombre.Text == "")
            {
                tbNombre.BackColor = Color.Red;
                x = false;
            }
            if (tbApellido.Text == "")
            {
                tbApellido.BackColor = Color.Red;
                x = false;
            }
            if (tbDireccion.Text == "")
            {
                tbDireccion.BackColor = Color.Red;
                x = false;
            }
            if (tbTelefono.Text == "")
            {
                tbTelefono.BackColor = Color.Red;
                x = false;
            }
            if (!dtpFechaNac.Checked)
            {
                x = false;
            }
            if (x)
            {
                string exito;
                oPersona = new clsPersona();
                oPersona.Dni = tbDni.Text;
                oPersona.Nombre = tbNombre.Text;
                oPersona.Apellido = tbApellido.Text;
                oPersona.Telefono = tbTelefono.Text;
                oPersona.Fecha_nacimiento = dtpFechaNac.Value.Date;
                oPersona.Direccion = tbDireccion.Text;
                oPersona.Es_pareja = 0;
                oPersona.Codigo_grupo = clsUtilidades.codigoGrupo;
                exito = oPersona.agregarPersona();
                if (exito == "")
                {
                    MessageBox.Show("Integrante agregado correctamente");
                    if (MessageBox.Show("¿Desa agregar otro integrante?","", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        tbDni.Focus();
                    }
                    tbDni.Clear();
                    tbNombre.Clear();
                    tbApellido.Clear();
                    tbTelefono.Clear();
                    tbDireccion.Clear();
                    dtpFechaNac.Checked = false;
                    pnlBusqueda.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ya existe una persona con el DNI: " + tbDni.Text);
                }
            }
            else
            {
                MessageBox.Show("Por Favor llene los campos correspondientes");
            }
        }

        private void btnListarIntegrantes_Click(object sender, EventArgs e)
        {
            bsDatos = new BindingSource();
            oPersona = new clsPersona();
            bsDatos.DataSource = oPersona.listarIntegrantes(clsUtilidades.codigoGrupo);
            dgvIntegrantes.DataSource = bsDatos;
            if (dgvIntegrantes.Rows.Count != 0)
            {
                if (dgvIntegrantes.DataSource != null)
                {
                    pnlModificar.Visible = true;
                    dgvIntegrantes.Columns["codigo_grupo"].Visible = false;
                    dgvIntegrantes.Columns["es_pareja"].Visible = false;
                    dgvIntegrantes.Columns["eliminado"].Visible = false;
                    cbxFiltro.Enabled = true;
                    tbBusqueda.Enabled = true;
                    lblOpcion.Text = "Seleccione una Opcion";
                }
            }
          
        }

        private void cbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CAMBIAR EL TITULO DE LA BUSQUEDA
            if (cbxFiltro.SelectedIndex == 0)
            {
                lblBusqueda.Text = "Escriba Dni:";
            }
            if (cbxFiltro.SelectedIndex == 1)
            {
                lblBusqueda.Text = "Escriba Nombre:";
            }
            tbBusqueda.Text = "";
        }

        private void tbBusqueda_TextChanged(object sender, EventArgs e)
        {
            // FILTRAR REGISTROS
            if (dgvIntegrantes.DataSource != null)
            {
                if (cbxFiltro.SelectedIndex == 0)
                {
                    bsDatos.Filter = "dni like '" + tbBusqueda.Text + "%'";
                }
                if (cbxFiltro.SelectedIndex == 1)
                {
                    bsDatos.Filter = "nombre like '" + tbBusqueda.Text + "%'";
                }
            }
            
        }

        private void dgvIntegrantes_SelectionChanged(object sender, EventArgs e)
        {
            //para cambiar los datos de los campos a modificar
            int indice = dgvIntegrantes.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (indice != -1)
            {
                tbDniModif.Text = dgvIntegrantes["dni", indice].Value.ToString();
                tbNombreModif.Text = dgvIntegrantes["nombre", indice].Value.ToString();
                tbApellidoModif.Text = dgvIntegrantes["apellido", indice].Value.ToString();
                tbDireccionModif.Text = dgvIntegrantes["direccion", indice].Value.ToString();
                tbTelefonoModif.Text = dgvIntegrantes["telefono", indice].Value.ToString();
                dtpFechaNacModif.Value = Convert.ToDateTime(dgvIntegrantes["fecha_nacimiento", indice].Value);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool x = true;

            if (tbDniModif.Text == "")
            {
                tbDniModif.BackColor = Color.Red;
                x = false;
            }
            if (tbNombreModif.Text == "")
            {
                tbNombreModif.BackColor = Color.Red;
                x = false;
            }
            if (tbApellidoModif.Text == "")
            {
                tbApellidoModif.BackColor = Color.Red;
                x = false;
            }
            if (tbDireccionModif.Text == "")
            {
                tbDireccionModif.BackColor = Color.Red;
                x = false;
            }
            if (tbTelefonoModif.Text == "")
            {
                tbTelefonoModif.BackColor = Color.Red;
                x = false;
            }
            if (!dtpFechaNacModif.Checked)
            {
                x = false;
            }
            if (x)
            {
                string exito;
                oPersona = new clsPersona();
                oPersona.Dni = tbDniModif.Text;
                oPersona.Nombre = tbNombreModif.Text;
                oPersona.Apellido = tbApellidoModif.Text;
                oPersona.Telefono = tbTelefonoModif.Text;
                oPersona.Fecha_nacimiento = dtpFechaNacModif.Value.Date;
                oPersona.Direccion = tbDireccionModif.Text;
                oPersona.Es_pareja = 0;
                oPersona.Codigo_grupo = clsUtilidades.codigoGrupo;
                exito = oPersona.modificarPersona(tbDniModif.Text);
                if (exito == "")
                {
                    MessageBox.Show("Datos Modificados!");
                }
            }
            else
            {
                MessageBox.Show("Por favor llene los campos correspondientes");
            }
        }

        private void tbNombreModif_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
        }

        private void tbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void frmGrupoGestionIntegrantes_Load(object sender, EventArgs e)
        {
            frmGrupoPrincipal frmGPrincipal = new frmGrupoPrincipal();
            if (!frmGPrincipal.tiene_integrante)
            {
                pnlBusqueda.Enabled = false;
            }
        }


        
    }
}
