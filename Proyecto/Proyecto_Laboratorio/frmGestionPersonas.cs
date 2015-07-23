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
    public partial class frmGestionPersonas : Form
    {
        public frmGestionPersonas()
        {
            InitializeComponent();
        }
        clsGrupo oGrupo;
        clsPersona oPersona;
        BindingSource bsPersonas;
        BindingSource bsGrupos;
        BindingSource bsGrupos_Sin;
        private void frmAgregarPersonas_Load(object sender, EventArgs e)
        {
            /*LLENAR COMBOBOX CON EL NOMBRE GRUPOS*/
            oGrupo = new clsGrupo();
            
            cbGrupo.DataSource = oGrupo.listarGrupos_SIN();
            /**/
            if (cbGrupo.Items.Count == 0)
            {
                if (DialogResult.Yes == MessageBox.Show("No se encuentran Grupos Disponibles para Líderes, Desea crear uno?", "", MessageBoxButtons.YesNo))
                {
                    frmGestionGrupo formGestionG = new frmGestionGrupo();
                    formGestionG.ShowDialog();
                }
                else
                {
                    pnlAgregar.Enabled = false;
                }
            }
            else
            {
                cbGrupo.DisplayMember = "nombre";
                cbGrupo.ValueMember = "codigo_grupo";
            }
        }

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
            if (cbGrupo.SelectedItem == null)
            {
                x = false;
            }

            if (x)
            {
                string res = "";
                oPersona = new clsPersona();
                oPersona.Apellido = tbApellido.Text;
                oPersona.Codigo_grupo = Convert.ToInt32(cbGrupo.SelectedValue);
                oPersona.Direccion = tbDireccion.Text;
                oPersona.Dni = tbDni.Text;
                oPersona.Es_pareja = 1;
                oPersona.Fecha_nacimiento = dtpFechaNac.Value.Date;
                oPersona.Nombre = tbNombre.Text;
                oPersona.Telefono = tbTelefono.Text;
                res = oPersona.agregarPersona();
                if (res == "")
                {
                    MessageBox.Show("Lider de Grupo agregado correctamente");
                }
            }
            else
            {
                MessageBox.Show("Llene los campos correspondientes!");
            }
        }

        private void tbDni_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                (sender as TextBox).BackColor = Color.White;
            }
        }

        private void btnListarPersonas_Click(object sender, EventArgs e)
        {
            bsPersonas = new BindingSource();
            bsGrupos = new BindingSource();
            bsGrupos_Sin = new BindingSource();
            oPersona = new clsPersona();
            oGrupo = new clsGrupo();

            /*DISTINTOS BINDING SOURCE PARA LOS COMBOBOX*/
            bsGrupos.DataSource = oGrupo.listarGrupos();
            bsGrupos_Sin.DataSource = oGrupo.listarGrupos_SIN();
            bsPersonas.DataSource = oPersona.listarPersonas();
            /**/

            dgvListarPersonas.Columns.Clear();
            dgvListarPersonas.DataSource = bsPersonas;
            if (dgvListarPersonas.DataSource != null)
            {
                cbxFiltro.Enabled = true;
                tbBusqueda.Enabled = true;
                lblOpcion.Text = "Seleccione una Opcion" + "\n" + "de busqueda";
                
                /*PARA LA COLUMNA "ES PAREJA"*/
                pnlEliminar.Enabled = true;
                pnlModificar.Enabled = true;
                dgvListarPersonas.Columns.Add("Pareja", "Es Pareja");
                dgvListarPersonas.Columns["es_pareja"].Visible = false;
                for (int i = 0; i < dgvListarPersonas.Rows.Count; i++)
                {
                    if (dgvListarPersonas["es_pareja", i].Value.ToString() == "1")
                    {
                        dgvListarPersonas.Rows[i].Cells[8].Value = "Si";
                    }
                    else
                    {
                        dgvListarPersonas.Rows[i].Cells[8].Value = "No";
                    }
                }
                dgvListarPersonas.Columns["es_pareja"].Visible = false;
            }
        }

        private void cbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFiltro.SelectedIndex == 0)
            {
                lblBusqueda.Text = "Escriba Dni:";
            }
            if (cbxFiltro.SelectedIndex == 1)
            {
                lblBusqueda.Text = "Escriba Nombre:";
            }
            if (cbxFiltro.SelectedIndex == 2)
            {
                lblBusqueda.Text = "Escriba Nombre del Grupo:";
            }
            tbBusqueda.Text = "";
        }

        private void tbBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (cbxFiltro.SelectedIndex == 0)
            {
                bsPersonas.Filter = "dni like'" + tbBusqueda.Text + "%'";
            }
            if (cbxFiltro.SelectedIndex == 1)
            {
                bsPersonas.Filter = "nombre like'" + tbBusqueda.Text + "%'";
            }
            if (cbxFiltro.SelectedIndex == 2)
            {
                bsPersonas.Filter = "nombre_grupo like'" + tbBusqueda.Text + "%'";
            }
        }

        private void dgvListarPersonas_SelectionChanged(object sender, EventArgs e)
        {
            int indice = dgvListarPersonas.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (indice != -1)
            {
                tbDniModif.Text = dgvListarPersonas["dni", indice].Value.ToString();
                tbNombreModif.Text = dgvListarPersonas["nombre", indice].Value.ToString();
                tbApellidoModif.Text = dgvListarPersonas["apellido", indice].Value.ToString();
                tbTelefonoModif.Text = dgvListarPersonas["telefono", indice].Value.ToString();
                dtpFechaNacModif.Value = Convert.ToDateTime(dgvListarPersonas["fecha_nacimiento", indice].Value);
                tbDireccionModif.Text = dgvListarPersonas["direccion", indice].Value.ToString();
                tbDniEliminar.Text = dgvListarPersonas["dni", indice].Value.ToString();

                if (dgvListarPersonas["es_pareja", indice].Value.ToString() == "1")//SI ES PAREJA
                {
                    cbNombreGrupoModif.DataSource = bsGrupos_Sin;
                    cbLider.Visible = false;
                    lblPareja.Visible = false;
                }
                else//SI NO ES PAREJA
                {
                    cbNombreGrupoModif.DataSource = bsGrupos;
                    cbLider.SelectedIndex = 0;//para modificar si se convirtio en lider o no se convirtio
                    cbLider.Visible = true;
                    lblPareja.Visible = true;
                }
                cbNombreGrupoModif.DisplayMember = "nombre";
                cbNombreGrupoModif.ValueMember = "codigo_grupo";
            }
        }

        private void btnModificarDatos_Click(object sender, EventArgs e)
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
                oPersona.Codigo_grupo = Convert.ToInt32(cbNombreGrupoModif.SelectedValue);
                oPersona.Telefono = tbTelefonoModif.Text;
                oPersona.Direccion = tbDireccionModif.Text;
                oPersona.Fecha_nacimiento = dtpFechaNacModif.Value;
                if (cbLider.SelectedIndex == 0)
                {
                    oPersona.Es_pareja = 0;
                }
                else
                {
                    oPersona.Es_pareja = 1;
                }
                exito = oPersona.modificarPersona(tbDniModif.Text);
                if (exito == "")
                {
                    MessageBox.Show("Datos Modificados");
                }
            }
            else
            {
                MessageBox.Show("Por Favor Llene los campos correspondientes");
            }
        }

        private void cbLider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLider.SelectedIndex == 0)
            {
                cbNombreGrupoModif.DataSource = bsGrupos;
            }
            if (cbLider.SelectedIndex == 1)
            {
                cbNombreGrupoModif.DataSource = bsGrupos_Sin;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar a : " + tbNombreModif.Text + " " + tbApellidoModif.Text + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string exito = "";
                oPersona = new clsPersona();
                exito = oPersona.eliminarPersona(tbDniEliminar.Text);
                if (exito == "")
                {
                    MessageBox.Show("Eliminado Correctamente");
                }
            }
        }

    }

}
